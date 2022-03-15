using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 管理员查询学生预约图书列表查询传参
    /// </summary>
    public class BookingInfoRequest : BasePageModel
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

    /// <summary>
    /// 删除学生预约图书传参
    /// </summary>
    public class DelBookingInfoRequest
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
        /// 学生代码
        /// </summary>
        public string BookCode { get; set; }
    }

}
