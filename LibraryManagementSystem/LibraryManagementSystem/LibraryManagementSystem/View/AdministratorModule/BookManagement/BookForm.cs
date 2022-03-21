using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BookForm : UserControl
    {
        public BookForm()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;//用双缓冲绘制窗口的所有子控件
                return cp;
            }
        }
        private void BookForm_Load(object sender, EventArgs e)
        {
            //bt_Inquire_Click(null, null);
            var Response = BookManagementBLL.GetBookType();
            if (Response != null)
            {
                List<string> TypeName = new List<string>();
                TypeName.Add("全部");
                foreach (var item in Response)
                {
                    TypeName.Add(item.Name);
                }
                cb_BookType.DataSource = TypeName;
            }

            List<string> PageSize = new List<string>();
            PageSize.Add("1");
            PageSize.Add("5");
            PageSize.Add("10");
            PageSize.Add("20");
            PageSize.Add("50");
            cb_PageSize.DataSource = PageSize;
            cb_PageSize.SelectedIndex = 3;
        }
        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Title.Text = null;
            cb_BookType.Text = null;
            tb_BookCode.Text = null;
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
                //Thread.Sleep(5000);//线程暂停5秒
                Response = BookManagementBLL.GetBooks(bookRequest, out totalPage);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
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
            };
            worker.RunWorkerAsync();


        }
        /// <summary>
        /// 页面跳转
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void dgv_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


        #region 分页数据
        int totalPage;//总页数
        #endregion


        private void bt_Update_Click(object sender, EventArgs e)
        {
            EditBook editBook = new EditBook();
            if (!string.IsNullOrEmpty(BookManagementBLL.Title))
            {
                editBook.ShowDialog();
                dgv_Book.DataSource = null;
                bt_Inquire_Click(null, null);
            }
            else
            {
                MessageBox.Show("请先选择数据！");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.ShowDialog();
            dgv_Book.DataSource = null;
            bt_Inquire_Click(null, null);
        }
        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Book_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            string buttonText = this.dgv_Book.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            var IsBorrow = dgv_Book.SelectedRows[0].Cells[10].Value.ToString();
            var IsReserve = dgv_Book.SelectedRows[0].Cells[11].Value.ToString();
            if (buttonText == "删除")
            {
                if (IsBorrow == "是")
                {
                    MessageBox.Show("图书已被借走，无法删除！");
                    return;
                }
                else if (IsReserve == "是")
                {
                    MessageBox.Show("图书已被预约，无法删除！");
                    return;
                }
                else
                {
                    var Title = dgv_Book.SelectedRows[0].Cells[1].Value.ToString();
                    DialogResult result = MessageBox.Show($"确定要删除书籍:《{Title}》", "提示：",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //判断用户最终点击那个按钮
                    if (result == DialogResult.Yes)
                    {
                        var ID = dgv_Book.SelectedRows[0].Cells[0].Value.ToString();
                        var Response = BookManagementBLL.DelBook(ID);
                        if (Response.IsSuccess)
                        {
                            dgv_Book.DataSource = null;
                            bt_Inquire_Click(null, null);
                            MessageBox.Show(Response.Info);
                        }
                        else
                        {
                            MessageBox.Show(Response.Info);
                        }
                    }
                }

            }
        }

        /// <summary>
        /// 双击获取详细信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_Book_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BookDetails bookDetails = new BookDetails();
            if (!string.IsNullOrEmpty(BookManagementBLL.ID))
            {
                bookDetails.ShowDialog();
                dgv_Book.DataSource = null;
                bt_Inquire_Click(null, null);
            }
            else
            {
                MessageBox.Show("请双击图书列表查看详细信息！");
            }
        }



    }
}
