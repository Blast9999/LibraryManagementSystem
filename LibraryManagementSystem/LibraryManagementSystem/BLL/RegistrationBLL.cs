using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RegistrationBLL
    {
        /// <summary>
        /// 注册管理员
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static ReturnData AddAdministrator(Administrator request)
        {
            return RegistrationDAL.AddAdministrator(request);
        }

        public static ReturnData AddStudent(StudentRegistration request)
        {
            return RegistrationDAL.AddStudent(request);
        }

        /// <summary>
        /// 查询员工类型列表
        /// </summary>
        /// <returns></returns>
        public static List<StaffType> GetStaffType()
        {
            return RegistrationDAL.GetStaffType();
        }
    }
}
