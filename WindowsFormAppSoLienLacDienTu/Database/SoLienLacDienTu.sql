USE [master]
GO
/****** Object:  Database [SoLienLacDienTu]    Script Date: 08-May-24 11:58:16 PM ******/
CREATE DATABASE [SoLienLacDienTu]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SoLienLacDienTu_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.THIENNGUYENDZ\MSSQL\DATA\SoLienLacDienTu.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SoLienLacDienTu_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.THIENNGUYENDZ\MSSQL\DATA\SoLienLacDienTu.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [SoLienLacDienTu] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SoLienLacDienTu].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SoLienLacDienTu] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET ARITHABORT OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [SoLienLacDienTu] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SoLienLacDienTu] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SoLienLacDienTu] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SoLienLacDienTu] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SoLienLacDienTu] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SoLienLacDienTu] SET  MULTI_USER 
GO
ALTER DATABASE [SoLienLacDienTu] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SoLienLacDienTu] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SoLienLacDienTu] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SoLienLacDienTu] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SoLienLacDienTu] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SoLienLacDienTu] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'SoLienLacDienTu', N'ON'
GO
ALTER DATABASE [SoLienLacDienTu] SET QUERY_STORE = OFF
GO
USE [SoLienLacDienTu]
GO
/****** Object:  Table [dbo].[BangDiem]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangDiem](
	[MaHS] [int] NULL,
	[MaMH] [int] NULL,
	[Diem] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhGia]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhGia](
	[MaHS] [int] NULL,
	[HanhKiem] [nvarchar](50) NULL,
	[XepLoai] [nvarchar](50) NULL,
	[NhanXet] [ntext] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [int] IDENTITY(1,1) NOT NULL,
	[TenGV] [nvarchar](50) NULL,
	[DiaChi] [ntext] NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocKy]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocKy](
	[MaHK] [int] IDENTITY(1,1) NOT NULL,
	[HocKy] [int] NULL,
	[MaNH] [int] NULL,
 CONSTRAINT [PK_HocKy] PRIMARY KEY CLUSTERED 
(
	[MaHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocSinh]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocSinh](
	[MaHS] [int] IDENTITY(1,1) NOT NULL,
	[TenHS] [nvarchar](50) NULL,
	[GT] [nvarchar](10) NULL,
	[NS] [char](10) NULL,
	[DiaChi] [ntext] NULL,
	[HoTenCha] [nvarchar](50) NULL,
	[HoTenMe] [nvarchar](50) NULL,
	[MaLop] [int] NULL,
 CONSTRAINT [PK_HocSinh] PRIMARY KEY CLUSTERED 
(
	[MaHS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[TenLop] [varchar](10) NULL,
	[MaGV] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [int] IDENTITY(1,1) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NamHoc]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NamHoc](
	[MaNH] [int] IDENTITY(1,1) NOT NULL,
	[NamHoc] [varchar](20) NULL,
 CONSTRAINT [PK_NamHoc] PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[TenTK] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[LoaiTK] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThoiKhoaBieu]    Script Date: 08-May-24 11:58:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThoiKhoaBieu](
	[MaTKB] [int] IDENTITY(1,1) NOT NULL,
	[MaLop] [int] NULL,
	[MaMH] [int] NULL,
	[TenMH] [nvarchar](50) NULL,
	[NgayHoc] [int] NULL,
	[TietHoc] [int] NULL,
 CONSTRAINT [PK_ThoiKhoaBieu] PRIMARY KEY CLUSTERED 
(
	[MaTKB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BangDiem] ([MaHS], [MaMH], [Diem]) VALUES (17, 1, 10)
INSERT [dbo].[BangDiem] ([MaHS], [MaMH], [Diem]) VALUES (17, 2, 7)
INSERT [dbo].[BangDiem] ([MaHS], [MaMH], [Diem]) VALUES (17, 3, 5)
INSERT [dbo].[BangDiem] ([MaHS], [MaMH], [Diem]) VALUES (17, 5, 10)
INSERT [dbo].[BangDiem] ([MaHS], [MaMH], [Diem]) VALUES (17, 6, 9)
INSERT [dbo].[BangDiem] ([MaHS], [MaMH], [Diem]) VALUES (17, 7, 7)
GO
SET IDENTITY_INSERT [dbo].[GiaoVien] ON 

INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (1, N'Hoàng Thư', N'Hà Nội')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (2, N'Hoàng tú', N'Quảng Ninh')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (7, N'Kiên', N'Hà Nam')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (8, N'Quảng', N'Hà Nội')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (9, N'Quốc Tuấn', N'Hải Dương')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (10, N'Nguyễn Cường', N'Lào Cai')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (11, N'Thùy Linh', N'Bắc Ninh')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [DiaChi]) VALUES (12, N'Mỹ Linh', N'Hồ Chí Minh')
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
GO
SET IDENTITY_INSERT [dbo].[HocSinh] ON 

INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GT], [NS], [DiaChi], [HoTenCha], [HoTenMe], [MaLop]) VALUES (17, N'Nguyen Thien', N'Nam', N'01/01/2011', N'Ninh Binh', N'Không Biết', N'Không Biết', 9)
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GT], [NS], [DiaChi], [HoTenCha], [HoTenMe], [MaLop]) VALUES (18, N'Nguyen Phuc', N'Nam', N'11/05/2011', N'Bac Ninh', N'Không Biết', N'Không Biết', 9)
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GT], [NS], [DiaChi], [HoTenCha], [HoTenMe], [MaLop]) VALUES (19, N'Bui Thang', N'Nam', N'24/02/2011', N'Ha Noi', N'Không Biết', N'Không Biết', 9)
INSERT [dbo].[HocSinh] ([MaHS], [TenHS], [GT], [NS], [DiaChi], [HoTenCha], [HoTenMe], [MaLop]) VALUES (20, N'Nguyen Dong', N'Nam', N'30/10/2012', N'Ha Noi', N'Không Biết', N'Không Biết', 9)
SET IDENTITY_INSERT [dbo].[HocSinh] OFF
GO
SET IDENTITY_INSERT [dbo].[Lop] ON 

INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV]) VALUES (5, N'7A', 12)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV]) VALUES (6, N'6C', 1)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV]) VALUES (7, N'6B', 11)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV]) VALUES (9, N'6A', 2)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV]) VALUES (10, N'7B', 9)
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaGV]) VALUES (11, N'7C', 7)
SET IDENTITY_INSERT [dbo].[Lop] OFF
GO
SET IDENTITY_INSERT [dbo].[MonHoc] ON 

INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (1, N'Toán')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (2, N'Ngữ Văn')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (3, N'Tiếng Anh')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (5, N'Hóa Học')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (6, N'Vật Lý')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (7, N'Lịch Sử')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (8, N'Địa Lý')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (9, N'Giáo Dục Công Dân')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (10, N'Thể Dục')
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (11, N'Tin học')
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [LoaiTK]) VALUES (1, N'admin', N'admin', N'admin@admin.com', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [LoaiTK]) VALUES (5, N'thien', N'a', N'thien@gmail.com', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [LoaiTK]) VALUES (16, N'phuc', N'a', N'phucmeo@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [LoaiTK]) VALUES (17, N'thang', N'a', N'thang@gmail.com', 0)
INSERT [dbo].[TaiKhoan] ([MaTK], [TenTK], [MatKhau], [Email], [LoaiTK]) VALUES (18, N'dong', N'a', N'dong@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[ThoiKhoaBieu] ON 

INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (39, 9, 1, N'Toán', 2, 3)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (40, 9, 5, N'Hóa Học', 2, 4)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (46, 7, 1, N'Toán', 2, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (47, 9, 1, N'Toán', 2, 7)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (48, 9, 10, N'Thể Dục', 2, 8)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (50, 9, 1, N'Toán', 2, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (51, 9, 1, N'Toán', 4, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (52, 9, 1, N'Toán', 4, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (54, 9, 8, N'Địa Lý', 5, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (56, 9, 9, N'Giáo Dục Công Dân', 5, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (58, 9, 10, N'Thể Dục', 5, 4)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (60, 7, 2, N'Ngữ Văn', 6, 4)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (64, 7, 6, N'Vật Lý', 7, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (65, 7, 6, N'Vật Lý', 7, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (66, 7, 7, N'Lịch Sử', 7, 3)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (67, 7, 7, N'Lịch Sử', 2, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (68, 7, 7, N'Lịch Sử', 8, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (69, 9, 7, N'Lịch Sử', 7, 8)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (70, 9, 9, N'Giáo Dục Công Dân', 2, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (71, 9, 9, N'Giáo Dục Công Dân', 3, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (72, 9, 9, N'Giáo Dục Công Dân', 3, 2)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (73, 9, 9, N'Giáo Dục Công Dân', 3, 3)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (74, 9, 7, N'Lịch Sử', 3, 5)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (75, 9, 8, N'Địa Lý', 3, 6)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (76, 9, 10, N'Thể Dục', 3, 7)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (77, 5, 1, N'Toán', 2, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (79, 9, 7, N'Lịch Sử', 7, 1)
INSERT [dbo].[ThoiKhoaBieu] ([MaTKB], [MaLop], [MaMH], [TenMH], [NgayHoc], [TietHoc]) VALUES (80, 9, 11, N'Tin học', 8, 1)
SET IDENTITY_INSERT [dbo].[ThoiKhoaBieu] OFF
GO
ALTER TABLE [dbo].[TaiKhoan] ADD  CONSTRAINT [DF_TaiKhoan_LoaiTK]  DEFAULT ((0)) FOR [LoaiTK]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_HocSinh] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_HocSinh]
GO
ALTER TABLE [dbo].[BangDiem]  WITH CHECK ADD  CONSTRAINT [FK_BangDiem_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[BangDiem] CHECK CONSTRAINT [FK_BangDiem_MonHoc]
GO
ALTER TABLE [dbo].[DanhGia]  WITH CHECK ADD  CONSTRAINT [FK_DanhGia_HocSinh] FOREIGN KEY([MaHS])
REFERENCES [dbo].[HocSinh] ([MaHS])
GO
ALTER TABLE [dbo].[DanhGia] CHECK CONSTRAINT [FK_DanhGia_HocSinh]
GO
ALTER TABLE [dbo].[HocSinh]  WITH CHECK ADD  CONSTRAINT [FK_HocSinh_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[HocSinh] CHECK CONSTRAINT [FK_HocSinh_Lop]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_GiaoVien]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_Lop]
GO
ALTER TABLE [dbo].[ThoiKhoaBieu]  WITH CHECK ADD  CONSTRAINT [FK_ThoiKhoaBieu_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[ThoiKhoaBieu] CHECK CONSTRAINT [FK_ThoiKhoaBieu_MonHoc]
GO
USE [master]
GO
ALTER DATABASE [SoLienLacDienTu] SET  READ_WRITE 
GO
