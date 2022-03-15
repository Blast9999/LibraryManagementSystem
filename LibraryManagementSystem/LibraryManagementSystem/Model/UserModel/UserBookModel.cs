using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 图书借阅详情
    /// </summary>
    public class BookLending : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN { get; set; }
        /// <summary>
        /// 出版社
        /// </summary>
        public string PublishingHouse { get; set; }
        /// <summary>
        /// 出版时间
        /// </summary>
        public string PublicationDate { get; set; }
        public string PublicationTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(PublicationDate);
            }
        }
        /// <summary>
        /// 图书类型
        /// </summary>
        public string BookType { get; set; }
        /// <summary>
        /// 图书代码（书名简称加随机数字）
        /// </summary>
        public string BookCode { get; set; }
        /// <summary>
        /// 借阅次数
        /// </summary>
        public string NumBorrowed { get; set; }
        /// <summary>
        /// 图片
        /// </summary>
        public string Picture { get; set; }
        /// <summary>
        /// 是否借出（0-否；1-是）
        /// </summary>
        public string IsBorrow { get; set; }
        public string Borrow { get { return IsBorrow == "0" ? "未借出" : (IsBorrow == "1" ? "已借出" : ""); } }
        /// <summary>
        /// 是否被预约（0-否；1-是）
        /// </summary>
        public string IsBooking { get; set; }
        public string Booking { get { return IsBooking == "0" ? "未预约" : (IsBooking == "1" ? "已预约" : ""); } }
        /// <summary>
        /// 借出学生
        /// </summary>
        public string LoanStudent { get; set; }
        /// <summary>
        /// 借出学生学号
        /// </summary>
        public string LoanStudentCode { get; set; }
        /// <summary>
        /// 归还时间
        /// </summary>
        public string ReturnDate { get; set; }
        public string ReturnTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(ReturnDate);
            }
        }
        /// <summary>
        /// 预约学生
        /// </summary>
        public string BookingStudent { get; set; }
        /// <summary>
        /// 预约学生学号
        /// </summary>
        public string BookingStudentCode { get; set; }
        /// <summary>
        /// 预约时间
        /// </summary>
        public string BookingDate { get; set; }
        public string BookingTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(BookingDate);
            }
        }
        /// <summary>
        /// 预约结束时间
        /// </summary>
        public string BookingEndDate { get; set; }
        public string BookingEndTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(BookingEndDate);
            }
        }
    }

    /// <summary>
    /// 用户图书借阅列表信息
    /// </summary>
    public class UserLendInfo
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图书代码（书名简称加随机数字）
        /// </summary>
        public string BookCode { get; set; }
        /// <summary>
        /// ISBN
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// 借书时间
        /// </summary>
        public string BorrowingBookDate { get; set; }
        public string BorrowingBookTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(BorrowingBookDate);
            }
        }
        /// <summary>
        /// 规定还书时间
        /// </summary>
        public string ReturnBookDate { get; set; }
        public string ReturnBookTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(ReturnBookDate);
            }
        }
        /// <summary>
        /// 剩余天数
        /// </summary>
        public int RemainingDate
        {
            get
            {
                return (Convert.ToDateTime(ReturnBookTime)-DateTime.Now).Days;
            }
        }
        /// <summary>
        /// 是否逾期（0-否；1-是）
        /// </summary>
        public string IsOverdue { get; set; }
        public string Overdue { get { return IsOverdue == "0" ? "未逾期" : (IsOverdue == "1" ? "已逾期" : ""); } }


        public string Escheat { get; set; } = "归还";
    }

    /// <summary>
    /// 用户个人预约信息
    /// </summary>
    public class UserAppointmentManagement
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图书编号
        /// </summary>
        public string BookCode { get; set; }
        /// <summary>
        /// 预约时间
        /// </summary>
        public string BookingDate { get; set; }
        public string BookingTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(BookingDate);
            }
        }
        /// <summary>
        /// 预约结束时间
        /// </summary>
        public string BookingEndDate { get; set; }
        public string BookingEndTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStrTwo(BookingEndDate);
            }
        }
        /// <summary>
        /// 是否逾期
        /// </summary>
        public string IsOverdue
        {
            get
            {
                if (Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(BookingEndDate)) < Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")))
                {
                    return "已逾期";
                }
                else
                {
                    return "未逾期";
                }
            }
        }
        /// <summary>
        /// 取消预约
        /// </summary>
        public string Cancel { get; set; }="取消预约";
    }

}
