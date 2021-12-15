USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 15/12/2021 9:31:42 CH ******/
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

/****** Object:  Table [dbo].[NhanVien]    Script Date: 15/12/2021 9:32:00 CH ******/
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

/****** Object:  Table [dbo].[TheLoai]    Script Date: 15/12/2021 9:32:31 CH ******/
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

/****** Object:  Table [dbo].[NuocUong]    Script Date: 15/12/2021 9:32:41 CH ******/
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

/****** Object:  Table [dbo].[HoaDon]    Script Date: 15/12/2021 9:32:57 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HoaDon](
	[IdHoadon] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[IdNhanvien] [int] NULL,
	[TongCong] [float] NULL,
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

USE [Appbannuoc]
GO

/****** Object:  Table [dbo].[ChiTiethd]    Script Date: 15/12/2021 9:33:06 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChiTiethd](
	[IdChitiet] [int] IDENTITY(1,1) NOT NULL,
	[IdNuoc] [int] NULL,
	[Soluong] [int] NULL,
	[Thanhtien] [float] NULL,
	[IdHoadon] [int] NULL,
 CONSTRAINT [PK_ChiTiethd] PRIMARY KEY CLUSTERED 
(
	[IdChitiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ChiTiethd]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiethd_HoaDon] FOREIGN KEY([IdHoadon])
REFERENCES [dbo].[HoaDon] ([IdHoadon])
GO

ALTER TABLE [dbo].[ChiTiethd] CHECK CONSTRAINT [FK_ChiTiethd_HoaDon]
GO

ALTER TABLE [dbo].[ChiTiethd]  WITH CHECK ADD  CONSTRAINT [FK_ChiTiethd_NuocUong] FOREIGN KEY([IdNuoc])
REFERENCES [dbo].[NuocUong] ([IdNuoc])
GO

ALTER TABLE [dbo].[ChiTiethd] CHECK CONSTRAINT [FK_ChiTiethd_NuocUong]
GO

INSERT INTO dbo.TaiKhoan (Taikhoan, Matkhau, Chucvu) VALUES
('admin','123','admin'),
('staff','321','staff');

INSERT INTO dbo.TheLoai(Tentheloai) VALUES
('trà'),
('sữa'),
('nước ngọt'),
('cafe');

INSERT INTO dbo.NuocUong(TenNuoc, Gia, IdTheloai) VALUES
('Trà tắc','10000','1'),
('Sữa dê dừa','10000','2'),
('Coca','10000','3'),
('Trà đào','12000','1'),
('Sting','10000','3'),
('Cafe sữa','12000','4');


INSERT INTO dbo.NhanVien(Hoten,Gioitinh,NgaySinh,DienThoai) VALUES
('admin','nam','1/1/2000','0707070707'),
('staff','nu','1/1/2000','0808080808');


INSERT INTO dbo.HoaDon(IdNhanvien,NgayLap,TongCong) VALUES
('1','1/12/2020','10000'),
('2','1/12/2020','10000');

INSERT INTO dbo.ChiTiethd(IdNuoc,Soluong,Thanhtien) VALUES
('1','1','10000'),
('3','1','10000');


