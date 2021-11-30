USE [master]
GO
/****** Object:  Database [QuanLyHangHoa]    Script Date: 11/30/2021 4:50:45 PM ******/
CREATE DATABASE [QuanLyHangHoa]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyHangHoa', FILENAME = N'D:\Data\Data\QuanLyHangHoa.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyHangHoa_log', FILENAME = N'D:\Data\Log\QuanLyHangHoa_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyHangHoa] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyHangHoa].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyHangHoa] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyHangHoa] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyHangHoa] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyHangHoa] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyHangHoa] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyHangHoa] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyHangHoa] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyHangHoa] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyHangHoa] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyHangHoa] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyHangHoa] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyHangHoa] SET QUERY_STORE = OFF
GO
USE [QuanLyHangHoa]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[MaDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonViTinh]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViTinh](
	[MaDonViTinh] [int] IDENTITY(1,1) NOT NULL,
	[TenDonViTinh] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonViTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaTriTonKhoToiThieu]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaTriTonKhoToiThieu](
	[MaGiaTriTonKho] [int] IDENTITY(1,1) NOT NULL,
	[SoLuongTonKhoToiThieu] [float] NULL,
	[NgayThayDoi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGiaTriTonKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangHoa]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoa](
	[MaHangHoa] [int] IDENTITY(1,1) NOT NULL,
	[MaMatHang] [int] NULL,
	[MaNhaCungCap] [int] NULL,
	[MaQuiCach] [int] NULL,
	[MaDonViTinh] [int] NULL,
	[MaDanhMuc] [int] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangTonKho]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangTonKho](
	[MaHangHoa] [int] NOT NULL,
	[SoLuongCon] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHangHoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[CMND] [varchar](12) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[SDT] [varchar](10) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DiemSo] [int] NULL,
	[HangThe] [nvarchar](100) NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CMND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoiNhuan]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoiNhuan](
	[GiaTriLoiNhuan] [float] NULL,
	[MaLoiNhuan] [int] IDENTITY(1,1) NOT NULL,
	[NgayThayDoi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoiNhuan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMatHang] [int] IDENTITY(1,1) NOT NULL,
	[TenMatHang] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMatHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenNhanVien] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapHang]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapHang](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaHangHoa] [int] NULL,
	[MaNhanVien] [int] NULL,
	[SoLuong] [int] NULL,
	[GiaNhap] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuiCach]    Script Date: 11/30/2021 4:50:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuiCach](
	[MaQuiCach] [int] IDENTITY(1,1) NOT NULL,
	[TenQuiCach] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQuiCach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMuc] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaDonViTinh])
REFERENCES [dbo].[DonViTinh] ([MaDonViTinh])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaMatHang])
REFERENCES [dbo].[MatHang] ([MaMatHang])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[HangHoa]  WITH CHECK ADD FOREIGN KEY([MaQuiCach])
REFERENCES [dbo].[QuiCach] ([MaQuiCach])
GO
ALTER TABLE [dbo].[HangTonKho]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaHangHoa])
REFERENCES [dbo].[HangHoa] ([MaHangHoa])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PhieuNhapHang]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NhanVien] ([MaNhanVien])
GO
USE [master]
GO
ALTER DATABASE [QuanLyHangHoa] SET  READ_WRITE 
GO
