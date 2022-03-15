using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoginUser
    {
       /// <summary>
       /// 账号
       /// </summary>
        public string LoginCode { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public string JobNumber { get; set; } = null;
        /// <summary>
        /// 违章状态（0-未违章，1-已违章）
        /// </summary>
        public int? ViolationStatus { get; set; }=null;
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}
