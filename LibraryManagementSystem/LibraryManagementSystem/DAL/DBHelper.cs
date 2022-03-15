using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class DBHelper
    {
        public static string con = "Data Source =.; Initial Catalog = LibraryDatabase; Integrated Security = True";

        //数据库连接对象
        public static SqlConnection conn = null;
        //初始化数据库连接
        public static void InitConnection()
        {
            //如果连接对象不存在，则创建连接
            if (conn == null)
            {
                conn = new SqlConnection(con);
            }
            //如果连接对象关闭，则打开连接
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            //如果连接中断，则重启连接
            if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }
        //查询，获取DataReader
        public static SqlDataReader GetDataReader(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            //CommandBehavior.CloseConnecetion 命令行为：当DataReader对象关闭时自动关闭占用的连接对象
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询，获取DataTable
        public static DataTable GetDataTable(string sqlStr)
        {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sqlStr, conn);
            dap.Fill(table);
            conn.Close();
            return table;
        }

        //增删改
        public static bool ExecuteNonQuery(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        //执行集合函数
        public static object ExecuteScalar(string sqlstr)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sqlstr, conn);
            object result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        /// <summary>
        /// 查询存储过程
        /// </summary>
        /// <param name="procName">存储工程名</param>
        /// <param name="paras">输入参数</param>
        /// <returns></returns>
        public static DataTable GetDataTableByProcedure(string procName, SqlParameter[] paras)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 增删改存储过程
        /// </summary>
        /// <param name="procName">存储过程名字</param>
        /// <param name="paras">参数</param>
        /// <returns></returns>
        public static bool ExecuteByProcedure(string procName, SqlParameter[] paras)
        {
            InitConnection();
            SqlCommand cmd = new SqlCommand(procName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < paras.Length; i++)
            {
                cmd.Parameters.Add(paras[i]);
            }
            return cmd.ExecuteNonQuery() > 0;
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务。
        /// </summary>
        /// <param name="SQLStringList">多条SQL语句</param>
        public static int ExecuteSqlTran(List<string> SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n];
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            count += cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    conn.Close();
                    return count;
                }
                catch (Exception err)
                {
                    tx.Rollback();

                    return 0;
                }
            }

        }
        /// <summary>
        /// 执行SQL语句后有重复数据，实现数据库事务。
        /// </summary>
        /// <param name="SqlString">执行代码</param>
        /// <param name="SqlQuery">查询代码</param>
        /// <returns></returns>
        public static int ExecuteSqlIsRepeated(string SqlString, string SqlQuery)
        {
            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    int count = 0;
                    if (string.IsNullOrEmpty(SqlString) && string.IsNullOrEmpty(SqlQuery))
                    {
                        cmd.CommandText = SqlString;
                        cmd.ExecuteNonQuery();
                        if (GetDataTable(SqlQuery).Rows.Count < 1)
                        {
                            tx.Commit();
                            count = 1;
                        }
                        else
                        {
                            tx.Rollback();
                        }
                    }
                    else
                    {
                        count=500;//数据有空值
                    }
                    conn.Close();
                    return count;
                }
                catch (Exception err)
                {
                    tx.Rollback();

                    return 0;
                }
            }

        }
    }
}