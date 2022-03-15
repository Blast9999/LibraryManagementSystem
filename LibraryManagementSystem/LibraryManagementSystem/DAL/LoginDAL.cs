using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL
    {
        public static LoginUser Login(string LoginCode, string Password, string Type)
        {
            string sql;
            if (Type == "1")
            {
                sql = string.Format("select * from Student where StudentCode='{0}'and Password='{1}'", LoginCode, Password);
            }
            else
            {
                sql = string.Format("select * from Staff where StaffCode='{0}'and Password='{1}'", LoginCode, Password);
            }
            if (int.Parse(DBHelper.GetDataTable(sql).Rows.Count.ToString()) > 0)
            {
                //return DBHelper.GetDataTable(sql).Rows[0][0]?.ToString();


                DataTable dt = DBHelper.GetDataTable(sql);
                LoginUser loginUser =new LoginUser();
                if (Type == "1")
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        
                        loginUser.LoginCode = rows["StudentCode"].ToString();
                        loginUser.Password = rows["Password"].ToString();
                        loginUser.Name = rows["StudentName"].ToString();
                        loginUser.ViolationStatus = int.Parse(rows["ViolationStatus"].ToString());
                        loginUser.Remark = rows["Remark"].ToString();
                        
                    }
                }
                else
                {
                    foreach (DataRow rows in dt.Rows)
                    {
                        
                        loginUser.LoginCode = rows["StaffCode"].ToString();
                        loginUser.Password = rows["Password"].ToString();
                        loginUser.Name = rows["Name"].ToString();
                        loginUser.JobNumber = rows["JobNumber"].ToString();
                        
                    }
                }

                return loginUser;

            }
            else
            {
                return null;
            }

        }
    }
}
