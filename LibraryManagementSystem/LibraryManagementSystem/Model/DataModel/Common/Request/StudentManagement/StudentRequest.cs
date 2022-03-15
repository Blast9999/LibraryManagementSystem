using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class StudentRequest : BasePageModel
    {
        /// <summary>
        /// 学号
        /// </summary>
        public string StudentCode { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

    }


    /// <summary>
    /// 修改学生传参
    /// </summary>
    public class ReviseStudentRequest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public string StudentCode { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Mail { get; set; }
        /// <summary>
        /// 违章状态（0-未违章，1-已违章）
        /// </summary>
        public string ViolationStatus { get; set; }
        /// <summary>
        /// 累计借书量
        /// </summary>
        public string NumberBooksBorrowed { get; set; }
        /// <summary>
        /// 逾期归还次数
        /// </summary>
        public string OverdueReturnNum { get; set; }
        /// <summary>
        /// 是否存在逾期未归还书籍
        /// </summary>
        public string IsOverdue { get; set; }
        public string Overdue { get { return IsOverdue == "0" ? "不存在" : (IsOverdue == "1" ? "存在" : ""); } }
        /// <summary>
        /// 备注 
        /// </summary>
        public string Remark { get; set; }

        
       

    }
}
