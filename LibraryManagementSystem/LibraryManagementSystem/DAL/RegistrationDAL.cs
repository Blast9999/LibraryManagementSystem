using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegistrationDAL
    {

        /// <summary>
        /// 管理员注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static ReturnData AddAdministrator(Administrator request)
        {
            ReturnData returnData = new ReturnData();

            try
            {

                string sqlStaffCode = string.Format("SELECT * FROM dbo.Staff WHERE StaffCode='{0}'", request.LoginCode);
                string sqlJobNumber = string.Format("SELECT * FROM dbo.Staff WHERE JobNumber='{0}'", request.JobNumber);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 0)
                {
                    returnData.Info = "登录账号重复";
                    returnData.IsSuccess = false;
                }
                else if (int.Parse(DBHelper.GetDataTable(sqlJobNumber).Rows.Count.ToString()) > 0)
                {
                    returnData.Info = "职工工号重复";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }


                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("INSERT  dbo.Staff(StaffCode,Password,Name,Phone,StaffType,JobNumber) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')"
                            , request.LoginCode, request.Password, request.Name, request.Phone, request.StaffType, request.JobNumber);

                    if (DBHelper.ExecuteNonQuery(sqlInsert))
                    {
                        returnData.Info = "注册成功";
                        returnData.IsSuccess = true;
                    }
                }
                return returnData;

            }
            catch (Exception)
            {

                returnData.Info = "注册失败，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }

        /// <summary>
        /// 学生注册
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static ReturnData AddStudent(StudentRegistration request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Student WHERE StudentCode='{0}'", request.LoginCode);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 0)
                {
                    returnData.Info = "学生学号重复";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("INSERT  dbo.Student(StudentCode,Password,StudentName,Phone,Sex,Mail,Remark) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')"
                            , request.LoginCode, request.Password, request.Name, request.Phone, request.Sex, request.Mail, request.Remark);

                    if (DBHelper.ExecuteNonQuery(sqlInsert))
                    {
                        returnData.Info = "注册成功";
                        returnData.IsSuccess = true;
                    }
                }
                return returnData;

            }
            catch (Exception)
            {

                returnData.Info = "注册失败，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }


        /// <summary>
        /// 查询员工类型列表
        /// </summary>
        /// <returns></returns>
        public static List<StaffType> GetStaffType()
        {
            string sql = "SELECT * FROM dbo.StaffType";
            DataTable dt = DBHelper.GetDataTable(sql);
            List<StaffType> list = new List<StaffType>();

            foreach (DataRow rows in dt.Rows)
            {
                StaffType staffType = new StaffType();
                staffType.Code = rows["Code"].ToString();
                staffType.TypeNane = rows["TypeName"].ToString();
                list.Add(staffType);
            }
            return list;
        }
    }
}
