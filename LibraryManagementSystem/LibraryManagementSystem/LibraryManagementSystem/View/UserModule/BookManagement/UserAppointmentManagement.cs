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
    public partial class UserAppointmentManagement : UserControl
    {
        public UserAppointmentManagement()
        {
            InitializeComponent();
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
        private void UserAppointmentManagement_Load(object sender, EventArgs e)
        {

            bt_Inquire_Click(null, null);
        }

        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            UserBookingInfoRequest request = new UserBookingInfoRequest()
            {
                ReaderID = UserCode,
                BookingPeople = UserName,
                Title = tb_Title.Text,
                BookCode = tb_BookCode.Text
            };
             

            List<Model.UserAppointmentManagement> Response = null;
            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                Response = BookManagementBLL.GetBookBookingList(request);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                if (Response != null)
                {
                    this.dgv_BookBooking.AutoGenerateColumns = false;
                    dgv_BookBooking.DataSource = Response;
                }
                else
                {
                    dgv_BookBooking.DataSource = null;
                }
            };
            worker.RunWorkerAsync();


        }

        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Title.Text = null;
            tb_BookCode.Text = null;
        }

        private void dgv_BookBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_BookBooking.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "取消预约")
            {
                var Title = dgv_BookBooking.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要取消预约书籍:《{Title}》", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    UserBookingInfoRequest request = new UserBookingInfoRequest()
                    {
                        ReaderID = UserCode,
                        BookingPeople = UserName,
                        Title = dgv_BookBooking.SelectedRows[0].Cells[1].Value.ToString(),
                        BookCode = dgv_BookBooking.SelectedRows[0].Cells[2].Value.ToString()
                    };
                    var Response = BookManagementBLL.CancelBookingBooks(request);
                    if (Response.IsSuccess)
                    {
                        dgv_BookBooking.DataSource = null;
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
}
