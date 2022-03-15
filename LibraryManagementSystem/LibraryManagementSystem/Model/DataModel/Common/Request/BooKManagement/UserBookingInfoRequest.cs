using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 用户查询自己预约图书信息传参
    /// </summary>
    public class UserBookingInfoRequest
    {
        /// <summary>
        ///预约者ID(学生学号)
        /// </summary>
        public string ReaderID { get; set; }
        /// <summary>
        ///预约者姓名
        /// </summary>
        public string BookingPeople { get; set; }
        /// <summary>
        ///书名
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        ///图书代码
        /// </summary>
        public string BookCode { get; set; }
    }
}
