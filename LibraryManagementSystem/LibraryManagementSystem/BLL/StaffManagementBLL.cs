using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffManagementBLL
    {
        /// <summary>
        /// 分页查询学生
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static List<StaffModel> GetStudent(StaffRequest request)
        {
            return StaffManagementDAL.GetStudent(request);
        }
        /// <summary>
        /// 修改职员
        /// </summary>
        /// <returns></returns>
        public static ReturnData UpdateStaff(ReviseStaffRequest request)
        {
            return StaffManagementDAL.UpdateStaff(request);
        }

        /// <summary>
        /// 修改职员
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddStaff(ReviseStaffRequest request)
        {
            return StaffManagementDAL.AddStaff(request);
        }
        /// <summary>
        /// 删除职员
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelStaff(string ID)
        {
            return StaffManagementDAL.DelStaff(ID);
        }
        #region 职员数据
        public static string ID;
        public static string StaffCode;
        public static string Password;
        public static string Name;
        public static string Phone;
        public static string TypeName;
        public static string JobNumber;
        #endregion


    }


}
