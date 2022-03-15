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
    public partial class BookDetails : Form
    {
        public BookDetails()
        {
            InitializeComponent();
        }
        #region 页面数据信息
        /// <summary>
        /// 图书详细借阅信息
        /// </summary>
        public BookLending BookLending { get; set; }
        public bool IsExpired { get; set; } = false;
        #endregion
        private void BookDetails_Load(object sender, EventArgs e)
        {
            try
            {
                BookLending = BookManagementBLL.BookBorrowingDetails();
                tb_Title.Text = BookLending.Title;
                tb_Author.Text = BookLending.Author;
                tb_ISBN.Text = BookLending.ISBN;
                tb_PublishingHouse.Text = BookLending.PublishingHouse;
                tb_PublicationDate.Text = BookLending.PublicationTime;
                var Picture = BookManagementBLL.Picture == "" ? "noImg.jpg" : BookLending.Picture;
                this.pb_BookPictures.Image = Image.FromFile(@"..\..\Resources\BookPictures\" + Picture);
                tb_Type.Text = BookLending.BookType;
                tb_BookCode.Text = BookLending.BookCode;
                tb_NumBorrowed.Text = BookLending.NumBorrowed;
                tb_IsBorrow.Text = BookLending.Borrow;
                tb_IsBooking.Text = BookLending.Booking;
                tb_LoanStudent.Text = BookLending.LoanStudent == "" ? "" : string.Format("{0}({1})", BookLending.LoanStudent, BookLending.LoanStudentCode);
                tb_BookingStudent.Text = BookLending.BookingStudent == "" ? "" : string.Format("{0}({1})", BookLending.BookingStudent, BookLending.BookingStudentCode); ;
                tb_ReturnTime.Text = BookLending.ReturnTime;
                ///预约结束时间
                DateTime t1 = Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(BookLending.BookingEndTime));
                ///当前时间
                DateTime t2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
                //DateTime.Compare(t1, t2) > 0
                ///如果结束时间小于今天
                if (t1 >= t2)
                {
                    tb_BookingTime.Text = BookLending.BookingTime == "" ? "" : string.Format("{0}至{1}", BookLending.BookingTime, BookLending.BookingEndTime);
                    IsExpired = false;
                }
                else
                {
                    tb_BookingTime.Text = BookLending.BookingTime == "" ? "" : string.Format("{0}至{1}——【已逾期】", BookLending.BookingTime, BookLending.BookingEndTime);
                    IsExpired = true;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("未选择图书！");
            }

        }
        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_LoanStudent.Text))
            {
                MessageBox.Show($"图书已被学生【{tb_LoanStudent.Text}】借出不可删除！");
            }
            else if (!string.IsNullOrEmpty(tb_BookingStudent.Text))
            {
                MessageBox.Show($"图书已被学生【{tb_BookingStudent.Text}】预约不可删除！");
            }
            else
            {
                DialogResult result = MessageBox.Show($"确定要删除籍:《{tb_Title.Text}》", "提示：",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //判断用户最终点击那个按钮
                if (result == DialogResult.Yes)
                {
                    var Response = BookManagementBLL.DelBook(BookManagementBLL.ID);
                    if (Response.IsSuccess)
                    {
                        MessageBox.Show(Response.Info);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(Response.Info);
                    }
                }


                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
