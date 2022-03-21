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
    public partial class StudentBookBorrowing : Form
    {
        public StudentBookBorrowing()
        {
            InitializeComponent();
        }

        private void StudentBookBorrowing_Load(object sender, EventArgs e)
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
            tb_BookingStudent.Text = BookLending.BookingStudent == "" ? "" : string.Format("{0}({1})", BookLending.BookingStudent, BookLending.BookingStudentCode);
            tb_ReturnTime.Text = BookLending.ReturnTime;
            ///预约结束时间
            DateTime t1 = Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(BookLending.BookingEndDate));
            ///当前时间
            DateTime t2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
            //DateTime.Compare(t1, t2) > 0
            ///如果结束时间小于今天
            if (t1 >= t2)
            {
                tb_BookingTime.Text = BookLending.BookingTime == "" ? "" : string.Format("{0}至{1}", BookLending.BookingTime, BookLending.BookingEndTime);
            }
            else
            {
                tb_BookingTime.Text = BookLending.BookingTime == "" ? "" : string.Format("{0}至{1}——【已逾期】", BookLending.BookingTime, BookLending.BookingEndTime);
            }


            //tb_BookingTime.Text = BookLending.BookingTime == "" ? "" : string.Format("{0}至{1}", BookLending.BookingTime, BookLending.BookingEndTime);

        }


        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            var userCode = StudentHomepage.UserCode;
            var userName = StudentHomepage.UserName;
            var Prompt = "默认借阅30天!";
            StudentBookBorrowingRequest request = new StudentBookBorrowingRequest()
            {
                BookID = BookManagementBLL.ID,
                ReaderID = userCode,
                ReaderName = userName,
                Title = tb_Title.Text,
                BookCode = tb_BookCode.Text,
                ISBN = tb_ISBN.Text,
                BegintTime = DateTimeHelper.DateTimeConvertToTimestamp(DateTime.Now),
                EndTime = DateTimeHelper.DateTimeConvertToTimestamp(DateTime.Now.AddDays(30)),
                IsMyself = false
            };
            if (!string.IsNullOrEmpty(tb_LoanStudent.Text))
            {
                if (Convert.ToDateTime(BookLending.ReturnTime) < DateTime.Now)
                {
                    MessageBox.Show($"图书:《{ tb_Title.Text}》已被{tb_LoanStudent.Text}借出！\r\n 已逾期归还，暂不提供借阅服务！");
                    return;
                }
                else
                {
                    MessageBox.Show($"图书:《{ tb_Title.Text}》已被{tb_LoanStudent.Text}借出！");
                    return;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tb_BookingStudent.Text))
                {
                    if (userCode == BookLending.BookingStudentCode && userName == BookLending.BookingStudent)
                    {
                        if (Convert.ToDateTime(BookLending.BookingTime) > DateTime.Now)
                        {
                            MessageBox.Show($"您的预约的时间为{BookLending.BookingTime}，当前未到预约借阅时间！");
                            return;
                        }
                        else
                        {
                            request.IsMyself = true;
                        }
                    }
                    else
                    {
                        if (Convert.ToDateTime(BookLending.BookingTime) > DateTime.Now.AddDays(7))
                        {
                            request.EndTime = DateTimeHelper.DateTimeConvertToTimestamp(Convert.ToDateTime(BookLending.BookingTime).AddDays(-1));
                            Prompt = $"\r\n 还书时间为预约用户前一天:{Convert.ToDateTime(BookLending.BookingTime).AddDays(-1).ToString("yyyy年MM月dd日")}";
                        }
                        else
                        {
                            DateTime t1 = Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(BookLending.BookingEndDate));
                            ///当前时间
                            DateTime t2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
                            if (t1 <= t2)
                            {
                                //如果预约者预约时间已逾期，则可以直接借出
                                DialogResult dialogResult = MessageBox.Show($"当前预约者【{tb_BookingStudent.Text}】预约结束时间为【{t1.ToString()}】预约已逾期，是否继续提交借阅信息？", "提示：",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                //判断用户最终点击那个按钮
                                if (dialogResult != DialogResult.Yes)
                                {
                                    return;
                                }

                            }
                            else
                            {
                                MessageBox.Show($"图书:《{ tb_Title.Text}》已被{tb_BookingStudent.Text}预约！");
                                return;
                            }


                            
                        }
                    }
                }

            }


            DialogResult result = MessageBox.Show("确定借阅当前书籍？", "提示：",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //判断用户最终点击那个按钮
            if (result == DialogResult.Yes)
            {
                var response = BookManagementBLL.BorrowBooks(request);
                if (response.IsSuccess)
                {
                    MessageBox.Show(response.Info + Prompt);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(response.Info);
                }
            }


        }
        /// <summary>
        /// 预约
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Booking_Click(object sender, EventArgs e)
        {
            StudentBookLendInfoRequest request = new StudentBookLendInfoRequest()
            {
                BookID = BookManagementBLL.ID,
                ReaderID = StudentHomepage.UserCode,
                Title = tb_Title.Text,
                BookCode = tb_BookCode.Text,
                BookingPeople = StudentHomepage.UserName
            };
          


            if (!string.IsNullOrEmpty(tb_BookingStudent.Text))
            {
                ///预约结束时间
                DateTime t1 = Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(BookLending.BookingEndDate));
                ///当前时间
                DateTime t2 = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));
                if (t1 <= t2)
                {
                    //如果预约者预约时间已逾期，则可以直接预约
                    DialogResult result = MessageBox.Show($"当前预约者【{tb_BookingStudent.Text}】预约结束时间为【{t1.ToString()}】预约已逾期，是否继续提交预约信息？", "提示：",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //判断用户最终点击那个按钮
                    if (result != DialogResult.Yes)
                    {
                        //request.IsOverdue = true;
                        return;
                    }

                }
                else
                {
                    MessageBox.Show($"书籍《{tb_Title.Text}》已被{tb_BookingStudent.Text}预约！");
                    return;
                }

            }

            if (string.IsNullOrEmpty(tb_LoanStudent.Text))//如果借出学生为空
            {
                if (dt_StartTime.Value > DateTime.Now.AddDays(7) || dt_StartTime.Value < DateTime.Now.AddHours(-1))
                {
                    MessageBox.Show("只接受预约七天内的预约！");
                    dt_StartTime.Text = DateTime.Now.ToString();
                    return;
                }
                else
                {
                    request.BookingDate = DateTimeHelper.DateTimeConvertToTimestamp(dt_StartTime.Value);
                    request.BookingEndDate = DateTimeHelper.DateTimeConvertToTimestamp(dt_StartTime.Value.AddDays(5));
                }
            }
            else
            {
                if (Convert.ToDateTime(tb_ReturnTime.Text) > DateTime.Now)//如果还书时间大于当前日期，则判断预约时间是否大于还书时间
                {
                    if (Convert.ToDateTime(tb_ReturnTime.Text) > dt_StartTime.Value || dt_StartTime.Value > Convert.ToDateTime(tb_ReturnTime.Text).AddDays(7))
                    {
                        MessageBox.Show("预约时间必须大于对方还书时间,并且不超过还书时间七天！");
                        dt_StartTime.Value = Convert.ToDateTime(tb_ReturnTime.Text).AddDays(1);
                        return;
                    }
                    else
                    {
                        request.BookingDate = DateTimeHelper.DateTimeConvertToTimestamp(dt_StartTime.Value);
                        request.BookingEndDate = DateTimeHelper.DateTimeConvertToTimestamp(dt_StartTime.Value.AddDays(5));
                    }
                }
                else
                {//如果还书时间小于当前时期，则说明该用户逾期未还
                    MessageBox.Show("该用户逾期未还，暂不提供预约操作！");
                    return;
                }
            }



            var response = BookManagementBLL.BookingBook(request);
            if (response.IsSuccess)
            {
                MessageBox.Show(response.Info);
                this.Close();
            }
            else
            {
                MessageBox.Show(response.Info);
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



        #region 图书详细借阅信息
        /// <summary>
        /// 图书详细借阅信息
        /// </summary>
        public BookLending BookLending { get; set; }


        #endregion


    }
}
