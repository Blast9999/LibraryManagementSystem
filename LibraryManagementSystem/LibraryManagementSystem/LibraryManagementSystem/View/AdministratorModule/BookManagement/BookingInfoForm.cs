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
    public partial class BookingInfoForm : UserControl
    {
        public BookingInfoForm()
        {
            InitializeComponent();
        }
        #region 分页数据
        /// <summary>
        /// 当前页
        /// </summary>
        public static int? PageNum { get; set; } = 1;
        /// <summary>
        /// 每页数量
        /// </summary>
        public static int? PageSize { get; set; } = 10;
        int totalPage;//总页数
        #endregion
        private void BookingInfoForm_Load(object sender, EventArgs e)
        {
            List<string> PageSize = new List<string>();
            PageSize.Add("1");
            PageSize.Add("5");
            PageSize.Add("10");
            PageSize.Add("20");
            PageSize.Add("50");
            cb_PageSize.DataSource = PageSize;
            cb_PageSize.SelectedIndex = 3;

            bt_Inquire_Click(null, null);
        }

        private void bt_Inquire_Click(object sender, EventArgs e)
        {
            BookingInfoRequest request = new BookingInfoRequest()
            {
                Title = tb_Title.Text,
                StudentName = tb_StudentName.Text,
                PageNum = PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };


            BackgroundWorker worker = new BackgroundWorker();//使用了worker线程，加快了页面的响应速度，从而使页面响应更加流程
            worker.DoWork += delegate (object obj, DoWorkEventArgs dw)
            {
                bookings = BookManagementBLL.GetBookingInfoList(request, out totalPage);
            };
            worker.RunWorkerCompleted += delegate (object obj, RunWorkerCompletedEventArgs rwc)
            {
                if (bookings != null)
                {
                    this.dgv_BookBookingInfo.AutoGenerateColumns = false;
                    this.label4.Text = string.Format("{0}/{1}", PageNum, totalPage);
                    dgv_BookBookingInfo.DataSource = bookings;
                }
                else
                {
                    dgv_BookBookingInfo.DataSource = null;
                }
            };
            worker.RunWorkerAsync();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = sender as Button;

                if (btn.Text == "首页")
                {
                    PageNum = 1;
                }
                else if (btn.Text == "上一页")
                {
                    PageNum--;
                    if (PageNum <= 0)
                    {
                        PageNum = 1;
                    }
                }
                else if (btn.Text == "下一页")
                {
                    PageNum++;
                    if (PageNum >= totalPage)
                    {
                        PageNum = totalPage;
                    }
                }
                else if (btn.Text == "尾页")
                {
                    PageNum = totalPage;
                }
                else
                {
                    PageNum = 1;
                }
            }


            BookingInfoRequest request = new BookingInfoRequest()
            {
                Title = tb_Title.Text,
                StudentName = tb_StudentName.Text,
                PageNum = PageNum,
                PageSize = Convert.ToInt32(cb_PageSize.SelectedItem)
            };

            bookings = BookManagementBLL.GetBookingInfoList(request, out totalPage);

            if (bookings != null)
            {
                this.dgv_BookBookingInfo.AutoGenerateColumns = false;
                this.label4.Text = string.Format("{0}/{1}", PageNum, totalPage);
                dgv_BookBookingInfo.DataSource = bookings;

            }
            else
            {
                dgv_BookBookingInfo.DataSource = null;
            }
        }

        private void tb_Reset_Click(object sender, EventArgs e)
        {
            tb_Title.Text = null;
            tb_StudentName.Text = null;
        }
        /// <summary>
        /// 检索过期预约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //dgv_BookBookingInfo.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;

            int num = 0;
            foreach (var item in bookings)
            {
                if (Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(item.BookingEndDate)) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")))
                {
                    dgv_BookBookingInfo.Rows[num].DefaultCellStyle.BackColor = Color.Red;
                }
                num++;
            }
        }
        /// <summary>
        /// 取消预约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_BookBookingInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string buttonText = this.dgv_BookBookingInfo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (buttonText == "删除")
            {
                var Title = dgv_BookBookingInfo.SelectedRows[0].Cells[3].Value.ToString();
                var Name = dgv_BookBookingInfo.SelectedRows[0].Cells[2].Value.ToString();
                var BookCode = dgv_BookBookingInfo.SelectedRows[0].Cells[4].Value.ToString();
                DialogResult result = MessageBox.Show($"确定要删除并取消学生【{Name}】预约的书籍:《{Title}》", "提示：",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    var ID = dgv_BookBookingInfo.SelectedRows[0].Cells[0].Value.ToString();

                    DelBookingInfoRequest request = new DelBookingInfoRequest()
                    {
                        ID = ID,
                        Title = Title,
                        BookCode = BookCode

                    };
                    var Response = BookManagementBLL.DelBookingInfo(request);
                    if (Response.IsSuccess)
                    {
                        dgv_BookBookingInfo.DataSource = null;
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
        /// <summary>
        /// 数据源
        /// </summary>
        List<BookingInfoModel> bookings = new List<BookingInfoModel>();


    }
}
