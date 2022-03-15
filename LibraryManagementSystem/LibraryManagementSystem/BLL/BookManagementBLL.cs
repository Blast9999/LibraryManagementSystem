using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookManagementBLL
    {

        /// <summary>
        /// 分页查询图书
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<BookModel> GetBooks(BookRequest request, out int totalPage)
        {
            return BookManagementDAL.GetBooks(request, out totalPage);
        }
        /// <summary>
        /// 修改图书
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static ReturnData UpdateBook(ReviseBookRequest request)
        {
            return BookManagementDAL.UpdateBook(request);
        }
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static ReturnData AddBook(ReviseBookRequest request)
        {
            return BookManagementDAL.AddBook(request);
        }
        /// <summary>
        /// 删除图书
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public static ReturnData DelBook(string ID)
        {
            return BookManagementDAL.DelBook(ID);
        }

        /// <summary>
        /// 查询员工类型下拉列表
        /// </summary>
        /// <returns></returns>
        public static List<BookType> GetBookType()
        {
            return BookManagementDAL.GetBookType(null);
        }
        /// <summary>
        /// 添加图书分类
        /// </summary>
        /// <returns></returns>
        public static ReturnData AddBookType(BookTypeRequest request)
        {
            return BookManagementDAL.AddBookType(request);
        }
        /// <summary>
        /// 修改图书分类
        /// </summary>
        /// <returns></returns>
        public static ReturnData UpdateBookType(BookTypeRequest request)
        {
            return BookManagementDAL.UpdateBookType(request);
        }
        /// <summary>
        /// 删除图书分类
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelBookType(string ID)
        {
            return BookManagementDAL.DelBookType(ID);
        }
        /// <summary>
        /// 查询员工类型详细列表
        /// </summary>
        /// <returns></returns>
        public static List<BookType> GetBookType(BookTypeRequest request)
        {
            return BookManagementDAL.GetBookType(request);
        }
        /// <summary>
        /// 查询图书借阅详情
        /// </summary>
        /// <returns></returns>
        public static BookLending BookBorrowingDetails()
        {
            return BookManagementDAL.BookBorrowingDetails(ID);
        }
        /// <summary>
        /// 借书
        /// </summary>
        /// <returns></returns>
        public static ReturnData BorrowBooks(StudentBookBorrowingRequest request)
        {
            return BookManagementDAL.BorrowBooks(request);
        }

        /// <summary>
        /// 预约图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData BookingBook(StudentBookLendInfoRequest request)
        {
            return BookManagementDAL.BookingBook(request);
        }
        /// <summary>
        /// 用户借书列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<UserLendInfo> GetUserBorrowBooksList(UserLendInfoRequest request)
        {
            var Response = BookManagementDAL.GetUserBorrowBooksList(request);
            return Response;
        }

        /// <summary>
        /// 修改借阅图书是否逾期操作
        /// </summary>
        /// <returns></returns>
        public static ReturnData OverdueAmendment(UserLendInfoRequest request)
        {
            return BookManagementDAL.OverdueAmendment(request);
        }
        /// <summary>
        /// 归还图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData ReturnBooks(UserReturnBooksRequest request)
        {
            return BookManagementDAL.ReturnBooks(request);
        }
        /// <summary>
        /// 用户个人预约列表
        /// </summary>
        /// <returns></returns>
        public static List<UserAppointmentManagement> GetBookBookingList(UserBookingInfoRequest request)
        {
            return BookManagementDAL.GetBookBookingList(request);
        }
        /// <summary>
        /// 取消预约图书
        /// </summary>
        /// <returns></returns>
        public static ReturnData CancelBookingBooks(UserBookingInfoRequest request)
        {
            return BookManagementDAL.CancelBookingBooks(request);
        }
        /// <summary>
        /// 查询借阅历史列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<HistoryLendInfoModel> GetHistoryLendInfoList(HistoryLendInfoRequest request, out int totalPage)
        {
            return BookManagementDAL.GetHistoryLendInfoList(request, out totalPage);
        }

        /// <summary>
        /// 删除借书历史记录
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelHistoryLendInfo(string ID)
        {
            return BookManagementDAL.DelHistoryLendInfo(ID);
        }
        /// <summary>
        /// 查询当前预约信息列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<BookingInfoModel> GetBookingInfoList(BookingInfoRequest request, out int totalPage)
        {
            return BookManagementDAL.GetBookingInfoList(request, out totalPage);
        }
        /// <summary>
        /// 删除学生的图书预约记录
        /// </summary>
        /// <returns></returns>
        public static ReturnData DelBookingInfo(DelBookingInfoRequest request)
        {
            return BookManagementDAL.DelBookingInfo(request);
        }
        /// <summary>
        /// 管理员查询用户借阅列表
        /// </summary>
        /// <param name="request"></param>
        /// <param name="totalPage">总页数</param>
        /// <returns></returns>
        public static List<LendInfoModel> GetLendInfoList(LendInfoRequest request, out int totalPage)
        {
            return BookManagementDAL.GetLendInfoList(request, out totalPage);
        }
        #region 页面数据


        #region 图书数据
        public static string ID;
        public static string Title;
        public static string Author;
        public static string ISBN;
        public static string PublishingHouse;
        public static string PublicationDate;
        public static string BookType;
        public static string BookCode;
        public static string NumBorrowed;
        public static string Picture;
        public static string IsBorrow;
        public static string IsBooking;
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
