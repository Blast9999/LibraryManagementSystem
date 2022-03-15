using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookRequest : BasePageModel
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图书类型
        /// </summary>
        public string BookType { get; set; }
        /// <summary>
        /// 图书代码（书名简称加随机数字）
        /// </summary>
        public string BookCode { get; set; }
    }

    /// <summary>
    /// 修改图书传参
    /// </summary>
    public class ReviseBookRequest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
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
        /// <summary>
        /// 图书类型
        /// </summary>
        public string BookType { get; set; }
        /// <summary>
        /// 图书代码（书名简称加随机数字）
        /// </summary>
        public string BookCode { get; set; }
        /// <summary>
        /// 图书图片
        /// </summary>
        public string Picture { get; set; }
    }
    /// <summary>
    /// 用户借阅图书传参
    /// </summary>
    public class StudentBookBorrowingRequest
    {
        /// <summary>
        /// 图书ID
        /// </summary>
        public string BookID { get; set; }
        /// <summary>
        /// 借阅人ID
        /// </summary>
        public string ReaderID { get; set; }
        /// <summary>
        /// 借阅人姓名
        /// </summary>
        public string ReaderName { get; set; }
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
        public string BegintTime { get; set; }
        /// <summary>
        /// 规定还书时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 是否本人预约
        /// </summary>
        public bool IsMyself { get; set; }
    }
    /// <summary>
    /// 用户预约图书传参
    /// </summary>
    public class StudentBookLendInfoRequest
    {
        
        /// <summary>
        /// 预约着ID（学生学号）
        /// </summary>
        public string ReaderID { get; set; }

        /// <summary>
        /// 图书ID
        /// </summary>
        public string BookID { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图书代码
        /// </summary>
        public string BookCode { get; set; }


        /// <summary>
        /// 预约时间
        /// </summary>
        public string BookingDate { get; set; }


        /// <summary>
        /// 预约人姓名
        /// </summary>
        public string BookingPeople { get; set; }


        /// <summary>
        /// 预约结束时间（默认开始时间后五天）
        /// </summary>
        public string BookingEndDate { get; set; }
        /// <summary>
        /// 预约者是否逾期
        /// </summary>
        public bool IsOverdue { get; set; } = false;
    }
    /// <summary>
    /// 学生借阅图书历史传参
    /// </summary>
    public class HistoryLendInfoRequest : BasePageModel
    {
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StudentName { get; set; }
    }
    
}
