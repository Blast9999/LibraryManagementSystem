using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 管理员查询学生借阅图书列表查询传参
    /// </summary>
    public class LendInfoRequest : BasePageModel
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
