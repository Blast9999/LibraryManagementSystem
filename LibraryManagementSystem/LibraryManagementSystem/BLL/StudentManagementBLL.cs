using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class StudentManagementBLL
    {
        /// <summary>
        /// 分页查询学生
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<StudentModel> GetStudent(StudentRequest request, out int totalPage)
        {
            return StudentManagementDAL.GetStudent(request, out totalPage);
        }

        /// <summary>
        /// 修改学生
        /// </summary>
        /// <param name="request"></param>
        /// <param name="Type">0—管理员修改学生，1—学生自己修改</param>
        /// <returns></returns>
        public static ReturnData UpdateStudent(ReviseStudentRequest request,string Type)
        {
            return StudentManagementDAL.UpdateStudent(request, Type);
        }
        /// <summary>
        /// 新增学生
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddStudent(ReviseStudentRequest request)
        {
            return StudentManagementDAL.AddStudent(request);
        }
        /// <summary>
        /// 删除学生
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelStaff(string ID)
        {
            return StudentManagementDAL.DelStaff(ID);
        }
        /// <summary>
        /// 查询学生个人信息
        /// </summary>
        /// <param name="Code">学号</param>
        /// <param name="Name">姓名</param>
        /// <returns></returns>
        public static StudentModel GetStudentPersonalInformation(string Code, string Name)
        {
            return StudentManagementDAL.GetStudentPersonalInformation(Code, Name);
        }
        #region 页面数据


        #region 学生数据
        public static string ID;
        public static string StudentCode;
        public static string Password;
        public static string StudentName;
        public static string Phone;
        public static string Sex;
        public static string Mail;
        public static string ViolationStatusName;
        public static string NumberBooksBorrowed;
        public static string OverdueReturnNum;//逾期归还次数
        public static string Remark;
        #endregion

        #region 分页数据
        /// <summary>
        /// 当前页
        /// </summary>
        public static int? PageNum { get; set; } = 1;
        /// <summary>
        /// 每页数量
        /// </summary>
        public static int? PageSize { get; set; } = 10;
        #endregion

        #endregion
    }
}
