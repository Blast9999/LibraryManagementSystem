using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户查询自己借阅图书信息传参
    /// </summary>
    public class UserLendInfoRequest
    {

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 读者ID    
        /// </summary>
        public string ReaderID { get; set; }
        /// <summary>
        /// 书名
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图书代码
        /// </summary>
        public string BookCode { get; set; }
    }
    /// <summary>
    /// 用户还书传参
    /// </summary>
    public class UserReturnBooksRequest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 读者ID    
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
        /// <summary>
        /// 规定还书时间
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// 实际还书时间
        /// </summary>
        public string ActualTime { get; set; }
        /// <summary>
        /// 是否逾期归还
        /// </summary>
        public string IsOverdue { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
