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
    public class BookManagementDAL
    {
        /// <summary>
        /// 分页查询图书
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<BookModel> GetBooks(BookRequest request, out int totalPage)
        {

            try
            {
                string sql = "Books_SelectPoage";
                SqlParameter[] paras =
                {
                    new SqlParameter("@pageIndex",request.PageNum),
                    new SqlParameter("@pageNum",request.PageSize),
                    new SqlParameter("@title",request.Title),
                    new SqlParameter("@bookType",request.BookType),
                    new SqlParameter("@bookCode",request.BookCode),
                    new SqlParameter()
                };
                //除了字符串类型 其它参数 设置参数类型 Size
                paras[0].SqlDbType = SqlDbType.Int;
                paras[1].SqlDbType = SqlDbType.Int;
                paras[2].SqlDbType = SqlDbType.VarChar;
                paras[3].SqlDbType = SqlDbType.VarChar;
                paras[4].SqlDbType = SqlDbType.VarChar;
                //设置输出参数
                paras[5].Direction = ParameterDirection.Output;
                paras[5].ParameterName = "totalPage";
                paras[5].SqlDbType = SqlDbType.Int;

                DataTable dt = DBHelper.GetDataTableByProcedure(sql, paras);

                List<BookModel> list = new List<BookModel>();
                foreach (DataRow rows in dt.Rows)
                {
                    BookModel student = new BookModel();
                    student.ID = int.Parse(rows["ID"].ToString());
                    student.Title = rows["Title"].ToString();
                    student.Author = rows["Author"].ToString();
                    student.ISBN = rows["ISBN"].ToString();
                    student.PublishingHouse = rows["PublishingHouse"].ToString();
                    student.PublicationDate = rows["PublicationDate"].ToString();
                    student.BookType = rows["Name"].ToString();
                    student.BookCode = rows["BookCode"].ToString();
                    student.NumBorrowed = rows["NumBorrowed"].ToString();
                    student.Picture = rows["Picture"].ToString();
                    student.IsBorrow = rows["IsBorrow"].ToString();
                    student.IsBooking = rows["IsBooking"].ToString();
                    list.Add(student);
                }
                totalPage = Convert.ToInt32(paras[5].Value);
                return list;
            }
            catch (Exception)
            {
                totalPage = 0;
                return null;
            }
        }

        /// <summary>
        /// 修改图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData UpdateBook(ReviseBookRequest request)
        {

            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Books WHERE BookCode='{0}'", request.BookCode);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "图书代码重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("UPDATE dbo.Books SET Title='{0}',Author='{1}',ISBN='{2}',PublishingHouse='{3}',PublicationDate='{4}', BookType = (SELECT Code FROM dbo.BookType WHERE Name = '{5}'), BookCode = '{6}', Picture = '{7}' WHERE Books.ID = '{8}' ",
                            request.Title, request.Author, request.ISBN, request.PublishingHouse, request.PublicationDate, request.BookType, request.BookCode, request.Picture, request.ID);

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
        /// 添加图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddBook(ReviseBookRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.Books WHERE BookCode='{0}'", request.BookCode);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "图书代码重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert;
                    if (!string.IsNullOrEmpty(request.Picture))
                    {
                        sqlInsert = string.Format("INSERT dbo.Books(Title,Author,ISBN,PublishingHouse,PublicationDate,BookType,BookCode,Picture) VALUES('{0}','{1}','{2}','{3}','{4}',(SELECT Code FROM dbo.BookType WHERE Name='{5}'),'{6}','{7}')",
                           request.Title, request.Author, request.ISBN, request.PublishingHouse, request.PublicationDate, request.BookType, request.BookCode, request.Picture);
                    }
                    else
                    {
                        sqlInsert = string.Format("INSERT dbo.Books(Title,Author,ISBN,PublishingHouse,PublicationDate,BookType,BookCode) VALUES('{0}','{1}','{2}','{3}','{4}',(SELECT Code FROM dbo.BookType WHERE Name='{5}'),'{6}')",
                           request.Title, request.Author, request.ISBN, request.PublishingHouse, request.PublicationDate, request.BookType, request.BookCode);
                    }


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
        /// 删除图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelBook(string ID)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("DELETE dbo.Books WHERE ID='{0}'", ID);
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
        /// 查询图书类型列表
        /// </summary>
        /// <returns></returns>
        public static List<BookType> GetBookType(BookTypeRequest request)
        {
            try
            {
                string sql = null;
                if (request == null)
                {
                    sql = "SELECT * FROM dbo.BookType";
                }
                else
                {
                    if (string.IsNullOrEmpty(request.Code) && string.IsNullOrEmpty(request.Name))
                    {
                        sql = "SELECT * FROM dbo.BookType";
                    }
                    else if (!string.IsNullOrEmpty(request.Code) && !string.IsNullOrEmpty(request.Name))
                    {
                        sql = string.Format("SELECT * FROM dbo.BookType WHERE Code='{0}' AND Name LIKE '%{1}%'", request.Code, request.Name);
                    }
                    else if (!string.IsNullOrEmpty(request.Code) && string.IsNullOrEmpty(request.Name))
                    {
                        sql = string.Format("SELECT * FROM dbo.BookType WHERE Code='{0}'", request.Code);
                    }
                    else if (string.IsNullOrEmpty(request.Code) && !string.IsNullOrEmpty(request.Name))
                    {
                        sql = string.Format("SELECT * FROM dbo.BookType WHERE  Name LIKE '%{0}%'", request.Name);
                    }
                }
                DataTable dt = DBHelper.GetDataTable(sql);
                List<BookType> list = new List<BookType>();

                foreach (DataRow rows in dt.Rows)
                {
                    BookType staffType = new BookType();
                    staffType.ID = int.Parse(rows["ID"].ToString());
                    staffType.Code = rows["Code"].ToString();
                    staffType.Name = rows["Name"].ToString();
                    list.Add(staffType);
                }
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }
        /// <summary>
        /// 添加图书分类
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddBookType(BookTypeRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.BookType WHERE Code='{0}'", request.Code);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "分类代码重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("INSERT dbo.BookType(Code,Name) VALUES('{0}','{1}')", request.Code, request.Name);

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
        /// 修改图书分类
        /// </summary>
        /// <returns></returns>
        public static ReturnData UpdateBookType(BookTypeRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlStaffCode = string.Format("SELECT * FROM dbo.BookType WHERE Code='{0}'", request.Code);

                if (int.Parse(DBHelper.GetDataTable(sqlStaffCode).Rows.Count.ToString()) > 1)
                {
                    returnData.Info = "分类代码重复！";
                    returnData.IsSuccess = false;
                }
                else
                {
                    returnData.IsSuccess = true;
                }

                if (returnData.IsSuccess)
                {
                    string sqlInsert = string.Format("UPDATE dbo.BookType SET Name='{0}' WHERE ID='{1}'", request.Name, request.ID);

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
        /// 删除图书分类
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelBookType(string ID)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sqlInsert = string.Format("  DELETE dbo.BookType WHERE ID='{0}'", ID);
                if (DBHelper.ExecuteNonQuery(sqlInsert))
                {
                    returnData.Info = "删除成功";
                    returnData.IsSuccess = true;
                }

                return returnData;

            }
            catch (Exception)
            {

                returnData.Info = "删除失败，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }
        /// <summary>
        /// 查询图书借阅详情
        /// </summary>
        /// <returns></returns>
        public static BookLending BookBorrowingDetails(string ID)
        {
            string sql = string.Format("SELECT dbo.Books.ID,Books.Title,Author,Books.ISBN,PublishingHouse,PublicationDate," +
                "BookType=(SELECT Name FROM dbo.BookType WHERE Code=BookType),Books.BookCode,NumBorrowed,Picture,IsBorrow,IsBooking," +
                "LendInfo.ReaderID LoanStudentCode,ReaderName,BegintTime,EndTime,BookingInfo.ReaderID AS BookingStudentCode,BookingPeople,BookingDate,BookingEndDate FROM dbo.Books LEFT " +
                "JOIN dbo.LendInfo ON Books.BookCode=dbo.LendInfo.BookCode LEFT JOIN dbo.BookingInfo ON Books.BookCode=BookingInfo.BookCode " +
                "WHERE dbo.Books.ID='{0}'", ID);
            DataTable dt = DBHelper.GetDataTable(sql);
            BookLending bookLending = new BookLending();
            foreach (DataRow rows in dt.Rows)
            {
                bookLending.ID = int.Parse(rows["ID"].ToString());
                bookLending.Title = rows["Title"].ToString();
                bookLending.Author = rows["Author"].ToString();
                bookLending.ISBN = rows["ISBN"].ToString();
                bookLending.PublishingHouse = rows["PublishingHouse"].ToString();
                bookLending.PublicationDate = rows["PublicationDate"].ToString();
                bookLending.BookType = rows["BookType"].ToString();
                bookLending.BookCode = rows["BookCode"].ToString();
                bookLending.NumBorrowed = rows["NumBorrowed"].ToString();
                bookLending.Picture = rows["Picture"].ToString();
                bookLending.IsBorrow = rows["IsBorrow"].ToString();
                bookLending.IsBooking = rows["IsBooking"].ToString();
                bookLending.LoanStudentCode = rows["LoanStudentCode"].ToString();
                bookLending.LoanStudent = rows["ReaderName"].ToString();
                bookLending.ReturnDate = rows["EndTime"].ToString();
                bookLending.BookingStudentCode = rows["BookingStudentCode"].ToString();
                bookLending.BookingStudent = rows["BookingPeople"].ToString();
                bookLending.BookingDate = rows["BookingDate"].ToString();
                bookLending.BookingEndDate = rows["BookingEndDate"].ToString();
            }
            return bookLending;
        }



        /// <summary>
        /// 借书
        /// </summary>
        /// <returns></returns>
        public static ReturnData BorrowBooks(StudentBookBorrowingRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                //string sql = string.Format("INSERT dbo.LendInfo(ReaderID,ReaderName,Title,BookCode,ISBN,BegintTime,EndTime)	VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                //                            request.ReaderID, request.ReaderName, request.Title, request.BookCode, request.ISBN, request.BegintTime, request.EndTime);
                //if (DBHelper.ExecuteNonQuery(sql))
                //{
                //    string sqlStr = string.Format("UPDATE dbo.Books SET NumBorrowed=NumBorrowed+1 ,IsBorrow=1 WHERE ID='{0}' AND BookCode='{1}'", request.BookID, request.BookCode);

                //    if (DBHelper.ExecuteNonQuery(sqlStr))
                //    {
                //        returnData.Info = "借阅成功";
                //        returnData.IsSuccess = true;
                //    }
                //    if (request.IsMyself)//如果借阅用户是预约用户，则清除预约信息
                //    {
                //        string sqlStrBooking = string.Format("UPDATE dbo.Books SET IsBooking=0 WHERE ID='{0}' AND BookCode='{1}'", request.BookID, request.BookCode);
                //        string sqlDelBookingInfo = string.Format("DELETE dbo.BookingInfo WHERE ReaderID='{0}' AND BookCode='{1}'", request.ReaderID, request.BookCode);
                //        string sqlUpdateStudent = string.Format("  UPDATE dbo.Student SET NumberBooksBorrowed=NumberBooksBorrowed+1 WHERE StudentCode='{0}' AND StudentName='{1}'",
                //                                                request.ReaderID, request.ReaderName);
                //        DBHelper.ExecuteNonQuery(sqlStrBooking);
                //        DBHelper.ExecuteNonQuery(sqlDelBookingInfo);
                //        DBHelper.ExecuteNonQuery(sqlUpdateStudent);
                //    }
                //}
                //else
                //{
                //    returnData.Info = "借阅失败";
                //    returnData.IsSuccess = false;
                //}
                string sqlQuery = string.Format("  SELECT OverdueReturnNum FROM dbo.Student WHERE StudentCode='{0}' AND StudentName='{1}'", request.ReaderID, request.ReaderName);
                DataTable dt = DBHelper.GetDataTable(sqlQuery);
                int OverdueReturnNum = 0;
                foreach (DataRow rows in dt.Rows)
                {
                    OverdueReturnNum = int.Parse(rows["OverdueReturnNum"].ToString());
                }

                if (OverdueReturnNum < 3)
                {
                    string sql = string.Format("INSERT dbo.LendInfo(ReaderID,ReaderName,Title,BookCode,ISBN,BegintTime,EndTime)	VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                                          request.ReaderID, request.ReaderName, request.Title, request.BookCode, request.ISBN, request.BegintTime, request.EndTime);
                    string sqlStr = string.Format("UPDATE dbo.Books SET NumBorrowed=NumBorrowed+1 ,IsBorrow=1 WHERE ID='{0}' AND BookCode='{1}'", request.BookID, request.BookCode);
                    List<string> list = new List<string> { sql, sqlStr };

                    if (request.IsMyself)//如果借阅用户是预约用户，则添加清除预约信息Sql
                    {
                        string sqlStrBooking = string.Format("UPDATE dbo.Books SET IsBooking=0 WHERE ID='{0}' AND BookCode='{1}'", request.BookID, request.BookCode);
                        string sqlDelBookingInfo = string.Format("DELETE dbo.BookingInfo WHERE ReaderID='{0}' AND BookCode='{1}'", request.ReaderID, request.BookCode);
                        string sqlUpdateStudent = string.Format("  UPDATE dbo.Student SET NumberBooksBorrowed=NumberBooksBorrowed+1 WHERE StudentCode='{0}' AND StudentName='{1}'",
                                                                request.ReaderID, request.ReaderName);
                        list.Add(sqlStrBooking);
                        list.Add(sqlDelBookingInfo);
                        list.Add(sqlUpdateStudent);
                    }

                    if (DBHelper.ExecuteSqlTran(list) != 0)
                    {
                        returnData.Info = "借阅成功";
                        returnData.IsSuccess = true;
                    }
                    else
                    {
                        returnData.Info = "借阅失败";
                        returnData.IsSuccess = false;
                    }
                }
                else
                {
                    returnData.Info = $"借阅失败,逾期归还次数已达到{OverdueReturnNum}次，请联系管理员恢复借阅功能！";
                    returnData.IsSuccess = false;
                }


                return returnData;
            }
            catch (Exception)
            {

                returnData.Info = "借阅异常，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }

        /// <summary>
        /// 预约图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData BookingBook(StudentBookLendInfoRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                //string sql = string.Format("INSERT dbo.BookingInfo(ReaderID,Title,BookCode,BookingDate,BookingPeople,BookingEndDate) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                //                            request.ReaderID, request.Title, request.BookCode, request.BookingDate, request.BookingPeople, request.BookingEndDate);
                //if (DBHelper.ExecuteNonQuery(sql))
                //{
                //    string sqlStr = string.Format("UPDATE dbo.Books SET IsBooking=1 WHERE ID='{0}' AND BookCode='{1}'", request.BookID, request.BookCode);

                //    if (DBHelper.ExecuteNonQuery(sqlStr))
                //    {
                //        returnData.Info = "预约成功";
                //        returnData.IsSuccess = true;
                //    }

                //}
                //else
                //{
                //    returnData.Info = "预约失败";
                //    returnData.IsSuccess = false;
                //}

                string sqlQuery = string.Format("  SELECT OverdueReturnNum FROM dbo.Student WHERE StudentCode='{0}' AND StudentName='{1}'", request.ReaderID, request.BookingPeople);
                DataTable dt = DBHelper.GetDataTable(sqlQuery);
                int OverdueReturnNum = 0;
                foreach (DataRow rows in dt.Rows)
                {
                    OverdueReturnNum = int.Parse(rows["OverdueReturnNum"].ToString());
                }

                if (OverdueReturnNum < 2)
                {
                    string sql = string.Format("INSERT dbo.BookingInfo(ReaderID,Title,BookCode,BookingDate,BookingPeople,BookingEndDate) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                                request.ReaderID, request.Title, request.BookCode, request.BookingDate, request.BookingPeople, request.BookingEndDate);
                    string sqlStr = string.Format("UPDATE dbo.Books SET IsBooking=1 WHERE ID='{0}' AND BookCode='{1}'", request.BookID, request.BookCode);
                    List<string> list = new List<string> { sql, sqlStr };
                    if (DBHelper.ExecuteSqlTran(list) != 0)
                    {
                        returnData.Info = "预约成功";
                        returnData.IsSuccess = true;
                    }
                    else
                    {
                        returnData.Info = "预约失败";
                        returnData.IsSuccess = false;
                    }
                }
                else
                {
                    returnData.Info = $"预约失败,逾期归还次数已达到{OverdueReturnNum}次，请联系管理员恢复预约功能！";
                    returnData.IsSuccess = false;
                }



                return returnData;
            }
            catch (Exception)
            {

                returnData.Info = "预约异常，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }


        /// <summary>
        /// 用户借书列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<UserLendInfo> GetUserBorrowBooksList(UserLendInfoRequest request)
        {
            try
            {
                string sql = "User_LendInfoList";
                SqlParameter[] paras =
                {   new SqlParameter("@name",request.Name),
                    new SqlParameter("@readerID",request.ReaderID),
                    new SqlParameter("@title",request.Title),
                    new SqlParameter("@bookCode",request.BookCode)
                };
                //除了字符串类型 其它参数 设置参数类型 Size
                paras[0].SqlDbType = SqlDbType.VarChar;
                paras[1].SqlDbType = SqlDbType.VarChar;
                paras[2].SqlDbType = SqlDbType.VarChar;
                paras[3].SqlDbType = SqlDbType.VarChar;


                DataTable dt = DBHelper.GetDataTableByProcedure(sql, paras);

                List<UserLendInfo> list = new List<UserLendInfo>();
                foreach (DataRow rows in dt.Rows)
                {
                    UserLendInfo userLendInfo = new UserLendInfo();
                    userLendInfo.ID = int.Parse(rows["ID"].ToString());
                    userLendInfo.Title = rows["Title"].ToString();
                    userLendInfo.BookCode = rows["BookCode"].ToString();
                    userLendInfo.ISBN = rows["ISBN"].ToString();
                    userLendInfo.BorrowingBookDate = rows["BegintTime"].ToString();
                    userLendInfo.ReturnBookDate = rows["EndTime"].ToString();
                    userLendInfo.IsOverdue = rows["IsOverdue"].ToString();
                    list.Add(userLendInfo);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// 修改借阅图书是否逾期操作
        /// </summary>
        /// <returns></returns>
        public static ReturnData OverdueAmendment(UserLendInfoRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("UPDATE dbo.LendInfo SET IsOverdue=1 WHERE Title='{0}'AND BookCode='{1}' AND ReaderID='{2}' AND ReaderName='{3}'",
                                            request.Title, request.BookCode, request.ReaderID, request.Name);
                if (DBHelper.ExecuteNonQuery(sql))
                {
                    returnData.Info = "逾期修改操作成功";
                    returnData.IsSuccess = true;
                }
                else
                {
                    returnData.Info = "逾期修改操作失败";
                    returnData.IsSuccess = false;
                }
                return returnData;
            }
            catch (Exception)
            {

                returnData.Info = "逾期修改操作异常，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }
        /// <summary>
        /// 归还图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData ReturnBooks(UserReturnBooksRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                //string sql = string.Format("DELETE dbo.LendInfo WHERE ID='{0}' AND BookCode='{1}'", request.ID, request.BookCode);
                //if (DBHelper.ExecuteNonQuery(sql))
                //{
                //    string sqlUpdate = string.Format("UPDATE dbo.Books SET IsBorrow=0 WHERE Title='{0}' AND BookCode='{1}'", request.Title, request.BookCode);
                //    if (DBHelper.ExecuteNonQuery(sqlUpdate))
                //    {
                //        string sqlInsert = string.Format("INSERT dbo.HistoryLendInfo( ReaderID, ReaderName, Title,BookCode, ISBN,BegintTime,EndTime,ActualTime, IsOverdue, Remark)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                //                                        request.ReaderID, request.ReaderName, request.Title, request.BookCode, request.ISBN, request.BegintTime, request.EndTime, request.ActualTime, request.IsOverdue, request.Remark);
                //        if (DBHelper.ExecuteNonQuery(sqlInsert))
                //        {
                //            returnData.Info = "还书成功";
                //            returnData.IsSuccess = true;
                //        }
                //    }
                //}
                //else
                //{
                //    returnData.Info = "还书失败";
                //    returnData.IsSuccess = false;
                //}

                string sql = string.Format("DELETE dbo.LendInfo WHERE ID='{0}' AND BookCode='{1}'", request.ID, request.BookCode);
                string sqlUpdate = string.Format("UPDATE dbo.Books SET IsBorrow=0 WHERE Title='{0}' AND BookCode='{1}'", request.Title, request.BookCode);
                string sqlInsert = string.Format("INSERT dbo.HistoryLendInfo( ReaderID, ReaderName, Title,BookCode, ISBN,BegintTime,EndTime,ActualTime, IsOverdue, Remark)VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                   request.ReaderID, request.ReaderName, request.Title, request.BookCode, request.ISBN, request.BegintTime, request.EndTime, request.ActualTime, request.IsOverdue, request.Remark);
                string sqlStudentUpdate = string.Format(" UPDATE dbo.Student SET OverdueReturnNum=OverdueReturnNum+1 WHERE StudentCode='{0}'", request.ReaderID);
                List<string> list = new List<string> { sql, sqlUpdate, sqlInsert };
                if (request.IsOverdue == "1")
                {
                    list.Add(sqlStudentUpdate);
                }
                if (DBHelper.ExecuteSqlTran(list) != 0)
                {
                    returnData.Info = "还书成功";
                    returnData.IsSuccess = true;
                }
                else
                {
                    returnData.Info = "还书失败";
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
        /// 用户个人预约列表
        /// </summary>
        /// <returns></returns>
        public static List<UserAppointmentManagement> GetBookBookingList(UserBookingInfoRequest request)
        {
            try
            {
                string sql = null;
                if (string.IsNullOrEmpty(request.Title) && string.IsNullOrEmpty(request.BookCode))
                {
                    sql = string.Format("SELECT * FROM dbo.BookingInfo WHERE ReaderID='{0}' AND BookingPeople='{1}'", request.ReaderID, request.BookingPeople);
                }
                else if (!string.IsNullOrEmpty(request.Title) && string.IsNullOrEmpty(request.BookCode))
                {
                    sql = string.Format("SELECT * FROM dbo.BookingInfo WHERE ReaderID='{0}' AND BookingPeople='{1}' AND Title LIKE  '%'+'{2}'+'%'",
                                        request.ReaderID, request.BookingPeople, request.Title);
                }
                else if (string.IsNullOrEmpty(request.Title) && !string.IsNullOrEmpty(request.BookCode))
                {
                    sql = string.Format("SELECT * FROM dbo.BookingInfo WHERE ReaderID='{0}' AND BookingPeople='{1}' AND BookCode='{2}'",
                                        request.ReaderID, request.BookingPeople, request.BookCode);
                }
                else if (!string.IsNullOrEmpty(request.Title) && !string.IsNullOrEmpty(request.BookCode))
                {
                    sql = string.Format("SELECT * FROM dbo.BookingInfo WHERE ReaderID='{0}' AND BookingPeople='{1}' AND Title LIKE  '%'+'{2}'+'%' AND BookCode='{3}'",
                                        request.ReaderID, request.BookingPeople, request.Title, request.BookCode);
                }

                DataTable dt = DBHelper.GetDataTable(sql);
                List<UserAppointmentManagement> list = new List<UserAppointmentManagement>();

                foreach (DataRow rows in dt.Rows)
                {
                    UserAppointmentManagement management = new UserAppointmentManagement();
                    management.ID = int.Parse(rows["ID"].ToString());
                    management.Title = rows["Title"].ToString();
                    management.BookCode = rows["BookCode"].ToString();
                    management.BookingDate = rows["BookingDate"].ToString();
                    management.BookingEndDate = rows["BookingEndDate"].ToString();
                    list.Add(management);
                }
                return list;
            }
            catch (Exception)
            {

                return null;
            }
        }

        /// <summary>
        /// 取消预约图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData CancelBookingBooks(UserBookingInfoRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("DELETE dbo.BookingInfo WHERE ReaderID='{0}' AND Title='{1}' AND BookCode='{2}'",
                                            request.ReaderID, request.Title, request.BookCode);
                string sqlUpdate = string.Format("UPDATE dbo.Books SET IsBooking=0 WHERE Title='{0}' AND BookCode='{1}'", request.Title, request.BookCode);
                List<string> list = new List<string> { sql, sqlUpdate };

                if (DBHelper.ExecuteSqlTran(list) != 0)
                {
                    returnData.Info = "取消成功";
                    returnData.IsSuccess = true;
                }
                else
                {
                    returnData.Info = "取消失败";
                    returnData.IsSuccess = false;
                }
                //if (DBHelper.ExecuteNonQuery(sql))
                //{
                //    string sqlUpdate = string.Format("UPDATE dbo.Books SET IsBooking=0 WHERE Title='{0}' AND BookCode='{1}'", request.Title, request.BookCode);
                //    if (DBHelper.ExecuteNonQuery(sqlUpdate))
                //    {
                //        returnData.Info = "取消成功";
                //        returnData.IsSuccess = true;
                //    }
                //}
                //else
                //{
                //    returnData.Info = "取消失败";
                //    returnData.IsSuccess = false;
                //}
                return returnData;
            }
            catch (Exception)
            {

                returnData.Info = "取消异常，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }
        /// <summary>
        /// 查询借阅历史列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<HistoryLendInfoModel> GetHistoryLendInfoList(HistoryLendInfoRequest request, out int totalPage)
        {
            try
            {
                string sql = "HistoryLendInfo_SelectPoage";
                SqlParameter[] paras =
                {   new SqlParameter("@pageIndex",request.PageNum),
                    new SqlParameter("@pageNum",request.PageSize),
                    new SqlParameter("@name",request.StudentName),
                    new SqlParameter("@title",request.Title),
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

                List<HistoryLendInfoModel> list = new List<HistoryLendInfoModel>();
                foreach (DataRow rows in dt.Rows)
                {
                    HistoryLendInfoModel userLendInfo = new HistoryLendInfoModel();
                    userLendInfo.ID = int.Parse(rows["ID"].ToString());
                    userLendInfo.ReaderID = rows["ReaderID"].ToString();
                    userLendInfo.ReaderName = rows["ReaderName"].ToString();
                    userLendInfo.Title = rows["Title"].ToString();
                    userLendInfo.BookCode = rows["BookCode"].ToString();
                    userLendInfo.ISBN = rows["ISBN"].ToString();
                    userLendInfo.BegintTime = rows["BegintTime"].ToString();
                    userLendInfo.EndTime = rows["EndTime"].ToString();
                    userLendInfo.ActualTime = rows["ActualTime"].ToString();
                    userLendInfo.IsOverdue = rows["IsOverdue"].ToString();
                    userLendInfo.Remark = rows["Remark"].ToString();
                    list.Add(userLendInfo);
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
        /// 删除借书历史记录
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelHistoryLendInfo(string ID)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("DELETE dbo.HistoryLendInfo  WHERE ID='{0}'", ID);
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
        /// 查询当前预约信息列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<BookingInfoModel> GetBookingInfoList(BookingInfoRequest request, out int totalPage)
        {
            try
            {
                string sql = "BookingInfo_SelectPoage";
                SqlParameter[] paras =
                {   new SqlParameter("@pageIndex",request.PageNum),
                    new SqlParameter("@pageNum",request.PageSize),
                    new SqlParameter("@name",request.StudentName),
                    new SqlParameter("@title",request.Title),
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

                List<BookingInfoModel> list = new List<BookingInfoModel>();
                foreach (DataRow rows in dt.Rows)
                {
                    BookingInfoModel userLendInfo = new BookingInfoModel();
                    userLendInfo.ID = int.Parse(rows["ID"].ToString());
                    userLendInfo.ReaderID = rows["ReaderID"].ToString();
                    userLendInfo.BookingPeople = rows["BookingPeople"].ToString();
                    userLendInfo.Title = rows["Title"].ToString();
                    userLendInfo.BookCode = rows["BookCode"].ToString();
                    userLendInfo.BookingDate = rows["BookingDate"].ToString();
                    userLendInfo.BookingEndDate = rows["BookingEndDate"].ToString();

                    list.Add(userLendInfo);
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
        /// 删除学生的图书预约记录
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelBookingInfo(DelBookingInfoRequest request)
        {
            ReturnData returnData = new ReturnData();
            try
            {
                string sql = string.Format("DELETE dbo.BookingInfo WHERE ID='{0}'", request.ID);
                string sqlUpdate = string.Format("UPDATE dbo.Books SET IsBooking=0 WHERE Title='{0}' AND BookCode='{1}'", request.Title, request.BookCode);
                List<string> list = new List<string> { sql, sqlUpdate };
                if (DBHelper.ExecuteSqlTran(list) != 0)
                {
                    returnData.Info = "删除预约信息成功";
                    returnData.IsSuccess = true;
                }
                else
                {
                    returnData.Info = "删除预约信息失败";
                    returnData.IsSuccess = false;
                }
                return returnData;
            }
            catch (Exception)
            {

                returnData.Info = "删除预约信息异常，请联系管理员！";
                returnData.IsSuccess = false;
                return returnData;
            }
        }


        /// <summary>
        /// 管理员查询用户借阅列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<LendInfoModel> GetLendInfoList(LendInfoRequest request, out int totalPage)
        {
            try
            {
                string sql = "LendInfo_SelectPoage";
                SqlParameter[] paras =
                {
                    new SqlParameter("@pageIndex",request.PageNum),
                    new SqlParameter("@pageNum",request.PageSize),
                    new SqlParameter("@title",request.Title),
                    new SqlParameter("@name",request.StudentName),
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

                List<LendInfoModel> list = new List<LendInfoModel>();
                foreach (DataRow rows in dt.Rows)
                {
                    LendInfoModel student = new LendInfoModel();
                    student.ID = int.Parse(rows["ID"].ToString());
                    student.ReaderID = rows["ReaderID"].ToString();
                    student.ReaderName = rows["ReaderName"].ToString();
                    student.Title = rows["Title"].ToString();
                    student.BookCode = rows["BookCode"].ToString();
                    student.ISBN = rows["ISBN"].ToString();
                    student.BegintTime = rows["BegintTime"].ToString();
                    student.EndTime = rows["EndTime"].ToString();
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

    }
}
