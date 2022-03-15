using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffManagementDAL
    {
        /// <summary>
        /// 分页查询学生
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<StaffModel> GetStudent(StaffRequest request)
        {
            string sql = "Staff_Inquire";
            SqlParameter[] paras =
            {
                new SqlParameter("@Name",request.Name),
                new SqlParameter("@Type",request.Type),
                new SqlParameter("@JobNumber",request.JobNumber),
            };
            //除了字符串类型 其它参数 设置参数类型 Size
            paras[0].SqlDbType = SqlDbType.VarChar;
            paras[1].SqlDbType = SqlDbType.VarChar;
            paras[2].SqlDbType = SqlDbType.VarChar;
            DataTable dt = DBHelper.GetDataTableByProcedure(sql, paras);
            List<StaffModel> list = new List<StaffModel>();
            foreach (DataRow rows in dt.Rows)
            {
                StaffModel student = new StaffModel();
                student.ID = int.Parse(rows["ID"].ToString());
                student.StaffCode = rows["StaffCode"].ToString();
                student.Password = rows["Password"].ToString();
                student.Name = rows["Name"].ToString();
                student.Phone = rows["Phone"].ToString();
                student.StaffType = rows["StaffType"].ToString();
                student.TypeName = rows["TypeName"].ToString();
                student.JobNumber = rows["JobNumber"].ToString();
                list.Add(student);
            }
            return list;
        }


        /// <summary>
        /// 修改职员
        /// </summary>
        /// <returns></returns>
        public static ReturnData UpdateStaff(ReviseStaffRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Staff WHERE StaffCode='{0}'", request.StaffCode);
                string sqlJobNumber = string.Format("SELECT * FROM dbo.Staff WHERE JobNumber='{0}'", request.JobNumber);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "登录账号重复！";
                    returnData.IsSuccess = false;
                }
                else if (int.Parse(DBHelper.GetDataTable(sqlJobNumber).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "职工工号重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("UPDATE    dbo.Staff	SET	StaffCode='{0}',Password='{1}',Name='{2}',Phone='{3}',StaffType=(SELECT Code FROM dbo.StaffType WHERE TypeName='{4}'),JobNumber='{5}' WHERE Staff.ID='{6}'",
                            request.StaffCode, request.Password, request.Name, request.Phone, request.TypeName, request.JobNumber, request.ID);

                    if (DBHelper.ExecuteNonQuery(sqlInsert))
                    {
                        returnData.Info = "修改成功";
                        returnData.IsSuccess = true;
                    }
                }
                return returnData;

            }
            catch (Exception)
            {

                returnData.Info = "修改失败，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }

        }
        /// <summary>
        /// 新增职员
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddStaff(ReviseStaffRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Staff WHERE StaffCode='{0}'", request.StaffCode);
                string sqlJobNumber = string.Format("SELECT * FROM dbo.Staff WHERE JobNumber='{0}'", request.JobNumber);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "登录账号重复！";
                    returnData.IsSuccess = false;
                }
                else if (int.Parse(DBHelper.GetDataTable(sqlJobNumber).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "职工工号重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("INSERT dbo.Staff(StaffCode,Password,Name,Phone,StaffType,JobNumber) VALUES('{0}','{1}','{2}','{3}',(SELECT Code FROM dbo.StaffType WHERE TypeName='{4}'),'{5}')",
                            request.StaffCode, request.Password, request.Name, request.Phone, request.TypeName, request.JobNumber);

                    if (DBHelper.ExecuteNonQuery(sqlInsert))
                    {
                        returnData.Info = "添加成功";
                        returnData.IsSuccess = true;
                    }
                }
                return returnData;

            }
            catch (Exception)
            {

                returnData.Info = "添加失败，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }

        }
        /// <summary>
        /// 删除职员
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelStaff(string ID)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("DELETE dbo.Staff WHERE ID='{0}'", ID);
                if (DBHelper.ExecuteNonQuery(sql))
                {
                    returnData.Info = "删除成功";
                    returnData.IsSuccess = true;
                }
                else
                {
                    returnData.Info = "删除失败";
                    returnData.IsSuccess = false;
                }
                return returnData;
            }
            catch (Exception)
            {

                returnData.Info = "删除异常，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }
    }
}
