using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HistoryLendInfoModel
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
        /// 规定还书时间
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
        /// 实际还书时间
        /// </summary>
        public string ActualTime { get; set; }
        public string ActualDate
        {
            get
            {
                return DateTimeHelper.TimestampConvertToDateStr(ActualTime);
            }
        }
        /// <summary>
        /// 是否逾期归还（0—否，1—是）
        /// </summary>
        public string IsOverdue { get; set; }
        public string Overdue { get { return IsOverdue == "0" ? "否" : (IsOverdue == "1" ? "是" : ""); } }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 删除
        /// </summary>
        public string Del { get; set; } = "删除";
    }
}
