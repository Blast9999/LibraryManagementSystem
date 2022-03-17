using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowBooks : UserControl
    {
        public BorrowBooks()
        {
            InitializeComponent();
        }
        private void BorrowBooks_Load(object sender, EventArgs e)
        {
            bt_Inquire_Click(null, null);
            var Response = BookManagementBLL.GetBookType();
            List<string> TypeName = new List<string>();
            TypeName.Add("全部");
            foreach (var item in Response)
            {
                TypeName.Add(item.Name);
            }
            cb_BookType.DataSource = TypeName;
            List<string> PageSize = new List<string>();
            PageSize.Add("1");
            PageSize.Add("5");
            PageSize.Add("10");
            PageSize.Add("20");
            PageSize.Add("50");
            cb_PageSize.DataSource = PageSize;
            cb_PageSize.SelectedIndex = 3;
        }
        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            BookManagementBLL.PageNum = 1;
            BookRequest bookRequest = new BookRequest()
            {
                Title = tb_Title.Text,
                BookType = cb_BookType.Text == "全部" ? "" : cb_BookType.Text,
                BookCode = tb_BookCode.Text,
                PageNum = BookManagementBLL.PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };


            List<BookModel> Response = null;
            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                 Response = BookManagementBLL.GetBooks(bookRequest, out totalPage);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                if (Response != null)
                {
                    this.dgv_Book.AutoGenerateColumns = false;
                    this.label4.Text = string.Format("{0}/{1}", BookManagementBLL.PageNum, totalPage);
                    foreach (var item in Response)
                    {
                        if (Convert.ToInt32(item.NumBorrowed) >= 1)
                        {

                        }
                    }
                    dgv_Book.DataSource = Response;
                }
                else
                {
                    dgv_Book.DataSource = null;
                }
            };
            worker.RunWorkerAsync();


        }

        #region 分页数据
        int totalPage;//总页数
        #endregion


        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (btn.Text == "首页")
                {
                    BookManagementBLL.PageNum = 1;
                }
                else if (btn.Text == "上一页")
                {
                    BookManagementBLL.PageNum--;
                    if (BookManagementBLL.PageNum <= 0)
                    {
                        BookManagementBLL.PageNum = 1;
                    }
                }
                else if (btn.Text == "下一页")
                {
                    BookManagementBLL.PageNum++;
                    if (BookManagementBLL.PageNum >= totalPage)
                    {
                        BookManagementBLL.PageNum = totalPage;
                    }
                }
                else if (btn.Text == "尾页")
                {
                    BookManagementBLL.PageNum = totalPage;
                }
                else
                {
                    BookManagementBLL.PageNum = 1;
                }
            }

            BookRequest bookRequest = new BookRequest()
            {
                Title = tb_Title.Text,
                BookType = cb_BookType.Text == "全部" ? "" : cb_BookType.Text,
                BookCode = tb_BookCode.Text,
                PageNum = BookManagementBLL.PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.Text)
            };

            var Response = BookManagementBLL.GetBooks(bookRequest, out totalPage);
            if (Response != null)
            {
                this.dgv_Book.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", BookManagementBLL.PageNum, totalPage);
                dgv_Book.DataSource = Response;
            }
            else
            {
                dgv_Book.DataSource = null;
            }
        }

        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Title.Text = null;
            cb_BookType.SelectedIndex = 0;
            tb_BookCode.Text = null;
            cb_PageSize.SelectedIndex = 3;
        }

        private void dgv_Book_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BookManagementBLL.ID = dgv_Book.SelectedRows[0].Cells[0].Value.ToString();
            BookManagementBLL.Title = dgv_Book.SelectedRows[0].Cells[1].Value.ToString();
            BookManagementBLL.Author = dgv_Book.SelectedRows[0].Cells[2].Value.ToString();
            BookManagementBLL.ISBN = dgv_Book.SelectedRows[0].Cells[3].Value.ToString();
            BookManagementBLL.PublishingHouse = dgv_Book.SelectedRows[0].Cells[4].Value.ToString();
            BookManagementBLL.PublicationDate = dgv_Book.SelectedRows[0].Cells[5].Value.ToString();
            BookManagementBLL.BookType = dgv_Book.SelectedRows[0].Cells[6].Value.ToString();
            BookManagementBLL.BookCode = dgv_Book.SelectedRows[0].Cells[7].Value.ToString();
            BookManagementBLL.Picture = dgv_Book.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void dgv_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_Book.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "借阅")
            {
                StudentBookBorrowing borrowing = new StudentBookBorrowing();
                BookManagementBLL.ID = dgv_Book.SelectedRows[0].Cells[0].Value.ToString();
                borrowing.ShowDialog();
                dgv_Book.DataSource = null;
                bt_Inquire_Click(null, null);

            }
        }
    }
}
