USE [QLSV_3]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 12/18/2019 6:30:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSo] [int] NOT NULL,
	[MaMH] [nvarchar](6) NOT NULL,
	[Diem] [tinyint] NULL,
 CONSTRAINT [pk_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/18/2019 6:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](6) NOT NULL,
	[TenKhoa] [nvarchar](30) NULL,
 CONSTRAINT [pk_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 12/18/2019 6:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[MaMH] [nvarchar](6) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
	[SoTiet] [int] NULL,
 CONSTRAINT [pk_Mon] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 12/18/2019 6:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSo] [int] NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh] [bit] NULL,
	[DiaChi] [nvarchar](50) NULL,
	[DienThoai] [int] NULL,
	[MaKhoa] [nvarchar](6) NULL,
 CONSTRAINT [pk_SinhVien] PRIMARY KEY CLUSTERED 
(
	[MaSo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610207, N'LSD', 8)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610207, N'MLN1', 10)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610207, N'TTHCM', 9)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610208, N'CNXHKH', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610208, N'LSD', 6)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610208, N'MLN2', 7)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610209, N'CNXHKH', 0)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610209, N'MLN1', 4)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610209, N'MLN2', 2)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610210, N'CNXHKH', 6)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610210, N'LSD', 4)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610210, N'TTHCM', 5)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610211, N'LSD', 6)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610211, N'MLN1', 9)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610211, N'MLN2', 7)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610212, N'CNXHKH', 3)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610212, N'LSD', 2)
INSERT [dbo].[KetQua] ([MaSo], [MaMH], [Diem]) VALUES (1610212, N'MLN2', 7)
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Công nghệ thông tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'LH', N'Luật học')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'NL', N'Nông lâm')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'QTKD', N'Quản trị kinh doanh')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'SH', N'Công nghệ sinh học')
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'CNXHKH', N'Chủ nghĩa xã hội khoa học', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'LSD', N'Lịch sử Đảng', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'MLN1', N'Triết học Mác-Lênin', 45)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'MLN2', N'Kinh tế chính trị', 30)
INSERT [dbo].[Mon] ([MaMH], [TenMH], [SoTiet]) VALUES (N'TTHCM', N'Tư tưởng Hồ Chí Minh', 30)
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1610207, N'La Quốc Thắng', CAST(N'1998-07-05T00:00:00.000' AS DateTime), 0, N'KTX tỉnh', 987610260, N'CNTT')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1610208, N'Nguyễn Văn A', CAST(N'1998-06-06T00:00:00.000' AS DateTime), 0, N'KTX tỉnh', 987610261, N'LH')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1610209, N'Trần Thị B', CAST(N'1998-05-07T00:00:00.000' AS DateTime), 1, N'KTX tỉnh', 987610262, N'SH')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1610210, N'Lê Ngọc C', CAST(N'1998-04-08T00:00:00.000' AS DateTime), 1, N'KTX tỉnh', 987610263, N'NL')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1610211, N'Vũ Ngọc D', CAST(N'1998-03-09T00:00:00.000' AS DateTime), 1, N'KTX tỉnh', 987610264, N'QTKD')
INSERT [dbo].[SinhVien] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [DiaChi], [DienThoai], [MaKhoa]) VALUES (1610212, N'Phạm Anh E', CAST(N'1998-02-10T00:00:00.000' AS DateTime), 0, N'KTX tỉnh', 987610265, N'CNTT')
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [fk_KetQua_MaMH] FOREIGN KEY([MaMH])
REFERENCES [dbo].[Mon] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [fk_KetQua_MaMH]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [fk_KetQua_MaSo] FOREIGN KEY([MaSo])
REFERENCES [dbo].[SinhVien] ([MaSo])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [fk_KetQua_MaSo]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [fk_SinhVien] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [fk_SinhVien]
GO
