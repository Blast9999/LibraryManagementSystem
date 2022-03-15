using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BookingInfoModel
    {

        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 读者ID（学生学号）
        /// </summary>
        public string ReaderID { get; set; }
        /// <summary>
        /// 读者姓名
        /// </summary>
        public string BookingPeople { get; set; }
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
        public string BookingTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStr(BookingDate);
            }
        }
        /// <summary>
        /// 预定结束时间（开始到结束默认5天）
        /// </summary>
        public string BookingEndDate { get; set; }
        public string BookingEndTime
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStr(BookingEndDate);
            }
        }
        /// <summary>
        /// 是否逾期
        /// </summary>
        public string Overdue
        {
            get
            {
                if (Convert.ToDateTime(DateTimeHelper.TimestampConvertToDateTime(BookingEndDate)) > Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")))
                {
                    return "未逾期";
                }
                else
                {
                    return "已逾期";
                }
            }
        }
        /// <summary>
        /// 删除
        /// </summary>
        public string Del { get; set; } = "删除";

    }
}
