USE [QLPM]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 4/7/2023 3:13:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[id] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK__Account__3213E83FC93F4D95] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BacSi]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BacSi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[QueQuan] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](50) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietTT]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietTT](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[LieuLuong] [int] NOT NULL,
	[Gia] [int] NOT NULL,
	[CachDung] [nvarchar](max) NOT NULL,
	[idThuoc] [int] NOT NULL,
	[idHD] [int] NOT NULL,
 CONSTRAINT [PK__ChiTietT__3213E83F9020A16D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTDV]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTDV](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idHD] [int] NOT NULL,
	[idDV] [int] NOT NULL,
	[Gia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tenDV] [nvarchar](100) NOT NULL,
	[giaDV] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NgayKham] [date] NOT NULL,
	[TienKham] [int] NOT NULL,
	[TienDV] [int] NOT NULL,
	[TienThuoc] [int] NULL,
	[TongTien] [int] NULL,
	[idPK] [int] NOT NULL,
	[TrangThai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuKham]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuKham](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NgayKham] [date] NOT NULL,
	[TrieuChung] [varchar](500) NOT NULL,
	[ChuanDoanBenh] [varchar](500) NOT NULL,
	[idBN] [int] NOT NULL,
	[idBS] [int] NOT NULL,
 CONSTRAINT [PK__PhieuKha__3213E83F1B69B776] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[DonVi] [nvarchar](50) NOT NULL,
	[CongDung] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[NhaSX] [nvarchar](50) NULL,
	[TienThuoc] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([id], [Username], [Password], [Type]) VALUES (1, N'admin', N'1', 1)
INSERT [dbo].[Account] ([id], [Username], [Password], [Type]) VALUES (2, N'doctor2', N'2', 2)
INSERT [dbo].[Account] ([id], [Username], [Password], [Type]) VALUES (3, N'doctor4', N'3', 2)
GO
SET IDENTITY_INSERT [dbo].[BacSi] ON 

INSERT [dbo].[BacSi] ([id], [Ten], [NgaySinh], [QueQuan]) VALUES (1, N'Nguyen Thi Thanh', CAST(N'2002-12-12' AS Date), N'TP.HCM')
INSERT [dbo].[BacSi] ([id], [Ten], [NgaySinh], [QueQuan]) VALUES (2, N'Nguyen Thi Ngoc Yen', CAST(N'2002-12-22' AS Date), N'Tay Ninh')
INSERT [dbo].[BacSi] ([id], [Ten], [NgaySinh], [QueQuan]) VALUES (3, N'Nguyen Hong Son', CAST(N'2002-12-18' AS Date), N'Long An')
INSERT [dbo].[BacSi] ([id], [Ten], [NgaySinh], [QueQuan]) VALUES (4, N'Phan Thi Yen Vi', CAST(N'2002-12-20' AS Date), N'Gia Lai')
SET IDENTITY_INSERT [dbo].[BacSi] OFF
GO
SET IDENTITY_INSERT [dbo].[BenhNhan] ON 

INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (1, N'Thai Tan Phat', 1, CAST(N'2002-04-23' AS Date), N'An Giang')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (2, N'Huynh Minh Hoang', 1, CAST(N'2002-07-23' AS Date), N'Gia Lai')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (3, N'Nguyen Toan My', 0, CAST(N'2002-04-12' AS Date), N'Tien Giang')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (4, N'Nguyen Van Phuoc', 1, CAST(N'2002-08-01' AS Date), N'An Giang')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (5, N'Nguyen Thanh Thuyen', 1, CAST(N'2002-12-02' AS Date), N'Soc Trang')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (6, N'Le Anh Hoa', 0, CAST(N'2002-05-07' AS Date), N'Nha Trang')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (7, N'Nguyen Thi Thanh', 0, CAST(N'2023-03-28' AS Date), N'23 Nguy?n Thái Son')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (8, N'Nguyen Van Tam', 1, CAST(N'2023-03-08' AS Date), N'1 Nguyen Kiem')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (9, N'Tran Thi Dao', 0, CAST(N'2023-03-01' AS Date), N'2 Nguyen Kiem')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (10, N'NFJDF', 1, CAST(N'2023-02-28' AS Date), N'ss fjfjdf')
INSERT [dbo].[BenhNhan] ([id], [Ten], [GioiTinh], [NgaySinh], [DiaChi]) VALUES (11, N'Yen Vi', 0, CAST(N'2023-03-02' AS Date), N'2 AB')
SET IDENTITY_INSERT [dbo].[BenhNhan] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietTT] ON 

SET IDENTITY_INSERT [dbo].[ChiTietTT] OFF
GO
SET IDENTITY_INSERT [dbo].[CTDV] ON 

SET IDENTITY_INSERT [dbo].[CTDV] OFF
GO
SET IDENTITY_INSERT [dbo].[DichVu] ON 

INSERT [dbo].[DichVu] ([id], [tenDV], [giaDV]) VALUES (1, N'Do Duong', 150000)
INSERT [dbo].[DichVu] ([id], [tenDV], [giaDV]) VALUES (2, N'Do mau', 250000)
INSERT [dbo].[DichVu] ([id], [tenDV], [giaDV]) VALUES (3, N'Sieu am', 500000)
INSERT [dbo].[DichVu] ([id], [tenDV], [giaDV]) VALUES (4, N'Xet nghiem mau', 400000)
SET IDENTITY_INSERT [dbo].[DichVu] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([id], [NgayKham], [TienKham], [TienDV], [TienThuoc], [TongTien], [idPK], [TrangThai]) VALUES (1, CAST(N'2002-01-01' AS Date), 100, 50, NULL, NULL, 3, 0)
INSERT [dbo].[HoaDon] ([id], [NgayKham], [TienKham], [TienDV], [TienThuoc], [TongTien], [idPK], [TrangThai]) VALUES (2, CAST(N'2002-02-21' AS Date), 100, 50, NULL, NULL, 4, 0)
INSERT [dbo].[HoaDon] ([id], [NgayKham], [TienKham], [TienDV], [TienThuoc], [TongTien], [idPK], [TrangThai]) VALUES (3, CAST(N'2002-03-12' AS Date), 100, 50, NULL, NULL, 2, 0)
INSERT [dbo].[HoaDon] ([id], [NgayKham], [TienKham], [TienDV], [TienThuoc], [TongTien], [idPK], [TrangThai]) VALUES (4, CAST(N'2002-01-14' AS Date), 100, 50, NULL, NULL, 1, 0)
INSERT [dbo].[HoaDon] ([id], [NgayKham], [TienKham], [TienDV], [TienThuoc], [TongTien], [idPK], [TrangThai]) VALUES (5, CAST(N'2002-03-01' AS Date), 100, 50, NULL, NULL, 4, 0)
INSERT [dbo].[HoaDon] ([id], [NgayKham], [TienKham], [TienDV], [TienThuoc], [TongTien], [idPK], [TrangThai]) VALUES (6, CAST(N'2002-02-01' AS Date), 100, 50, NULL, NULL, 3, 0)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuKham] ON 

INSERT [dbo].[PhieuKham] ([id], [NgayKham], [TrieuChung], [ChuanDoanBenh], [idBN], [idBS]) VALUES (1, CAST(N'2023-01-01' AS Date), N'Dau dau, buon non, sot', N'Benh Phoi', 1, 3)
INSERT [dbo].[PhieuKham] ([id], [NgayKham], [TrieuChung], [ChuanDoanBenh], [idBN], [idBS]) VALUES (2, CAST(N'2023-02-21' AS Date), N'Dau bung, nhuc dau', N'Benh Tieu Hoa', 2, 4)
INSERT [dbo].[PhieuKham] ([id], [NgayKham], [TrieuChung], [ChuanDoanBenh], [idBN], [idBS]) VALUES (3, CAST(N'2023-03-12' AS Date), N'Ngua mat, mat do, mat xung', N'Benh Mat', 1, 2)
INSERT [dbo].[PhieuKham] ([id], [NgayKham], [TrieuChung], [ChuanDoanBenh], [idBN], [idBS]) VALUES (4, CAST(N'2023-01-14' AS Date), N'Dau dau, buon non, dau tim, mau tang', N'Benh Tim', 2, 1)
INSERT [dbo].[PhieuKham] ([id], [NgayKham], [TrieuChung], [ChuanDoanBenh], [idBN], [idBS]) VALUES (5, CAST(N'2023-03-01' AS Date), N'Dau dau, dau duong ruot', N'Benh Tieu Hoa', 3, 4)
INSERT [dbo].[PhieuKham] ([id], [NgayKham], [TrieuChung], [ChuanDoanBenh], [idBN], [idBS]) VALUES (6, CAST(N'2023-02-01' AS Date), N'Dau dau, kho mat, mat mo', N'Benh Mat', 4, 2)
GO
SET IDENTITY_INSERT [dbo].[Thuoc] ON 

INSERT [dbo].[Thuoc] ([id], [Ten], [DonVi], [CongDung], [SoLuong], [NhaSX], [TienThuoc]) VALUES (1, N'Vitamin D', N'chai', N'Tri benh mat', 100, N'Tan Binh', 1000)
INSERT [dbo].[Thuoc] ([id], [Ten], [DonVi], [CongDung], [SoLuong], [NhaSX], [TienThuoc]) VALUES (2, N'Ticagrelor', N'vy', N'Tri Tieu Hoa', 100, N'Quan 12', 2000)
INSERT [dbo].[Thuoc] ([id], [Ten], [DonVi], [CongDung], [SoLuong], [NhaSX], [TienThuoc]) VALUES (3, N'Folic Acid', N'vien', N'Tri Tim', 100, N'Quan Go Vap', 3000)
INSERT [dbo].[Thuoc] ([id], [Ten], [DonVi], [CongDung], [SoLuong], [NhaSX], [TienThuoc]) VALUES (4, N'Memantine', N'chai', N'Tri benh Phoi', 100, N'Quan 1', 10000)
INSERT [dbo].[Thuoc] ([id], [Ten], [DonVi], [CongDung], [SoLuong], [NhaSX], [TienThuoc]) VALUES (5, N'Levothyroxine', N'vy', N'Tri mat', 100, N'Quan 7', 7000)
INSERT [dbo].[Thuoc] ([id], [Ten], [DonVi], [CongDung], [SoLuong], [NhaSX], [TienThuoc]) VALUES (6, N'Zolpidem', N'vien', N'Tri Tim', 100, N'Quan 6', 15000)
SET IDENTITY_INSERT [dbo].[Thuoc] OFF
GO
ALTER TABLE [dbo].[ChiTietTT] ADD  CONSTRAINT [DF_ChiTietTT_Gia]  DEFAULT ((1000)) FOR [Gia]
GO
ALTER TABLE [dbo].[CTDV] ADD  CONSTRAINT [DF_CTDV_Gia]  DEFAULT ((1)) FOR [Gia]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF_HoaDon_TrangThai]  DEFAULT ((0)) FOR [TrangThai]
GO
ALTER TABLE [dbo].[Thuoc] ADD  CONSTRAINT [DF_Thuoc_TienThuoc]  DEFAULT ((1000)) FOR [TienThuoc]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_BacSi] FOREIGN KEY([id])
REFERENCES [dbo].[BacSi] ([id])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_BacSi]
GO
ALTER TABLE [dbo].[ChiTietTT]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTT_HoaDon] FOREIGN KEY([idHD])
REFERENCES [dbo].[HoaDon] ([id])
GO
ALTER TABLE [dbo].[ChiTietTT] CHECK CONSTRAINT [FK_ChiTietTT_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietTT]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietTT_Thuoc] FOREIGN KEY([idThuoc])
REFERENCES [dbo].[Thuoc] ([id])
GO
ALTER TABLE [dbo].[ChiTietTT] CHECK CONSTRAINT [FK_ChiTietTT_Thuoc]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_PhieuKham] FOREIGN KEY([idPK])
REFERENCES [dbo].[PhieuKham] ([id])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_PhieuKham]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_BacSi] FOREIGN KEY([idBS])
REFERENCES [dbo].[BacSi] ([id])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_BacSi]
GO
ALTER TABLE [dbo].[PhieuKham]  WITH CHECK ADD  CONSTRAINT [FK_PhieuKham_BenhNhan] FOREIGN KEY([idBN])
REFERENCES [dbo].[BenhNhan] ([id])
GO
ALTER TABLE [dbo].[PhieuKham] CHECK CONSTRAINT [FK_PhieuKham_BenhNhan]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetAccountByUsername]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_GetAccountByUsername]
@userName nvarchar(100),
@password nvarchar(100)
AS
BEGIN
	declare @kq int	
	SELECT @kq = count(*) FROM dbo.Account
	WHERE Username = @userName and PassWord = @password
	Select @kq as KQ
END

GO
/****** Object:  StoredProcedure [dbo].[SP_GetID]    Script Date: 4/7/2023 3:13:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_GetID]
@name nvarchar(50)
as
begin
	select id from Account where Username=@name
end
GO
