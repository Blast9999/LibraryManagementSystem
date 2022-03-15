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
    public class StudentManagementDAL
    {
        /// <summary>
        /// 分页查询学生
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<StudentModel> GetStudent(StudentRequest request, out int totalPage)
        {
            try
            {
                string sql = "Student_SelectPoage";
                SqlParameter[] paras =
               {
                new SqlParameter("@pageIndex",request.PageNum),
                new SqlParameter("@pageNum",request.PageSize),
                new SqlParameter("@name",request.Name),
                new SqlParameter("@studentCode",request.StudentCode),
                new SqlParameter()
            };
                //除了字符串类型 其它参数 设置参数类型 Size
                paras[0].SqlDbType = SqlDbType.Int;
                paras[1].SqlDbType = SqlDbType.Int;
                paras[2].SqlDbType = SqlDbType.VarChar;
                paras[3].SqlDbType = SqlDbType.VarChar;
                //设置输出参数
                paras[4].Direction = ParameterDirection.Output;
                paras[4].ParameterName = "totalPage";
                paras[4].SqlDbType = SqlDbType.Int;

                DataTable dt = DBHelper.GetDataTableByProcedure(sql, paras);

                List<StudentModel> list = new List<StudentModel>();
                foreach (DataRow rows in dt.Rows)
                {
                    StudentModel student = new StudentModel();
                    student.ID = int.Parse(rows["ID"].ToString());
                    student.StudentCode = rows["StudentCode"].ToString();
                    student.Password = rows["Password"].ToString();
                    student.StudentName = rows["StudentName"].ToString();
                    student.Phone = rows["Phone"].ToString();
                    student.Sex = rows["Sex"].ToString();
                    student.Mail = rows["Mail"].ToString();
                    student.ViolationStatus = rows["ViolationStatus"].ToString();
                    student.NumberBooksBorrowed = rows["NumberBooksBorrowed"].ToString();
                    student.OverdueReturnNum = rows["OverdueReturnNum"].ToString();
                    student.IsOverdue = rows["IsOverdue"].ToString();
                    student.Remark = rows["Remark"].ToString();
                    list.Add(student);
                }
                totalPage = Convert.ToInt32(paras[4].Value);
                return list;
            }
            catch (Exception)
            {
                totalPage = 0;
                return null;
            }
        }

        /// <summary>
        /// 修改学生
        /// </summary>
        /// <param name="request"></param>
        /// <param name="Type">0—管理员修改学生，1—学生自己修改</param>
        /// <returns></returns>
        public static ReturnData UpdateStudent(ReviseStudentRequest request, string Type)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Student WHERE StudentCode='{0}'", request.StudentCode);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "学号重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = null;
                    if (Type == "0")
                    {
                        sqlInsert = string.Format("UPDATE dbo.Student SET StudentCode='{0}',Password='{1}',StudentName='{2}',Phone='{3}',Sex='{4}',Mail='{5}',ViolationStatus='{6}',NumberBooksBorrowed='{7}',OverdueReturnNum='{8}',Remark='{9}'WHERE ID='{10}'",
                          request.StudentCode, request.Password, request.StudentName, request.Phone, request.Sex, request.Mail, request.ViolationStatus, request.NumberBooksBorrowed, request.OverdueReturnNum, request.Remark, request.ID);

                    }
                    else if (Type == "1")
                    {
                        sqlInsert = string.Format("UPDATE dbo.Student SET Phone='{0}' ,Sex='{1}',Mail='{2}',Password='{3}' WHERE ID='{4}'",
                                                request.Phone, request.Sex, request.Mail, request.Password, request.ID);
                    }

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
        /// 新增学生
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddStudent(ReviseStudentRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Student WHERE StudentCode='{0}'", request.StudentCode);
                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "学号重复！";
                    returnData.IsSuccess = false;
                }

                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("INSERT dbo.Student(StudentCode, Password,StudentName, Phone,Sex, Mail) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                            request.StudentCode, request.Password, request.StudentName, request.Phone, request.Sex, request.Mail);

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
        /// 删除学生
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelStaff(string ID)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("DELETE dbo.Student WHERE ID='{0}'", ID);
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

        /// <summary>
        /// 查询学生个人信息
        /// </summary>
        /// <param name="Code">学号</param>
        /// <param name="Name">姓名</param>
        /// <returns></returns>
        public static StudentModel GetStudentPersonalInformation(string Code, string Name)
        {
            try
            {
                string sql = string.Format("  SELECT * FROM dbo.Student WHERE StudentCode='{0}' AND StudentName='{1}'", Code, Name);
                DataTable dt = DBHelper.GetDataTable(sql);
                StudentModel student = new StudentModel();
                foreach (DataRow rows in dt.Rows)
                {
                    student.ID = int.Parse(rows["ID"].ToString());
                    student.StudentCode = rows["StudentCode"].ToString();
                    student.Password = rows["Password"].ToString();
                    student.StudentName = rows["StudentName"].ToString();
                    student.Phone = rows["Phone"].ToString();
                    student.Sex = rows["Sex"].ToString();
                    student.Mail = rows["Mail"].ToString();
                    student.ViolationStatus = rows["ViolationStatus"].ToString();
                    student.NumberBooksBorrowed = rows["NumberBooksBorrowed"].ToString();
                    student.OverdueReturnNum = rows["OverdueReturnNum"].ToString();
                    student.IsOverdue = rows["IsOverdue"].ToString();
                    student.Remark = rows["Remark"].ToString();
                }
                return student;
            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}
