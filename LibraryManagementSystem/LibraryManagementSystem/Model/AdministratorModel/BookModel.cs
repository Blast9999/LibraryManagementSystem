using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookModel : BasePageModel
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
                return DateTimeHelper.TimestampConvertToDateStr(PublicationDate);
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
        public string Borrow { get { return IsBorrow == "0" ? "否" : (IsBorrow == "1" ? "是" : ""); } }
        /// <summary>
        /// 是否被预约（0-否；1-是）
        /// </summary>
        public string IsBooking { get; set; }
        public string Booking { get { return IsBooking == "0" ? "否" : (IsBooking == "1" ? "是" : ""); } }
        /// <summary>
        /// 删除
        /// </summary>
        public string Del { get; set; } = "删除";
        /// <summary>
        /// 操作
        /// </summary>
        public string Lend { get; set; } = "借阅";
    }
   


}

