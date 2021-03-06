USE [LibraryDatabase]
GO
/****** Object:  Table [dbo].[BookingInfo]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReaderID] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BookCode] [nvarchar](50) NOT NULL,
	[BookingDate] [nvarchar](100) NOT NULL,
	[BookingPeople] [nvarchar](50) NOT NULL,
	[BookingEndDate] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_BookingInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Author] [nvarchar](200) NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[PublishingHouse] [nvarchar](200) NOT NULL,
	[PublicationDate] [nvarchar](100) NOT NULL,
	[BookType] [int] NOT NULL,
	[BookCode] [nvarchar](50) NOT NULL,
	[NumBorrowed] [int] NOT NULL,
	[Picture] [nvarchar](50) NULL,
	[IsBorrow] [int] NOT NULL,
	[IsBooking] [int] NOT NULL,
 CONSTRAINT [PK_Books_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookType]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_BookType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryBookingInfo]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryBookingInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReaderID] [nvarchar](50) NOT NULL,
	[BookingPeople] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BookCode] [nvarchar](50) NOT NULL,
	[BookingDate] [nvarchar](100) NOT NULL,
	[BorrowingBookDate] [nvarchar](100) NOT NULL,
	[State] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HistoryBookingInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryLendInfo]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryLendInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReaderID] [nvarchar](50) NOT NULL,
	[ReaderName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BookCode] [nvarchar](50) NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[BegintTime] [nvarchar](100) NOT NULL,
	[EndTime] [nvarchar](100) NOT NULL,
	[ActualTime] [nvarchar](100) NOT NULL,
	[IsOverdue] [int] NOT NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_HistoryLendInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LendInfo]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LendInfo](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReaderID] [nvarchar](50) NOT NULL,
	[ReaderName] [nvarchar](50) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[BookCode] [nvarchar](50) NOT NULL,
	[ISBN] [nvarchar](50) NOT NULL,
	[BegintTime] [nvarchar](100) NOT NULL,
	[EndTime] [nvarchar](100) NULL,
	[IsOverdue] [int] NOT NULL,
	[Remark] [nvarchar](200) NULL,
 CONSTRAINT [PK_LendInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StaffCode] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[StaffType] [nvarchar](50) NOT NULL,
	[JobNumber] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StaffType]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffType](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StaffType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentCode] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Sex] [nvarchar](50) NULL,
	[Mail] [nvarchar](50) NULL,
	[ViolationStatus] [int] NOT NULL,
	[NumberBooksBorrowed] [int] NOT NULL,
	[OverdueReturnNum] [int] NOT NULL,
	[IsOverdue] [nvarchar](50) NOT NULL,
	[Remark] [nvarchar](100) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF_Books_NumBorrowed]  DEFAULT ((0)) FOR [NumBorrowed]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF_Books_IsBorrow]  DEFAULT ((0)) FOR [IsBorrow]
GO
ALTER TABLE [dbo].[Books] ADD  CONSTRAINT [DF_Books_IsBooking]  DEFAULT ((0)) FOR [IsBooking]
GO
ALTER TABLE [dbo].[HistoryLendInfo] ADD  CONSTRAINT [DF_HistoryLendInfo_IsOverdue]  DEFAULT ((0)) FOR [IsOverdue]
GO
ALTER TABLE [dbo].[LendInfo] ADD  CONSTRAINT [DF_LendInfo_IsBack]  DEFAULT ((0)) FOR [IsOverdue]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_ViolationStatus]  DEFAULT ((0)) FOR [ViolationStatus]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_NumberBooksBorrowed]  DEFAULT ((0)) FOR [NumberBooksBorrowed]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_OverdueReturnNum]  DEFAULT ((0)) FOR [OverdueReturnNum]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_IsOverdue]  DEFAULT ((0)) FOR [IsOverdue]
GO
/****** Object:  StoredProcedure [dbo].[BookingInfo_SelectPoage]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[BookingInfo_SelectPoage]
	@pageIndex INT,  --页数
	@pageNum INT,   --条目数
	@name VARCHAR(50)  ,--学生姓名
	@title VARCHAR(50),--书名
	@totalPage INT OUTPUT --输出参数 返回总页数
AS  --IS null(字段,'')<>''
IF( LEN(@name)=0  AND LEN(@title)=0)
	BEGIN 
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,BookingPeople,Title,
		BookCode,BookingDate,BookingEndDate FROM dbo.BookingInfo) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END
ELSE IF( NOT(LEN(@name)=0)  AND LEN(@title)=0)
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,BookingPeople,Title,
		BookCode,BookingDate,BookingEndDate FROM dbo.BookingInfo WHERE BookingPeople LIKE '%'+@name+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE IF(LEN(@name)=0  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,BookingPeople,Title,
		BookCode,BookingDate,BookingEndDate FROM dbo.BookingInfo WHERE Title LIKE '%'+@title+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE IF(NOT(LEN(@name)=0)  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,BookingPeople,Title,
		BookCode,BookingDate,BookingEndDate FROM dbo.BookingInfo WHERE 
		BookingPeople LIKE '%'+@name+'%'AND  Title LIKE '%'+@title+'%' ) AS temp WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
	--计算一共多少页
	DECLARE @totalNum INT --数据总条数
	--计算一共有多少条数据
IF( LEN(@name)=0  AND LEN(@title)=0)
	BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.BookingInfo
	END
ELSE IF( NOT(LEN(@name)=0)  AND LEN(@title)=0)
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.BookingInfo WHERE BookingPeople LIKE '%'+@name+'%'
	END
ELSE IF(LEN(@name)=0  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.BookingInfo WHERE Title LIKE '%'+@title+'%' 
	END
ELSE IF(NOT(LEN(@name)=0)  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.BookingInfo WHERE BookingPeople LIKE '%'+@name+'%'AND  Title LIKE '%'+@title+'%' 
	END
ELSE
    BEGIN
		SELECT	@totalNum=0
	END

	--计算有多少页（数据总条数/每页多少条）
IF(@totalNum%@pageNum=0)
	BEGIN	
		SET @totalPage=@totalNum/@pageNum
	END
ELSE	
	BEGIN	
		SET @totalPage=@totalNum/@pageNum+1
	END
GO
/****** Object:  StoredProcedure [dbo].[Books_SelectPoage]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[Books_SelectPoage]
	@pageIndex INT,  --页数
	@pageNum INT,   --条目数
	@title VARCHAR(20)  ,--书名
	@bookType VARCHAR(20),--图书类型
	@bookCode VARCHAR(20),--图书编号
	@totalPage INT OUTPUT --输出参数 返回总页数
AS
IF( LEN(@title)=0  AND LEN(@bookType)=0 AND LEN(@bookCode)=0)
	BEGIN 
		SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
		PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
		FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType) 
		AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END
ELSE IF( NOT(LEN(@title)=0) AND LEN(@bookType)=0 AND LEN(@bookCode)=0)
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE Title LIKE '%'+@title+'%') 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE IF(LEN(@title)=0 AND NOT(LEN(@bookType)=0) AND LEN(@bookCode)=0)
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE Name=@bookType) 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE IF(LEN(@title)=0 AND LEN(@bookType)=0 AND NOT(LEN(@bookCode)=0))
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE BookCode LIKE '%'+@bookCode+'%') 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE IF(NOT(LEN(@title)=0) AND NOT(LEN(@bookType)=0) AND LEN(@bookCode)=0)
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE Title LIKE '%'+@title+'%' AND Name=@bookType) 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE IF(NOT(LEN(@title)=0) AND LEN(@bookType)=0 AND NOT(LEN(@bookCode)=0))
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE Title LIKE '%'+@title+'%' AND BookCode LIKE '%'+@bookCode+'%') 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE IF(LEN(@title)=0 AND NOT(LEN(@bookType)=0) AND NOT(LEN(@bookCode)=0))
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE Name=@bookType AND BookCode LIKE '%'+@bookCode+'%') 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE IF(NOT(LEN(@title)=0 AND NOT((LEN(@bookType)=0)) AND NOT(LEN(@bookCode)=0)))
		BEGIN 
			SELECT * FROM(SELECT Books.ID,ROW_NUMBER()OVER(ORDER BY Books.ID ASC ) AS num,Title,Author,ISBN,PublishingHouse,
			PublicationDate,BookType,BookCode,NumBorrowed,Picture,IsBorrow,IsBooking,Name
			FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType WHERE Title LIKE '%'+@title+'%' AND Name=@bookType AND BookCode LIKE '%'+@bookCode+'%') 
			AS temp WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
		END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
	--计算一共多少页
	DECLARE @totalNum INT --数据总条数
	--计算一共有多少条数据
IF( LEN(@title)=0  AND LEN(@bookType)=0 AND LEN(@bookCode)=0)
	BEGIN 
	SELECT	@totalNum=COUNT(1) FROM dbo.Books
	END
ELSE IF( NOT(LEN(@title)=0) AND LEN(@bookType)=0 AND LEN(@bookCode)=0)
		BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.Books WHERE  Title LIKE '%'+@title+'%'
		END
ELSE IF(LEN(@title)=0 AND NOT(LEN(@bookType)=0) AND LEN(@bookCode)=0)
		BEGIN 
			SELECT	@totalNum=COUNT(1) FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType
			WHERE Name=@bookType
		END
ELSE IF(LEN(@title)=0 AND LEN(@bookType)=0 AND NOT(LEN(@bookCode)=0))
		BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.Books WHERE BookCode LIKE '%'+@bookCode+'%'
		END
ELSE IF(NOT(LEN(@title)=0) AND NOT(LEN(@bookType)=0) AND LEN(@bookCode)=0)
		BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType
		WHERE Title LIKE '%'+@title+'%' AND Name=@bookType
		END
ELSE IF(NOT(LEN(@title)=0) AND LEN(@bookType)=0 AND NOT(LEN(@bookCode)=0))
		BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.Books WHERE Title LIKE '%'+@title+'%' AND BookCode LIKE '%'+@bookCode+'%'
		END
ELSE IF(LEN(@title)=0 AND NOT(LEN(@bookType)=0) AND NOT(LEN(@bookCode)=0))
		BEGIN 
			SELECT	@totalNum=COUNT(1) FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType
			WHERE Name=@bookType AND BookCode LIKE '%'+@bookCode+'%'
		END
ELSE IF(NOT(LEN(@title)=0 AND NOT((LEN(@bookType)=0)) AND NOT(LEN(@bookCode)=0)))
		BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.Books LEFT JOIN  dbo.BookType ON BookType.Code=dbo.Books.BookType 
		WHERE Title LIKE '%'+@title+'%' AND Name=@bookType AND BookCode LIKE '%'+@bookCode+'%'
		END
ELSE
    BEGIN
		SELECT	@totalNum=0
	END

	--计算有多少页（数据总条数/每页多少条）
IF(@totalNum%@pageNum=0)
	BEGIN	
		SET @totalPage=@totalNum/@pageNum
	END
ELSE	
	BEGIN	
		SET @totalPage=@totalNum/@pageNum+1
	END
GO
/****** Object:  StoredProcedure [dbo].[HistoryLendInfo_SelectPoage]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[HistoryLendInfo_SelectPoage]
	@pageIndex INT,  --页数
	@pageNum INT,   --条目数
	@name VARCHAR(50)  ,--学生姓名
	@title VARCHAR(50),--开始日期
	@totalPage INT OUTPUT --输出参数 返回总页数
AS  --IS null(字段,'')<>''
IF( LEN(@name)=0  AND LEN(@title)=0)
	BEGIN 
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,ReaderName,Title,
		BookCode,ISBN,BegintTime,EndTime,ActualTime,IsOverdue,Remark FROM dbo.HistoryLendInfo) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END
ELSE IF( NOT(LEN(@name)=0)  AND LEN(@title)=0)
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,ReaderName,Title,
		BookCode,ISBN,BegintTime,EndTime,ActualTime,IsOverdue,Remark FROM dbo.HistoryLendInfo WHERE ReaderName LIKE '%'+@name+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE IF(LEN(@name)=0  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,ReaderName,Title,
		BookCode,ISBN,BegintTime,EndTime,ActualTime,IsOverdue,Remark FROM dbo.HistoryLendInfo WHERE Title LIKE '%'+@title+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE IF(NOT(LEN(@name)=0)  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,ReaderName,Title,
		BookCode,ISBN,BegintTime,EndTime,ActualTime,IsOverdue,Remark FROM dbo.HistoryLendInfo WHERE 
		ReaderName LIKE '%'+@name+'%'AND  Title LIKE '%'+@title+'%' ) AS temp WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
	--计算一共多少页
	DECLARE @totalNum INT --数据总条数
	--计算一共有多少条数据
IF( LEN(@name)=0  AND LEN(@title)=0)
	BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.HistoryLendInfo
	END
ELSE IF( NOT(LEN(@name)=0)  AND LEN(@title)=0)
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.HistoryLendInfo WHERE ReaderName LIKE '%'+@name+'%'
	END
ELSE IF(LEN(@name)=0  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.HistoryLendInfo WHERE Title LIKE '%'+@title+'%' 
	END
ELSE IF(NOT(LEN(@name)=0)  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.HistoryLendInfo WHERE ReaderName LIKE '%'+@name+'%'AND  Title LIKE '%'+@title+'%' 
	END
ELSE
    BEGIN
		SELECT	@totalNum=0
	END

	--计算有多少页（数据总条数/每页多少条）
IF(@totalNum%@pageNum=0)
	BEGIN	
		SET @totalPage=@totalNum/@pageNum
	END
ELSE	
	BEGIN	
		SET @totalPage=@totalNum/@pageNum+1
	END
GO
/****** Object:  StoredProcedure [dbo].[LendInfo_SelectPoage]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[LendInfo_SelectPoage]
	@pageIndex INT,  --页数
	@pageNum INT,   --条目数
	@name VARCHAR(50)  ,--学生姓名
	@title VARCHAR(50),--书名
	@totalPage INT OUTPUT --输出参数 返回总页数
AS  --IS null(字段,'')<>''
IF( LEN(@name)=0  AND LEN(@title)=0)
	BEGIN 
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,
		ReaderID,ReaderName,Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue,Remark FROM dbo.LendInfo) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END
ELSE IF( NOT(LEN(@name)=0)  AND LEN(@title)=0)
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,ReaderName,
		Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue,Remark FROM dbo.LendInfo WHERE ReaderName LIKE '%'+@name+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE IF(LEN(@name)=0  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,
		ReaderName,Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue,Remark FROM dbo.LendInfo WHERE Title LIKE '%'+@title+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE IF(NOT(LEN(@name)=0)  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC) AS num ,ReaderID,ReaderName,
		Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue,Remark FROM dbo.LendInfo WHERE 
		ReaderName LIKE '%'+@name+'%'AND  Title LIKE '%'+@title+'%' ) AS temp 
		WHERE num BETWEEN  (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum 
	END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
	--计算一共多少页
	DECLARE @totalNum INT --数据总条数
	--计算一共有多少条数据
IF( LEN(@name)=0  AND LEN(@title)=0)
	BEGIN 
		SELECT	@totalNum=COUNT(1) FROM dbo.LendInfo
	END
ELSE IF( NOT(LEN(@name)=0)  AND LEN(@title)=0)
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.LendInfo WHERE ReaderName LIKE '%'+@name+'%'
	END
ELSE IF(LEN(@name)=0  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.LendInfo WHERE Title LIKE '%'+@title+'%' 
	END
ELSE IF(NOT(LEN(@name)=0)  AND  NOT(LEN(@title)=0))
    BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.LendInfo WHERE ReaderName LIKE '%'+@name+'%'AND  Title LIKE '%'+@title+'%' 
	END
ELSE
    BEGIN
		SELECT	@totalNum=0
	END

	--计算有多少页（数据总条数/每页多少条）
IF(@totalNum%@pageNum=0)
	BEGIN	
		SET @totalPage=@totalNum/@pageNum
	END
ELSE	
	BEGIN	
		SET @totalPage=@totalNum/@pageNum+1
	END
GO
/****** Object:  StoredProcedure [dbo].[Staff_Inquire]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[Staff_Inquire]
	@Name VARCHAR(20)  ,--姓名
	@Type VARCHAR(20),--类型
	@JobNumber VARCHAR(20)--工号
AS 		
IF(LEN(@Name)=0 AND LEN(@Type)=0 AND LEN(@JobNumber)=0)
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code
	END
ELSE IF	(NOT(LEN(@Name)=0) AND LEN(@Type)=0 AND LEN(@JobNumber)=0)	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
        Name LIKE '%'+@Name+'%'
	END
ELSE IF	(LEN(@Name)=0 AND NOT(LEN(@Type)=0)  AND LEN(@JobNumber)=0)	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
        TypeName=@Type
	END
ELSE IF	(LEN(@Name)=0 AND LEN(@Type)=0  AND NOT(LEN(@JobNumber)=0))	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
        JobNumber=@JobNumber
	END
ELSE IF	(NOT(LEN(@Name)=0) AND NOT(LEN(@Type)=0) AND LEN(@JobNumber)=0)	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
        Name LIKE '%'+@Name+'%' AND TypeName=@Type
	END
ELSE IF	(NOT(LEN(@Name)=0) AND LEN(@Type)=0 AND NOT(LEN(@JobNumber)=0))	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
        Name LIKE '%'+@Name+'%' AND JobNumber=@JobNumber
	END
ELSE IF	(LEN(@Name)=0 AND NOT(LEN(@Type)=0) AND NOT(LEN(@JobNumber)=0))	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
        TypeName=@Type AND JobNumber=@JobNumber
	END
ELSE IF	(NOT(LEN(@Name)=0) AND NOT(LEN(@Type)=0) AND NOT(LEN(@JobNumber)=0))	
	BEGIN
		SELECT Staff.ID,StaffCode,Password,Name,Phone,StaffType,TypeName,JobNumber FROM Staff LEFT JOIN dbo.StaffType ON StaffType=Code WHERE
         Name LIKE '%'+@Name+'%' AND TypeName=@Type AND JobNumber=@JobNumber
	END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
GO
/****** Object:  StoredProcedure [dbo].[Student_SelectPoage]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[Student_SelectPoage]
	@pageIndex INT,  --页数
	@pageNum INT,   --条目数
	@name VARCHAR(20)  ,--学生姓名
	@studentCode VARCHAR(20),--学号
	@totalPage INT OUTPUT --输出参数 返回总页数
AS  --IS null(字段,'')<>''
IF  (LEN(@name)=0  AND LEN(@studentCode)=0)
	BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC)AS num,StudentCode,Password,StudentName,
		Phone,Sex,Mail,ViolationStatus,NumberBooksBorrowed,OverdueReturnNum,IsOverdue,Remark FROM dbo.Student) AS temp
		WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END 
ELSE IF  (NOT(LEN(@name)=0)  AND LEN(@studentCode)=0 )
	BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC)AS num,StudentCode,Password,StudentName,
		Phone,Sex,Mail,ViolationStatus,NumberBooksBorrowed,OverdueReturnNum,IsOverdue,Remark FROM dbo.Student WHERE StudentName LIKE '%'+@name+'%') AS temp
		WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END 
ELSE IF  (LEN(@name)=0  AND NOT(LEN(@studentCode)=0) )
	BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC)AS num,StudentCode,Password,StudentName,
		Phone,Sex,Mail,ViolationStatus,NumberBooksBorrowed,OverdueReturnNum,IsOverdue,Remark FROM dbo.Student WHERE StudentCode=@studentCode) AS temp
		WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END
ELSE IF  (NOT(LEN(@name)=0)  AND NOT(LEN(@studentCode)=0) )
	BEGIN
		SELECT * FROM(SELECT ID,ROW_NUMBER()OVER(ORDER BY ID ASC)AS num,StudentCode,Password,StudentName,
		Phone,Sex,Mail,ViolationStatus,NumberBooksBorrowed,OverdueReturnNum,IsOverdue,Remark FROM dbo.Student WHERE StudentName LIKE '%'+@name+'%'AND StudentCode=@studentCode) AS temp
		WHERE num BETWEEN (@pageIndex-1)*@pageNum+1 AND @pageIndex*@pageNum
	END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
	--计算一共多少页
	DECLARE @totalNum INT --数据总条数
	--计算一共有多少条数据
	IF  (LEN(@name)=0  AND LEN(@studentCode)=0)
	BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.Student
	END 
ELSE IF  (NOT(LEN(@name)=0)  AND LEN(@studentCode)=0 )
	BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.Student WHERE StudentName LIKE '%'+@name+'%'
	END 
ELSE IF  (LEN(@name)=0  AND NOT(LEN(@studentCode)=0) )
	BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.Student WHERE StudentCode=@studentCode
	END
ELSE IF  (NOT(LEN(@name)=0)  AND NOT(LEN(@studentCode)=0) )
	BEGIN
		SELECT	@totalNum=COUNT(1) FROM dbo.Student WHERE StudentName LIKE '%'+@name+'%'AND StudentCode=@studentCode
	END
ELSE
    BEGIN
		SELECT	@totalNum=0
	END
	--计算有多少页（数据总条数/每页多少条）
IF(@totalNum%@pageNum=0)
	BEGIN	
		SET @totalPage=@totalNum/@pageNum
	END
ELSE	
	BEGIN	
		SET @totalPage=@totalNum/@pageNum+1
	END
GO
/****** Object:  StoredProcedure [dbo].[User_LendInfoList]    Script Date: 2022/2/3 10:39:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure  [dbo].[User_LendInfoList]
	@name VARCHAR(20)  ,--读者姓名
	@readerID VARCHAR(20) ,--读者ID
	@title VARCHAR(20)  ,--书名
	@bookCode VARCHAR(max)--图书编号
AS  --IS null(字段,'')<>''
IF(LEN(@title)=0 AND LEN(@bookCode)=0)
	BEGIN
		SELECT ID,Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue FROM dbo.LendInfo WHERE ReaderName= @name AND ReaderID= @readerID
	END
ELSE IF	(NOT(LEN(@title)=0) AND LEN(@bookCode)=0)	
	BEGIN
		SELECT ID,Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue FROM dbo.LendInfo WHERE ReaderName= @name AND ReaderID= @readerID AND Title LIKE '%'+@title+'%'
	END
ELSE IF	(LEN(@title)=0 AND NOT(LEN(@bookCode)=0))	
	BEGIN
		SELECT ID,Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue FROM dbo.LendInfo WHERE ReaderName= @name AND ReaderID= @readerID AND BookCode = @bookCode
	END
ELSE IF	(NOT(LEN(@title)=0) AND NOT(LEN(@bookCode)=0))	
	BEGIN
		SELECT ID,Title,BookCode,ISBN,BegintTime,EndTime,IsOverdue FROM dbo.LendInfo WHERE ReaderName= @name AND ReaderID= @readerID AND Title LIKE '%'+@title+'%' AND BookCode = @bookCode
	END
ELSE
    BEGIN
		RAISERROR('出错了哟',15,1)
	END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预约者ID（学生学号）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookingInfo', @level2type=N'COLUMN',@level2name=N'ReaderID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookingInfo', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书代码（书名简称加随机数字）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookingInfo', @level2type=N'COLUMN',@level2name=N'BookCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预约时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookingInfo', @level2type=N'COLUMN',@level2name=N'BookingDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预约人姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookingInfo', @level2type=N'COLUMN',@level2name=N'BookingPeople'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预定结束时间（开始到结束默认5天）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BookingInfo', @level2type=N'COLUMN',@level2name=N'BookingEndDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作者' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'Author'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版社' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'PublishingHouse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'出版日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'PublicationDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'BookType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书代码（书名简称加随机数字）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'BookCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借阅次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'NumBorrowed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图片' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'Picture'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否借出（0-否；1-是）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'IsBorrow'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否被预约（0-否；1-是）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Books', @level2type=N'COLUMN',@level2name=N'IsBooking'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预定者ID（学生学号）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryBookingInfo', @level2type=N'COLUMN',@level2name=N'ReaderID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预约人姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryBookingInfo', @level2type=N'COLUMN',@level2name=N'BookingPeople'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'预约借书时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryBookingInfo', @level2type=N'COLUMN',@level2name=N'BookingDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际多久借走的                                  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryBookingInfo', @level2type=N'COLUMN',@level2name=N'BorrowingBookDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'通过那种状态保存的历史预定信息（0—逾期未借走自动删除，1——借走保存）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryBookingInfo', @level2type=N'COLUMN',@level2name=N'State'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者ID（学生学号）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'ReaderID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'ReaderName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'BookCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'BegintTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'规定还书时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'实际还书时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'ActualTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否逾期归还（0—否，1—是）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'HistoryLendInfo', @level2type=N'COLUMN',@level2name=N'IsOverdue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者ID（学生学号）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'ReaderID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'读者姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'ReaderName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'书名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图书代码（书名简称加随机数字）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'BookCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'ISBN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借书时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'BegintTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'设置的还书时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'EndTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否逾期（0：未逾期，1已逾期）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'IsOverdue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'LendInfo', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'登录账号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'StaffCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'职员类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'StaffType'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'工号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Staff', @level2type=N'COLUMN',@level2name=N'JobNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'StudentCode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Password'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'学生姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'StudentName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'电话号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Phone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'性别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Sex'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'邮箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Mail'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'违章状态（0-未违章，1-已违章）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'ViolationStatus'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'累计借书量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'NumberBooksBorrowed'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'逾期归还次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'OverdueReturnNum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否存在逾期未还书籍（0-没有，1-有）' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'IsOverdue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'Remark'
GO
