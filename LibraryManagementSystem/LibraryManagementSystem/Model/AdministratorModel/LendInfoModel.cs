using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LendInfoModel
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
        public string ReaderName { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 图书代码
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
        public string BegintDate
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStr(BegintTime);
            }
        }
        /// <summary>
        /// 设置的还书时间
        /// </summary>
        public string EndTime { get; set; }
        public string EndDate
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStr(EndTime);
            }
        }
        /// <summary>
        /// 是否逾期（0：未逾期，1已逾期）
        /// </summary>
        public string IsOverdue { get; set; }
        //public string Overdue { get { return IsOverdue == "0" ? "未逾期" : (IsOverdue == "1" ? "1已逾期" : ""); } }

        public string Overdue
        { 
            get 
            {
                if (DateTimeHelper.TimestampConvertToDateTime(EndTime) > Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd 00:00:01")))
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
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 提示
        /// </summary>
        public string Hint { get; set; } = "提醒还书";
    }
}
