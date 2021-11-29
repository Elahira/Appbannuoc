USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[NhanVien]    Script Date: 29/11/2021 7:42:47 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NhanVien](
	[IdNhanvien] [int] IDENTITY(1,1) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[Gioitinh] [nvarchar](50) NULL,
	[DienThoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[IdNhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 29/11/2021 7:43:02 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TaiKhoan](
	[IdTK] [int] IDENTITY(1,1) NOT NULL,
	[Taikhoan] [varchar](50) NULL,
	[Matkhau] [varchar](50) NULL,
	[Chucvu] [varchar](10) NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[IdTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[TheLoai]    Script Date: 29/11/2021 7:43:16 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TheLoai](
	[IdTheloai] [int] IDENTITY(1,1) NOT NULL,
	[Tentheloai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[IdTheloai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[NuocUong]    Script Date: 29/11/2021 7:43:31 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[NuocUong](
	[IdNuoc] [int] IDENTITY(1,1) NOT NULL,
	[TenNuoc] [nvarchar](50) NULL,
	[Gia] [float] NULL,
	[IdTheloai] [int] NULL,
 CONSTRAINT [PK_Drink] PRIMARY KEY CLUSTERED 
(
	[IdNuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[NuocUong]  WITH CHECK ADD  CONSTRAINT [FK_NuocUong_TheLoai] FOREIGN KEY([IdTheloai])
REFERENCES [dbo].[TheLoai] ([IdTheloai])
GO

ALTER TABLE [dbo].[NuocUong] CHECK CONSTRAINT [FK_NuocUong_TheLoai]
GO

USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[HoaDon]    Script Date: 29/11/2021 7:43:57 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HoaDon](
	[IdHoadon] [int] NOT NULL,
	[IdNuoc] [int] NULL,
	[NgayLap] [date] NULL,
	[IdNhanvien] [int] NULL,
	[Thanhtien] [float] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[IdHoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([IdNhanvien])
REFERENCES [dbo].[NhanVien] ([IdNhanvien])
GO

ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO

ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NuocUong] FOREIGN KEY([IdNuoc])
REFERENCES [dbo].[NuocUong] ([IdNuoc])
GO

ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NuocUong]
GO


