using BLL;
using Model;
using System;
using System.Collections;
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
    public partial class ReturnBooksForm : UserControl
    {
        public ReturnBooksForm()
        {
            InitializeComponent();
        }
        private void ReturnBooksForm_Load(object sender, EventArgs e)
        {
            bt_Inquire_Click(null, null);
        }
        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            UserLendInfoRequest request = new UserLendInfoRequest()
            {
                Name = UserName,
                ReaderID = UserCode,
                Title = tb_Title.Text,
                BookCode = tb_BookCode.Text
            };



            List<UserLendInfo> Response = null;
            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                Response = BookManagementBLL.GetUserBorrowBooksList(request);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                foreach (var item in Response)
                {
                    if (Convert.ToDateTime(item.ReturnBookTime) < DateTime.Now)
                    {
                        UserLendInfoRequest req = new UserLendInfoRequest()
                        {
                            Name = UserName,
                            ReaderID = UserCode,
                            Title = item.Title,
                            BookCode = item.BookCode
                        };
                        BookManagementBLL.OverdueAmendment(req);
                    }
                }


                if (Response != null)
                {
                    this.dgv_BorrowInfo.AutoGenerateColumns = false;
                    dgv_BorrowInfo.DataSource = Response;
                }
                else
                {
                    dgv_BorrowInfo.DataSource = null;
                }
            };
            worker.RunWorkerAsync();


        }

        private void dgv_BorrowInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_BorrowInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "归还")
            {
                var Title = dgv_BorrowInfo.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要归还书籍:《{Title}》", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {


                    UserReturnBooksRequest request = new UserReturnBooksRequest()
                    {
                        ID = dgv_BorrowInfo.SelectedRows[0].Cells[0].Value.ToString(),
                        ReaderID = UserCode,
                        ReaderName = UserName,
                        Title = dgv_BorrowInfo.SelectedRows[0].Cells[1].Value.ToString(),
                        BookCode = dgv_BorrowInfo.SelectedRows[0].Cells[2].Value.ToString(),
                        ISBN = dgv_BorrowInfo.SelectedRows[0].Cells[3].Value.ToString(),
                        BegintTime = DateTimeHelper.DateTimeConvertToTimestamp(Convert.ToDateTime(dgv_BorrowInfo.SelectedRows[0].Cells[4].Value)),
                        EndTime = DateTimeHelper.DateTimeConvertToTimestamp(Convert.ToDateTime(dgv_BorrowInfo.SelectedRows[0].Cells[5].Value)),
                        ActualTime = DateTimeHelper.DateTimeConvertToTimestamp(DateTime.Now),
                        IsOverdue = dgv_BorrowInfo.SelectedRows[0].Cells[7].Value.ToString() == "未逾期" ? "0" : "1",
                        Remark = ""
                    };




                    //IList list = (IList)dgv_BorrowInfo.DataSource; //'转换数据源
                    //list.RemoveAt(dgv_BorrowInfo.CurrentRow.Index);//’移除
                    //dgv_BorrowInfo.DataSource = null; //'为空
                    //dgv_BorrowInfo.DataSource = list;//’显示数据

                    var Response = BookManagementBLL.ReturnBooks(request);
                    if (Response.IsSuccess)
                    {
                        dgv_BorrowInfo.DataSource = null;
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
        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Title.Text = null;
            tb_BookCode.Text = null;
        }
        #region 用户数据
        /// <summary>
        /// 学生学号
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string UserName { get; set; }



        #endregion


    }
}
