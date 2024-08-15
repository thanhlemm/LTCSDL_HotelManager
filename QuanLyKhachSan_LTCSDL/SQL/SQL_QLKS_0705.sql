create database QLKS_LTCSDL_2

use QLKS_LTCSDL_2
go

-- BẢNG LOẠI NHÂN VIÊN 1
CREATE TABLE [dbo].[LoaiNhanVien](
	[ID] [char](10) NOT NULL,
	[TenLoai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG NHÂN VIÊN 2
CREATE TABLE [dbo].[NhanVien](
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[IDLoaiNhanVien] [char](10) NOT NULL,
	[CCCD] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[GioiTinh] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [int] NOT NULL,
	[NgayBatDauLam] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
))
GO

-- BẢNG KHÁCH HÀNG 3
CREATE TABLE [dbo].[KhachHang](
	[ID] [char](10) NOT NULL,
	[CCCD] [nvarchar](100) NOT NULL,
	[Ten] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[SDT] [int] NOT NULL,
	[GioiTinh] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG TRẠNG THÁI HÓA ĐƠN 4
CREATE TABLE [dbo].[TrangThaiHoaDon](
	[ID] [int] NOT NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG HÓA ĐƠN 5
CREATE TABLE [dbo].[HoaDon](
	[ID] [char](10) NOT NULL,
	[IDPhieuNhanPhong] [char](10) NOT NULL,
	[TenDangNhapNV] [nvarchar](100) NOT NULL,
	[NgayTao] [smalldatetime] NULL,
	[GiaPhong] [int] NOT NULL,
	[GiaDichVu] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
	[IDTrangThaiHoaDon] [int] NOT NULL,
	[GiamGia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)) 
GO

-- BẢNG LOẠI PHÒNG 6
CREATE TABLE [dbo].[LoaiPhong](
	[ID] [char](10) NOT NULL,
	[TenLoaiPhong] [nvarchar](100) NOT NULL,
	[GiaPhong] [int] NOT NULL,
	[SoLuongNguoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG TRẠNG THÁI PHÒNG 7
CREATE TABLE [dbo].[TrangThaiPhong](
	[ID] [int] NOT NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG PHÒNG 8
CREATE TABLE [dbo].[Phong](
	[ID] [char](10) NOT NULL,
	[TenPhong] [nvarchar](100) NOT NULL,
	[IDLoaiPhong] [char](10) NOT NULL,
	[IDTrangThaiPhong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)
) ON [PRIMARY]
GO


-- BẢNG PHIẾU ĐẶT PHÒNG 9
CREATE TABLE [dbo].[PhieuDatPhong](
	[ID] [char](10) NOT NULL,
	[IDKhachHang] [char](10) NOT NULL,
	[IDLoaiPhong] [char](10) NOT NULL,
	[NgayDatPhong] [smalldatetime] NOT NULL,
	[NgayNhan] [date] NOT NULL,
	[NgayTra] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG PHIẾU NHẬN PHÒNG 10
CREATE TABLE [dbo].[PhieuNhanPhong](
	[ID] [char](10) NOT NULL,
	[IDPhieuDatPhong] [char](10) NOT NULL,
	[IDPhong] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG DỊCH VỤ 11
CREATE TABLE [dbo].[DichVu](
	[ID] [char](10) NOT NULL,
	[TenDichVu] [nvarchar](200) NOT NULL,
	[IDLoaiDichVu] [char](10) NOT NULL,
	[GiaDichVu] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
))
GO

-- BẢNG LOẠI DỊCH VỤ 12
CREATE TABLE [dbo].[LoaiDichVu](
	[ID] [char](10) NOT NULL,
	[TenLoaiDichVu] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)) 
GO

-- BẢNG CHI TIẾT HÓA ĐƠN 13
CREATE TABLE [dbo].[ChiTietHoaDon](
	[IDHoaDon] [char](10) NOT NULL,
	[IDDichVu] [char](10) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[TongTien] [int] NOT NULL,
 CONSTRAINT [PK_HoaDonInfo] PRIMARY KEY CLUSTERED 
(
	[IDDichVu] ASC,
	[IDHoaDon] ASC
)) 
GO


--KHOÁ NGOẠI

ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT (getdate()) FOR [NgayTao]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [GiaPhong]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [TongTien]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [GiamGia]
GO
ALTER TABLE [dbo].[HoaDon] ADD  CONSTRAINT [DF__HoaDon__IDTrangThaiHoaDon__1DB06A4F]  DEFAULT ((1)) FOR [IDTrangThaiHoaDon]
GO
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [GiaDichVu]
GO
ALTER TABLE [dbo].[ChiTietHoaDon] ADD  DEFAULT ((0)) FOR [TongTien]
GO


-- Nhân Viên - Loại Nhân Viên
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([IDLoaiNhanVien])
REFERENCES [dbo].[LoaiNhanVien] ([ID])
GO

-- Hoá Đơn - Trạng Thái Hoá Đơn
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TrangThaiHoaDon] FOREIGN KEY([IDTrangThaiHoaDon])
REFERENCES [dbo].[TrangThaiHoaDon] ([ID])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TrangThaiHoaDon]
GO

-- Hoá Đơn - NhanVien
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([TenDangNhapNV])
REFERENCES [dbo].[NhanVien] ([TenDangNhap])
GO

-- Hoá Đơn - Phiếu Nhận Phòng
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([IDPhieuNhanPhong])
REFERENCES [dbo].[PhieuNhanPhong] ([ID])
GO

-- Phiếu Nhận Phòng - Phiếu Đặt Phòng
ALTER TABLE [dbo].[PhieuNhanPhong]  WITH CHECK ADD FOREIGN KEY([IDPhieuDatPhong])
REFERENCES [dbo].[PhieuDatPhong] ([ID])
GO

-- Phiếu Nhận Phòng - Phòng
ALTER TABLE [dbo].[PhieuNhanPhong]  WITH CHECK ADD FOREIGN KEY([IDPhong])
REFERENCES [dbo].[Phong] ([ID])
GO

-- Phiếu đặt phòng - khách hàng
ALTER TABLE [dbo].[PhieuDatPhong]  WITH CHECK ADD FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KhachHang] ([ID])
GO

-- Phiếu đặt phòng - loại phòng
ALTER TABLE [dbo].[PhieuDatPhong]  WITH CHECK ADD FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO

-- Phong - Loại phòng
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD FOREIGN KEY([IDLoaiPhong])
REFERENCES [dbo].[LoaiPhong] ([ID])
GO

-- Phòng - Trạng thái phòng
ALTER TABLE [dbo].[Phong]  WITH CHECK ADD  CONSTRAINT [FK_Phong_TrangThaiPhong] FOREIGN KEY([IDTrangThaiPhong])
REFERENCES [dbo].[TrangThaiPhong] ([ID])
GO
ALTER TABLE [dbo].[Phong] CHECK CONSTRAINT [FK_Phong_TrangThaiPhong]
GO

--Dịch vụ - Loại dịch vụ
ALTER TABLE [dbo].[DichVu]  WITH CHECK ADD FOREIGN KEY([IDLoaiDichVu])
REFERENCES [dbo].[LoaiDichVu] ([ID])
GO

--Chi tiết hóa đơn - Dịch vụ
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([IDDichVu])
REFERENCES [dbo].[DichVu] ([ID])
GO

--Chi tiết hóa đơn - hóa đơn
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
--==================INSERT INTO=================================
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoai]) VALUES (N'CD001     ', N'Quản lí')
INSERT [dbo].[LoaiNhanVien] ([ID], [TenLoai]) VALUES (N'CD002     ', N'Lễ tân')

INSERT [dbo].[NhanVien] ([TenDangNhap], [Ten], [MatKhau], [IDLoaiNhanVien], [CCCD], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayBatDauLam]) VALUES (N'admin', N'Admin', N'123', N'CD001     ', N'123457145', CAST(N'2003-09-15' AS Date), N'Nữ', N'HCM', 147852, CAST(N'2019-05-23' AS Date))
INSERT [dbo].[NhanVien] ([TenDangNhap], [Ten], [MatKhau], [IDLoaiNhanVien], [CCCD], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayBatDauLam]) VALUES (N'lam', N'Thanh Lam', N'123', N'CD002     ', N'123', CAST(N'2003-12-02' AS Date), N'Nam', N'HCM', 912472758, CAST(N'2018-05-16' AS Date))
INSERT [dbo].[NhanVien] ([TenDangNhap], [Ten], [MatKhau], [IDLoaiNhanVien], [CCCD], [NgaySinh], [GioiTinh], [DiaChi], [SDT], [NgayBatDauLam]) VALUES (N'tan', N'Tan', N'123', N'CD002     ', N'191930005', CAST(N'2003-01-10' AS Date), N'Nữ', N'Long An', 982873872, CAST(N'2020-01-22' AS Date))
GO


INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [SoLuongNguoi]) VALUES (N'LP001     ', N'Phòng Suite (SUT)', 10000000, 6)
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [SoLuongNguoi]) VALUES (N'LP002     ', N'Phòng Deluxe (DLX)', 7000000, 4)
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [SoLuongNguoi]) VALUES (N'LP003     ', N'Phòng Superior (SUP)', 4000000, 3)
INSERT [dbo].[LoaiPhong] ([ID], [TenLoaiPhong], [GiaPhong], [SoLuongNguoi]) VALUES (N'LP004     ', N'Phòng Standard (STD)', 1000000, 2)
GO

INSERT [dbo].[TrangThaiPhong] ([ID], [TrangThai]) VALUES (1, N'Trống')
INSERT [dbo].[TrangThaiPhong] ([ID], [TrangThai]) VALUES (2, N'Có người')



INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH001     ', N'Phòng 101', N'LP001     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH002     ', N'Phòng 102', N'LP002     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH003     ', N'Phòng 103', N'LP003     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH004     ', N'Phòng 104', N'LP004     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH005     ', N'Phòng 105', N'LP001     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH006     ', N'Phòng 106', N'LP004     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH007     ', N'Phòng 107', N'LP004     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH008     ', N'Phòng 108', N'LP004     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH009     ', N'Phòng 109', N'LP003     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH010     ', N'Phòng 201', N'LP003     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH011     ', N'Phòng 202', N'LP003     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH012     ', N'Phòng 203', N'LP002     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH013     ', N'Phòng 204', N'LP002     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH014     ', N'Phòng 205', N'LP004     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH015     ', N'Phòng 206', N'LP003     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH016     ', N'Phòng 207', N'LP002     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH017     ', N'Phòng 208', N'LP004     ', 1)
INSERT [dbo].[Phong] ([ID], [TenPhong], [IDLoaiPhong], [IDTrangThaiPhong]) VALUES (N'PH018     ', N'Phòng 209', N'LP002     ', 1)


INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH001     ', N'16520147', N'Nguyễn Ngọc Thanh', CAST(N'1998-04-06' AS Date), N'TPHCM', 1648222347, N'Nam')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH002     ', N'206117926', N'Hoàng Yến', CAST(N'1998-04-06' AS Date), N'Huế', 1648222347, N'Nữ')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH003     ', N'123456', N'Mai Thúy Vân', CAST(N'1998-04-06' AS Date), N'Tam Kỳ', 1648222347, N'Nữ')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH004     ', N'12782389', N'Trần Ngọc Thủy', CAST(N'1998-04-06' AS Date), N'Hà Nội', 12782389, N'Nữ')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH005     ', N'2563',N'Lê Văn Tân', CAST(N'1998-04-06' AS Date), N'Long An', 147852, N'Nam')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH006     ', N'123456788', N'Nguyễn Văn Thịnh', CAST(N'1998-07-08' AS Date), N'Hà Giang', 123456789, N'Nam')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH007     ', N'123456787', N'Nguyễn Trần Duy Cương', CAST(N'1998-04-06' AS Date), N'Đà Nẵng', 123456785, N'Nam')
INSERT [dbo].[KhachHang] ([ID], [CCCD], [Ten], [NgaySinh], [DiaChi], [SDT], [GioiTinh]) VALUES (N'KH009     ', N'27263950', N'Ngô Thanh Lam', CAST(N'2003-12-02' AS Date), N'TPHCM', 966144938, N'Nữ')

INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP001     ', N'KH004     ', N'LP001     ', CAST(N'2024-03-21T18:12:00' AS SmallDateTime), CAST(N'2024-03-21' AS Date), CAST(N'2024-03-28' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP002     ', N'KH007     ', N'LP001     ', CAST(N'2024-03-21T18:13:00' AS SmallDateTime), CAST(N'2024-03-21' AS Date), CAST(N'2024-03-29' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP003     ', N'KH001     ', N'LP001     ', CAST(N'2024-03-21T18:14:00' AS SmallDateTime), CAST(N'2024-03-21' AS Date), CAST(N'2024-03-27' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP004     ', N'KH005     ', N'LP004     ', CAST(N'2024-03-21T18:15:00' AS SmallDateTime), CAST(N'2024-03-21' AS Date), CAST(N'2024-03-30' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP005     ', N'KH006     ', N'LP004     ', CAST(N'2024-04-05T18:38:00' AS SmallDateTime), CAST(N'2024-04-05' AS Date), CAST(N'2024-04-18' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP006     ', N'KH003     ', N'LP004     ', CAST(N'2024-04-10T01:54:00' AS SmallDateTime), CAST(N'2024-04-10' AS Date), CAST(N'2024-04-18' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP007     ', N'KH003     ', N'LP003     ', CAST(N'2024-04-04T02:27:00' AS SmallDateTime), CAST(N'2024-04-04' AS Date), CAST(N'2024-04-10' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP008     ', N'KH006     ', N'LP002     ', CAST(N'2024-04-13T22:45:00' AS SmallDateTime), CAST(N'2024-04-13' AS Date), CAST(N'2024-04-29' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP009     ', N'KH007     ', N'LP002     ', CAST(N'2024-04-14T09:32:00' AS SmallDateTime), CAST(N'2024-04-14' AS Date), CAST(N'2024-04-29' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP010     ', N'KH002     ', N'LP004     ', CAST(N'2024-04-14T09:33:00' AS SmallDateTime), CAST(N'2024-04-14' AS Date), CAST(N'2024-05-19' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP011     ', N'KH001     ', N'LP003     ', CAST(N'2024-04-14T09:35:00' AS SmallDateTime), CAST(N'2024-04-14' AS Date), CAST(N'2024-06-17' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP012     ', N'KH005     ', N'LP003     ', CAST(N'2024-04-14T09:36:00' AS SmallDateTime), CAST(N'2024-04-14' AS Date), CAST(N'2024-04-27' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP013     ', N'KH004     ', N'LP003     ', CAST(N'2024-04-14T09:39:00' AS SmallDateTime), CAST(N'2024-04-14' AS Date), CAST(N'2024-05-06' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP014     ', N'KH002     ', N'LP003     ', CAST(N'2024-04-16T22:17:00' AS SmallDateTime), CAST(N'2024-04-16' AS Date), CAST(N'2024-04-21' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP015     ', N'KH009     ', N'LP004     ', CAST(N'2024-05-10T22:17:00' AS SmallDateTime), CAST(N'2024-05-16' AS Date), CAST(N'2024-05-21' AS Date))
INSERT [dbo].[PhieuDatPhong] ([ID], [IDKhachHang], [IDLoaiPhong], [NgayDatPhong], [NgayNhan], [NgayTra]) VALUES (N'DP016     ', N'KH005     ', N'LP003     ', CAST(N'2024-05-10T09:39:00' AS SmallDateTime), CAST(N'2024-05-14' AS Date), CAST(N'2024-05-15' AS Date))


INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN001     ', N'DP001     ', N'PH001     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN002     ', N'DP002     ', N'PH002     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN003     ', N'DP003     ', N'PH003     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN004     ', N'DP004     ', N'PH004     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN005     ', N'DP005     ', N'PH005     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN006     ', N'DP006     ', N'PH006     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN007     ', N'DP007     ', N'PH007     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN008     ', N'DP008     ', N'PH008     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN009     ', N'DP009     ', N'PH009     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN010     ', N'DP010     ', N'PH005     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN011     ', N'DP011     ', N'PH006     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN012     ', N'DP012     ', N'PH012     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN013     ', N'DP013     ', N'PH009     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN014     ', N'DP014     ', N'PH013     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN015     ', N'DP015     ', N'PH016     ')
INSERT [dbo].[PhieuNhanPhong] ([ID], [IDPhieuDatPhong], [IDPhong]) VALUES (N'PN016     ', N'DP016     ', N'PH001     ')

INSERT [dbo].[TrangThaiHoaDon] ([ID], [TrangThai]) VALUES (1, N'Chưa thanh toán')
INSERT [dbo].[TrangThaiHoaDon] ([ID], [TrangThai]) VALUES (2, N'Đã thanh toán')

INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD001     ', N'PN001     ', N'admin', CAST(N'2021-03-21T18:34:00' AS SmallDateTime), 0, 5000000, 7500000, 0, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD002     ', N'PN002     ', N'admin', CAST(N'2021-03-21T18:34:00' AS SmallDateTime), 0, 40000000, 60000000, 10, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD003     ', N'PN003     ', N'admin', CAST(N'2021-03-21T18:17:00' AS SmallDateTime), 0, 4000000, 0, 0, 1)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD004     ', N'PN004     ', N'admin', CAST(N'2021-03-21T18:45:00' AS SmallDateTime), 0, 4000000, 7500000, 1, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD005     ', N'PN005     ', N'admin', CAST(N'2021-04-18T09:44:00' AS SmallDateTime), 0, 130000000, 132900000, 10, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD006     ', N'PN006     ', N'admin', CAST(N'2021-04-18T09:44:00' AS SmallDateTime), 0, 8000000, 12850000, 0, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD007     ', N'PN007     ', N'admin', CAST(N'2021-03-21T01:56:00' AS SmallDateTime), 0, 4000000, 10000000, 2, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD008     ', N'PN008     ', N'admin', CAST(N'2021-04-24T19:49:00' AS SmallDateTime), 0, 16000000, 16200000, 5, 2)
INSERT [dbo].[HoaDon] ([ID], [IDPhieuNhanPhong], [TenDangNhapNV], [NgayTao], [GiaPhong], [GiaDichVu], [TongTien], [GiamGia], [IDTrangThaiHoaDon]) VALUES (N'HD009     ', N'PN009     ', N'admin', CAST(N'2021-04-17T23:00:00' AS SmallDateTime), 0, 160000000,  162600000, 0, 2)


INSERT [dbo].[LoaiDichVu] ([ID], [TenLoaiDichVu]) VALUES (N'LV001     ', N'Ăn uống')
INSERT [dbo].[LoaiDichVu] ([ID], [TenLoaiDichVu]) VALUES (N'LV002     ', N'Giải trí')
INSERT [dbo].[LoaiDichVu] ([ID], [TenLoaiDichVu]) VALUES (N'LV003     ', N'Tiện ích')
INSERT [dbo].[LoaiDichVu] ([ID], [TenLoaiDichVu]) VALUES (N'LV004     ', N'Đồ uống')
INSERT [dbo].[LoaiDichVu] ([ID], [TenLoaiDichVu]) VALUES (N'LV005     ', N'Thú vui')

INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV001     ', N'Spa', N'LV002     ', 1200000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV002     ', N'Fitness', N'LV002     ', 100000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV003     ', N'Tam dương trùng phùng với bông cải uyên ương', N'LV001     ', 200000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV004     ', N'Karaoke', N'LV002     ', 1000000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV005     ', N'Giặt ủi quần áo', N'LV003     ', 150000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV006     ', N'Dịch vụ xe đưa đón sân bay', N'LV003     ', 200000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV007     ', N'Dịch vụ cho thuê tự lái', N'LV003     ', 500000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV008     ', N'Dịch vụ trông trẻ', N'LV003     ', 800000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV009     ', N'Bể bơi 4 mùa', N'LV002     ', 1000000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV010     ', N'Sân tennis', N'LV002     ', 500000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV012     ', N'Súp nấm hải vị với gà và thịt cua', N'LV001     ', 200000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV013     ', N'Heo sữa quay bánh bao nửa con', N'LV001     ', 2000000)
INSERT [dbo].[DichVu] ([ID], [TenDichVu], [IDLoaiDichVu], [GiaDichVu]) VALUES (N'DV014     ', N'Chè bột báng trái cây', N'LV001     ', 50000)

--==================TRUY VẤN=================================
--Check tài khoản khi đăng nhập vào
create PROC [dbo].[CheckTaiKhoan] 
@username NVARCHAR(100), @idloainv NVARCHAR(100)
AS
BEGIN
	SELECT TenDangNhap FROM dbo.NhanVien INNER JOIN dbo.LoaiNhanVien ON LoaiNhanVien.ID = NhanVien.IDLoaiNhanVien 
	WHERE TenDangNhap = @username AND @idloainv LIKE IDLoaiNhanVien
END
GO

--Lấy tên đăng nhập và mật khẩu ra để đăng nhập
create proc [dbo].[Login]
@userName nvarchar(100),@passWord nvarchar(100)
as
Select * from NhanVien where TenDangNhap=@userName and MatKhau=@passWord
GO

--Cấp ID tự động
create proc [dbo].[CapIDTuDong]
@table NCHAR(50),@nameID CHAR(10)
AS
BEGIN
	DECLARE @SQL NVARCHAR(2000),@Max NCHAR(10)
	SET @SQL ='select TOP 1'+@nameID +' from '+@table+' order by '+@nameID+' DESC '
   execute @Max = sp_executesql @SQL
end
GO
---------------------------------------------------------------------
--                                 PHÒNG                            
---------------------------------------------------------------------
--Lấy danh sách phòng trống
CREATE proc [dbo].[LoadPhongTrong]
@idRoomType char(10)
as
begin
	select *
	from Phong
	where IDTrangThaiPhong=1 and IDLoaiPhong=@idRoomType
end
GO

--Lâý danh sách phòng đã nhận lên form thanh toán
CREATE proc [dbo].[LoadDSPhongThanhToan]
@getToday Date
as
begin
	select distinct A.*
	from Phong A,PhieuNhanPhong B, PhieuDatPhong C
	where A.IDTrangThaiPhong=2 and A.ID=B.IDPhong and B.IDPhieuDatPhong=C.ID and C.NgayTra>=@getToday
	order by A.ID asc
end
GO

--Lấy ds phòng show lên dataGridView form quản lý phòng
CREATE PROC [dbo].[LoadDSPhong]
AS
SELECT Phong.ID, Phong.TenPhong,LoaiPhong.TenLoaiPhong, GiaPhong, SoLuongNguoi, TrangThaiPhong.TrangThai, IDLoaiPhong, IDTrangThaiPhong
FROM dbo.Phong INNER JOIN dbo.LoaiPhong 
ON LoaiPhong.id = Phong.IDLoaiPhong
INNER JOIN dbo.TrangThaiPhong ON TrangThaiPhong.id = Phong.IDTrangThaiPhong
GO

--Lấy các cột trạng thái phòng
CREATE PROC [dbo].[LoadTrangThaiPhong]
AS
SELECT * FROM dbo.TrangThaiPhong
GO

--Thêm phòng
CREATE PROC [dbo].[ThemPhong]
@id char(10),@nameRoom NVARCHAR(100), @idRoomType char(10), @idStatusRoom int
AS
INSERT INTO dbo.Phong(ID,TenPhong, IDLoaiPhong, IDTrangThaiPhong)
VALUES(@id,@nameRoom, @idRoomType, @idStatusRoom)
GO

--Cập nhật phòng
CREATE PROC [dbo].[CapNhatPhong]
@id char(10), @nameRoom NVARCHAR(100), @idRoomType char(10), @idStatusRoom INT
AS
UPDATE dbo.Phong
SET
	TenPhong = @nameRoom, IDLoaiPhong = @idRoomType, IDTrangThaiPhong = @idStatusRoom
WHERE ID = @id
GO

--Tìm phòng
CREATE PROC [dbo].[TimPhong]
@string NVARCHAR(100), @ma char(10)
AS
BEGIN
	SELECT @string = '%' + @string + '%'
	SELECT Phong.ID, Phong.TenPhong,LoaiPhong.TenLoaiPhong, GiaPhong, SoLuongNguoi,
	TrangThaiPhong.TrangThai, IDLoaiPhong, IDTrangThaiPhong
	FROM dbo.Phong INNER JOIN dbo.LoaiPhong ON LoaiPhong.ID = Phong.IDLoaiPhong INNER JOIN dbo.TrangThaiPhong ON TrangThaiPhong.ID = Phong.IDTrangThaiPhong
	WHERE dbo.Phong.TenPhong LIKE @string OR dbo.Phong.ID = @ma
END
GO

---------------------------------------------------------------------
--                                 LOẠI PHÒNG                            
---------------------------------------------------------------------
--Lấy danh sách loại phòng lên groupbox form đặt phòng
create proc [dbo].[ThongTinLoaiPhong]
@id char(10)
as
begin
select * 
from LoaiPhong
where ID=@id
end
GO

--Lấy tất cả cột loại phòng lên quản lý phòng
CREATE PROC [dbo].[LoadLoaiPhong]
AS
SELECT * FROM dbo.LoaiPhong
GO

--Lấy loại phòng theo id phiếu đặt phòng lên chi tiết phiếu đặt phòng
create proc [dbo].[LayLoaiPhongTheoIDPhieuDP]
@idBookRoom char(10)
as
begin
	select B.*
	from PhieuDatPhong A, LoaiPhong B
	where A.ID=@idBookRoom and A.IDLoaiPhong=B.ID
end
GO

--Lấy danh sách loại phòng theo id phòng
create proc [dbo].[LayLoaiPhongTheoIDPhong]
@idRoom char(10)
as
begin
	select B.*
	from Phong A,LoaiPhong B
	where A.IDLoaiPhong=B.ID and A.ID=@idRoom
end
GO

--Cập nhật loại phòng
CREATE PROC [dbo].[CapNhatLoaiPhong]
@id char(10), @name NVARCHAR(100), @price int, @limitPerson int
AS
	UPDATE LoaiPhong
	SET
    TenLoaiPhong = @name, GiaPhong = @price, SoLuongNguoi = @limitPerson
	WHERE ID =@id
GO

---------------------------------------------------------------------
--                                 KHÁCH HÀNG                           
---------------------------------------------------------------------
--Lấy thông tin khách hàng qua CCCD
CREATE proc [dbo].[CheckCCCDCoTonTaiKhong]
@idCard nvarchar(100)
as
begin
select *
from KhachHang
where CCCD=@idCard
end
GO

--Thêm khách hàng
CREATE proc [dbo].[ThemKhachHang]
@ID char(10),@idCard nvarchar(100),@name nvarchar(100), @dateOfBirth Date,@address nvarchar(200),@phoneNumber int,@sex nvarchar(100)
as
begin
	insert into KhachHang(ID, CCCD, Ten ,NgaySinh ,DiaChi,SDT,GioiTinh)
	values(@ID,@idCard,@name,@dateOfBirth,@address,@phoneNumber,@sex)
end
GO

--Cập nhật khách hàng
create proc [dbo].[CapNhatKhachHang]
@id char(10),@name nvarchar(50),@cccd nvarchar(50),@phoneNumber int, @dateOfBirth date,@address nvarchar(100),@sex nvarchar(20)
as
begin
	update KhachHang
	set Ten=@name,CCCD=@cccd,SDT=@phoneNumber,NgaySinh=@dateOfBirth,DiaChi=@address,GioiTinh=@sex
	where ID=@id
end
GO

--Xoá khách hàng
CREATE proc [dbo].[XoaKhachHang]
@cccd nvarchar(100)
as
BEGIN
    Delete from KhachHang
	Where CCCD = @cccd
END
GO

--Load DS Khach Hang lên formQLKhachHang
CREATE PROC [dbo].[LoadDSKhachHang]
AS
SELECT *
from KhachHang


--Tim kiem khach hang theo Id, tên, cccd, sdt dựa trên index của combobox
CREATE PROC [dbo].[TimKiemKhachHang]
	@string NVARCHAR(100), @mode INT
	AS
	BEGIN
		SELECT @string = '%' + (@string) + '%'
		DECLARE @table TABLE(id char(10))

		IF(@mode = 0)
			INSERT INTO @table SELECT id FROM [dbo].KhachHang WHERE CAST(ID AS NVARCHAR(100)) LIKE @string;
		ELSE IF(@mode = 1)
			INSERT INTO @table SELECT id FROM [dbo].KhachHang WHERE (Ten) LIKE @string;
		ELSE IF(@mode = 2)
			INSERT INTO @table SELECT id FROM [dbo].KhachHang WHERE(CCCD) LIKE @string;
		ELSE IF(@mode = 3)
			INSERT INTO @table SELECT id FROM [dbo].KhachHang WHERE CAST(SDT AS NVARCHAR(100)) LIKE @string;

	    SELECT KhachHang.ID, KhachHang.Ten, CCCD, GioiTinh, NgaySinh, SDT, DiaChi
		FROM KhachHang INNER JOIN @table ON [@table].id = KhachHang.ID 
	END
GO

--Cap nhat khach hang
CREATE PROC [dbo].[CapNhatKhachHang_FormQL]
@id char(10), @customerName NVARCHAR(100), @CCCDNow NVARCHAR(100), @address NVARCHAR(200),
@dateOfBirth date, @phoneNumber int, @sex NVARCHAR(100), @CCCDPre NVARCHAR(100)
AS
BEGIN
	IF(@CCCDPre != @CCCDNow)
	begin
		DECLARE @count INT=0
		SELECT @count=COUNT(*)
		FROM dbo.KhachHang
		WHERE CCCD = @CCCDNow
		IF(@count=0)
		BEGIN
			UPDATE dbo.KhachHang 
			SET 
			Ten =@customerName, CCCD =@CCCDNow,
			DiaChi = @address, NgaySinh =@dateOfBirth, SDT =@phoneNumber,
			GioiTinh = @sex
			WHERE ID = @id
		END
	END
	ELSE
	BEGIN
		UPDATE dbo.KhachHang 
			SET 
			Ten =@customerName, Diachi = @address,
			NgaySinh =@dateOfBirth, SDT =@phoneNumber,
			GioiTinh = @sex
			WHERE ID = @id
	end
END
GO

---------------------------------------------------------------------
--                                 PHIẾU ĐẶT PHÒNG                            
---------------------------------------------------------------------
--Check phiếu đặt phòng đã tồn tại trong phiếu nhận phòng chưa
CREATE proc [dbo].[CheckPhieuDatPhong]
@idBookRoom nvarchar(100)
as
begin
select *
from PhieuNhanPhong
where IDPhieuDatPhong=@idBookRoom
end
GO

--Check ID phiếu đặt phòng
create proc [dbo].[CheckIDPhieuDatPhong]
@idBookRoom char(10),@dateNow date
as
begin
	select *
	from PhieuDatPhong 
	where ID=@idBookRoom and NgayNhan>=@dateNow and ID not in
	(
		select IDPhieuDatPhong
		from PhieuNhanPhong
	)
end
GO

--Lấy danh sách phiếu đặt phòng theo ngày
CREATE proc [dbo].[LayDSDatPhongTheoNgay]
@date Date
as
begin
	select A.ID[Mã đặt phòng], b.Ten[Họ và tên],b.CCCD[CCCD],C.TenLoaiPhong[Loại phòng],A.NgayNhan[Ngày nhận],A.NgayTra[Ngày trả]
	from PhieuDatPhong A,KhachHang B, LoaiPhong C
	where a.IDLoaiPhong=c.ID and A.IDKhachHang=B.ID and A.NgayDatPhong>=@date 
	order by A.NgayDatPhong desc
end
GO

--Lấy danh sách phiếu đặt phòng theo ngày và id phiếu đặt phòng
CREATE proc [dbo].[LayDSDatPhongTheoIDNgay]
@date Date, @idbookroom char(10)
as
begin
	select A.ID[Mã đặt phòng], b.Ten[Họ và tên],b.CCCD[CCCD],C.TenLoaiPhong[Loại phòng],A.NgayNhan[Ngày nhận],A.NgayTra[Ngày trả]
	from PhieuDatPhong A,KhachHang B, LoaiPhong C
	where a.IDLoaiPhong=c.ID and A.IDKhachHang=B.ID and A.NgayDatPhong>=@date and A.ID = @idbookroom
	order by A.NgayDatPhong desc
end
GO

--Thêm phiếu đặt phòng
CREATE proc [dbo].[ThemPhieuDP]
@id char(10),@idCustomer char(10),@idRoomType char(10),@datecheckin date,@datecheckout date,@datebookroom smalldatetime
as
begin
	insert into PhieuDatPhong(ID,IDKhachHang,IDLoaiPhong,NgayNhan,NgayTra,NgayDatPhong)
	values(@id,@idCustomer,@idRoomType,@datecheckin,@datecheckout,@datebookroom)
end
GO

--Xóa phiếu đặt phòng
create proc [dbo].[XoaPhieuDatPhong]
@id char(10)
as
begin
	delete from PhieuDatPhong
	where ID=@id
end
GO

--Cập nhật phiếu đặt phòng
create proc [dbo].[CapNhatPhieuDatPhong]
@id char(10),@idRoomType char(10),@dateCheckIn date,@datecheckOut date
as
begin
	update PhieuDatPhong
	set IDLoaiPhong=@idRoomType,NgayNhan=@dateCheckIn,NgayTra=@datecheckOut
	where ID=@id
end
GO

--Lấy thông tin đặt phòng
create proc [dbo].[ShowThongTinPhieuDatPhong]
@idBookRoom char(10)
as
begin
	select B.Ten[Ten],B.CCCD[CCCD],C.TenLoaiPhong[TenLoaiPhong],A.NgayNhan[NgayNhan],A.NgayTra[NgayTra],C.SoLuongNguoi[SoLuongNguoi],C.GiaPhong[GiaPhong]
	from PhieuDatPhong A,KhachHang B,LoaiPhong C
	where A.ID=@idBookRoom and A.IDKhachHang=B.ID and A.IDLoaiPhong=C.ID
end
GO

---------------------------------------------------------------------
--                                PHIẾU NHẬN PHÒNG                            
---------------------------------------------------------------------
--Lấy ID phiếu nhận phòng hiện tại
create proc [dbo].[LayIDPhieuNhanPhongHienTai]
as
begin
	select MAX(id)
	from PhieuNhanPhong
end
GO

--Load các phiếu nhận phòng theo ngày nhận
create proc [dbo].[LoadPhieuNhanPhongTheoNgayNhanPhong]
@date Date
as
begin
	select A.ID[Mã nhận phòng], b.Ten[Họ và tên],b.CCCD[CCCD],C.TenPhong[Tên phòng],D.NgayNhan[Ngày nhận],D.NgayTra[Ngày trả]
	from PhieuNhanPhong A,KhachHang B, Phong C,PhieuDatPhong D
	where A.IDPhieuDatPhong=D.ID and D.IDKhachHang=B.ID and A.IDPhong=C.ID and D.NgayNhan>=@date
	order by A.ID desc
end
GO

--Thêm phiếu nhận phòng
GO
CREATE proc [dbo].[ThemPhieuNhanPhong]
@id char(10), @idBookRoom char(10),@idRoom char(10)
as
begin
	insert into PhieuNhanPhong(ID,IDPhieuDatPhong,IDPhong)
	values(@id,@idBookRoom,@idRoom)
	update Phong
	set IDTrangThaiPhong=2
	where ID=@idRoom
end
GO

--Lấy ID phiếu nhận phòng theo id phòng
CREATE proc [dbo].[LayIDPhieuNhanPhongTheoIDPhong]--IdRoom đưa vào có trạng thái "Có người"
@idRoom char(10)
as
begin
select *
from PhieuNhanPhong
where IDPhong=@idRoom
order by ID desc
end
GO

---------------------------------------------------------------------
--                                 NHÂN VIÊN                            
---------------------------------------------------------------------
--CheckCCCD nhân viên
create proc [dbo].[CheckCCCDNhanVien]
@idCard nvarchar(100)
as
begin
	select *
	from NhanVien
	where CCCD=@idCard
end
GO
--Cập nhật tên nhân viên
create proc [dbo].[CapNhatTenNhanVien]
@username nvarchar(100),@name nvarchar(100)
as
begin
	update NhanVien
	set Ten=@name
	where TenDangNhap=@username
end
GO

--Cập nhật password
create proc [dbo].[CapNhatPassword]
@username nvarchar(100),@password nvarchar(100)
as
begin
	update NhanVien
	set MatKhau=@password
	where TenDangNhap=@username
end
GO

--Cập nhật các thông tin khác
CREATE proc [dbo].[CapNhatThongTinNhanVien]
@username nvarchar(100),@address nvarchar(100),@phonenumber int,@idcard nvarchar(100),@dateOfBirth date,@sex nvarchar(50)
as
begin
	update NhanVien
	set DiaChi=@address,SDT=@phonenumber,CCCD=@idcard,GioiTinh=@sex, NgaySinh=@dateOfBirth
	where TenDangNhap=@username
end
GO

--Lấy danh sách nhân viên cho form quản lý nhân viên
CREATE PROC [dbo].[LoadDSNhanVien]
AS
BEGIN
	SELECT TenDangNhap, Ten, TenLoai, CCCD,
			NgaySinh, GioiTinh, SDT, NgayBatDauLam, DiaChi, IDLoaiNhanVien
    FROM dbo.NhanVien INNER JOIN dbo.LoaiNhanVien ON LoaiNhanVien.ID = NhanVien.IDLoaiNhanVien
END
GO

--Tim kiem nhan vien
CREATE PROC [dbo].[TimKiemNhanVien]
@string NVARCHAR(100), @int int
AS
BEGIN
	SELECT @string = '%' + (@string) + '%'
	DECLARE @table TABLE( TenDangNhap NVARCHAR(100))
	IF(@int < 1)
	begin
		INSERT INTO @table SELECT TenDangNhap FROM NhanVien
		WHERE TenDangNhap LIKE @string OR (Ten) LIKE @string
		OR  CCCD LIKE @string
	END
	ELSE
    BEGIN
		INSERT INTO @table SELECT TenDangNhap FROM  NhanVien
		WHERE TenDangNhap LIKE @string OR (Ten) LIKE @string
		OR  CCCD LIKE @string OR cast(SDT AS NVARCHAR(100)) LIKE @string
	END
	SELECT NhanVien.TenDangNhap, Ten, TenLoai, CCCD, NgaySinh, GioiTinh, SDT, NgayBatDauLam, DiaChi, IDLoaiNhanVien
    FROM dbo.NhanVien INNER JOIN  @table ON [@table].TenDangNhap = NhanVien.TenDangNhap INNER JOIN dbo.LoaiNhanVien ON LoaiNhanVien.ID = NhanVien.IDLoaiNhanVien
end
GO

--Cap nhat nhan vien 
CREATE PROC [dbo].[CapNhatNhanVien]
@user NVARCHAR(100), @name NVARCHAR(100),@idStaffType char(10),
@idCard NVARCHAR(100), @dateOfBirth DATE, @sex NVARCHAR(100),
@address NVARCHAR(200), @phoneNumber INT, @startDay DATE
AS
BEGIN
	DECLARE @count INT = 0
	SELECT @count=COUNT(*) FROM NhanVien
	WHERE CCCD = @idCard AND TenDangNhap != @user
	IF(@count = 0)
	UPDATE dbo.NhanVien
	SET
    Ten = @name, IDLoaiNhanVien = @idstafftype,
	CCCD= @idCard, NgaySinh = @dateOfBirth, GioiTinh = @sex,
	DiaChi = @address, SDT = @phoneNumber, NgayBatDauLam = @startDay
	WHERE TenDangNhap = @user
END
GO

--Thêm nhân viên
CREATE PROC [dbo].[ThemNhanVien]
@user NVARCHAR(100), @name NVARCHAR(100), @pass NVARCHAR(100),
@idStaffType char(10),@idCard NVARCHAR(100), @dateOfBirth DATE, @sex NVARCHAR(100),
@address NVARCHAR(200), @phoneNumber INT, @startDay date
AS
BEGIN
	DECLARE @count INT =0
	SELECT @count = COUNT(*) FROM dbo.NhanVien WHERE TenDangNhap = @user OR CCCD = @idCard
	IF(@count >0) RETURN
	INSERT INTO dbo.NhanVien(TenDangNhap, Ten, MatKhau, IDLoaiNhanVien, CCCD, NgaySinh, GioiTinh, DiaChi, SDT, NgayBatDauLam)
	VALUES (@user, @name, @pass, @idStaffType,@idCard, @dateOfBirth, @sex, @address, @phoneNumber, @startDay)
END
GO
---------------------------------------------------------------------
--                                 LOẠI NHÂN VIÊN                            
---------------------------------------------------------------------
--Lấy loại nhân viên theo tên đăng nhập để load tên loại lên form thông tin cá nhân
create proc [dbo].[LayLoaiNhanVienTheoTenDangNhap]
@username nvarchar(100)
as
begin
	select B.*
	from NhanVien A, LoaiNhanVien B
	where a.IDLoaiNhanVien=B.ID and A.TenDangNhap=@username
end
GO

--Lấy ds loại nhân viên lên cbbox quản lý nhân viên
CREATE PROC [dbo].[LoadDSLoaiNhanVien]
AS
begin
SELECT * FROM dbo.LoaiNhanVien
end
GO

---------------------------------------------------------------------
--                                 HÓA ĐƠN                            
---------------------------------------------------------------------
--Thêm hóa đơn
CREATE proc [dbo].[ThemHoaDon]
@id char(10),@idReceiveRoom char(10),@staff nvarchar(100)
as
begin
	insert into HoaDon(ID,IDPhieuNhanPhong,TenDangNhapNV)
	values(@id,@idReceiveRoom,@staff)
end
GO

--Cập nhật giá phognf trên hóa đơn
CREATE proc [dbo].[CapNhatHoaDon_GiaPhong]
@IDHoaDon char(10)
as
begin
	declare @idReceiveRoom char(10),@roomPrice int =0,@price int,@days int,@countCustomer int,@limitPerson int

	select @days=DATEDIFF(day,C.NgayNhan,C.NgayTra),@price=D.GiaPhong,@limitPerson=D.SoLuongNguoi,@idReceiveRoom=A.IDPhieuNhanPhong
	from HoaDon A,PhieuNhanPhong B,PhieuDatPhong C,LoaiPhong D,Phong E
	where A.ID=@IDHoaDon and A.IDPhieuNhanPhong=B.ID and B.IDPhong=E.ID and E.IDLoaiPhong=D.ID and C.ID=B.IDPhieuDatPhong

	set @roomPrice=@price*@days;

	update HoaDon
	set GiaPhong=@roomPrice
	where id=@IDHoaDon
end
GO

--Cập nhật giảm giá trên hóa đơn
CREATE proc [dbo].[CapNhatHoaDon_GiamGia]
@IDHoaDon char(10),@discount int
as
begin
	declare @totalPrice int=0,@idRoom char(10)
	select @totalPrice=GiaPhong
	from HoaDon
	where ID=@IDHoaDon

	update HoaDon
	set NgayTao=GETDATE(), TongTien=@totalPrice,GiamGia=@discount,IDTrangThaiHoaDon=2
	where ID=@IDHoaDon

	select @idRoom=B.IDPhong
	from HoaDon A, PhieuNhanPhong B
	where A.IDPhieuNhanPhong=B.ID

	update Phong
	set IDTrangThaiPhong=1
	where ID=@idRoom
end
GO
--Cập nhật giá dịch vụ trong hóa đơn
CREATE proc [dbo].[CapNhatHoaDon_GiaDichVu]
@idBill char(10)
as
begin
	declare @totalServicePrice int=0
	select @totalServicePrice=SUM(TongTien)
	from ChiTietHoaDon
	where IDHoaDon=@idBill
	if(@totalServicePrice is null)
	set @totalServicePrice=0
	update HoaDon 
	set GiaDichVu=@totalServicePrice
	where ID=@idBill
end
GO
--Check phòng đã nhận đã có hóa đơn chưa
CREATE proc [dbo].[CheckTrangThaiHoaDon_Phong]--Trả về count > 0: tức là đã tồn tại HoaDon
@idRoom char(10)
as
begin
	select *
	from HoaDon A,PhieuNhanPhong B
	where A.IDTrangThaiHoaDon=1 and A.IDPhieuNhanPhong=B.ID and B.IDPhong=@idRoom
end
GO

-- Lấy thông tin hóa đơn dịch vụ show lên listView
CREATE proc [dbo].[ShowHoaDonDichVu]
@idRoom char(10)
as
begin
	select D.TenDichVu [Tên dịch vụ],D.GiaDichVu[Đơn giá],B.SoLuong[Số lượng],B.TongTien[Thành tiền]
	from Hoadon A, ChiTietHoaDon B, PhieuNhanPhong C, DichVu D
	where A.IDTrangThaiHoaDon=1 and A.ID=b.IDHoaDon and A.IDPhieuNhanPhong=C.ID and C.IDPhong=@idRoom and B.IDDichVu=D.ID
end
GO

-- Lấy thông tin hóa đơn phòng show lên listView
CREATE proc [dbo].[ShowHoaDonPhong]--Muốn proc thực thi được thì phải thực thi CapNhatHoaDon trước(nếu có thể)
@getToday Date,@idRoom char(10)
as
begin

	select A.TenPhong [Tên phòng],D.GiaPhong[Đơn giá] ,C.NgayNhan [Ngày nhận],C.NgayTra[Ngày trả] ,E.GiaPhong[Tiền phòng]
	from Phong A,PhieuNhanPhong B, PhieuDatPhong C,LoaiPhong D,HoaDon E
	where E.IDPhieuNhanPhong=B.ID and IDTrangThaiPhong=2 and A.ID=B.IDPhong and B.IDPhieuDatPhong=C.ID and A.IDLoaiPhong=D.ID and C.NgayTra>=@getToday and B.IDPhong=@idRoom and E.IDTrangThaiHoaDon=1
end
GO

--Lấy ID hóa đơn theo id phòng 
CREATE proc [dbo].[LayIDHoaDonTheoIDPhong]
@idRoom char(10)
as
begin
	select B.*
	from PhieuNhanPhong A,HoaDon B
	where A.ID=B.IDPhieuNhanPHong and B.IDTrangThaiHoaDon=1 and A.IDPhong=@idRoom
end
GO

-- Load danh sách hóa đơn
CREATE PROC [dbo].[LoadDSHoaDon] 
AS
BEGIN
	SELECT HoaDon.ID, Phong.TenPhong AS [TenPhong], KhachHang.Ten as [TenKhachHang], TenDangNhapNV, NgayTao, TrangThaiHoaDon.TrangThai, TongTien, (cast(GiamGia as nvarchar(4)) + '%') [GiamGia], cast(TongTien*( (100-GiamGia)/100.0) as int) [ThanhTien]
    FROM dbo.HoaDon INNER JOIN dbo.PhieuNhanPhong ON PhieuNhanPhong.ID = HoaDon.IDPhieuNhanPhong
					INNER JOIN dbo.TrangThaiHoaDon ON TrangThaiHoaDon.ID = HoaDon.IDTrangThaiHoaDon
					INNER JOIN dbo.Phong ON Phong.ID = PhieuNhanPhong.IDPhong
					inner join PhieuDatPhong on PhieuDatPhong.ID = PhieuNhanPhong.IDPhieuDatPhong
					inner join KhachHang on KhachHang.ID = PhieuDatPhong.IDKhachHang
	ORDER BY NgayTao DESC
END
GO

--Tim kiem hoa don QLHoaDon

CREATE PROC [dbo].[TimKiemHoaDon]
@string NVARCHAR(100), @mode int
AS
BEGIN
	SELECT @string = '%' + (@string) + '%'
	DECLARE @table TABLE(id char(10))
	IF(@mode = 0)
		INSERT INTO @table SELECT HoaDon.ID FROM HoaDon WHERE CAST(ID AS NVARCHAR(100)) LIKE @string
	ELSE IF(@mode = 1)
		INSERT INTO @table SELECT HoaDon.ID  FROM HoaDon INNER JOIN dbo.PhieuNhanPhong ON PhieuNhanPhong.ID = HoaDon.IDPhieuNhanPhong
		INNER JOIN dbo.PhieuDatPhong ON PhieuDatPhong.ID = PhieuNhanPhong.IDPhieuDatPhong INNER JOIN dbo.KhachHang ON KhachHang.ID = PhieuDatPhong.IDKhachHang 
		WHERE KhachHang.Ten LIKE @string
	ELSE IF(@mode = 2)
		INSERT INTO @table SELECT HoaDon.ID  FROM HoaDon INNER JOIN dbo.PhieuNhanPhong ON PhieuNhanPhong.ID = HoaDon.IDPhieuNhanPhong
		INNER JOIN dbo.PhieuDatPhong ON PhieuDatPhong.ID = PhieuNhanPhong.IDPhieuDatPhong INNER JOIN dbo.KhachHang ON KhachHang.ID = PhieuDatPhong.IDKhachHang
		WHERE KhachHang.CCCD LIKE @string
	ELSE IF(@mode = 3)
		INSERT INTO @table SELECT HoaDon.ID  FROM HoaDon INNER JOIN dbo.PhieuNhanPhong ON PhieuNhanPhong.ID = HoaDon.IDPhieuNhanPhong
		INNER JOIN dbo.PhieuDatPhong ON PhieuDatPhong.ID = PhieuNhanPhong.IDPhieuDatPhong INNER JOIN dbo.KhachHang ON KhachHang.ID = PhieuDatPhong.IDKhachHang
		WHERE CAST(dbo.KhachHang.SDT AS NVARCHAR(100)) LIKE @string

	SELECT HoaDon.ID, Phong.TenPhong, KhachHang.Ten, HoaDon.TenDangNhapNV, HoaDon.NgayTao, TrangThaiHoaDon.TrangThai, HoaDon.TongTien, (cast(HoaDon.GiamGia as nvarchar(4)) + '%') [GiamGia], cast(HoaDon.TongTien*( (100-HoaDon.GiamGia)/100.0) as int) [ThanhTien]
    FROM dbo.HoaDon INNER JOIN dbo.PhieuNhanPhong ON PhieuNhanPhong.ID = HoaDon.IDPhieuNhanPhong
	INNER JOIN dbo.TrangThaiHoaDon ON TrangThaiHoaDon.ID = HoaDon.IDTrangThaiHoaDon
	INNER JOIN dbo.Phong ON Phong.ID = PhieuNhanPhong.IDPhong
	INNER JOIN @table ON HoaDon.ID = [@table].id
	inner join PhieuDatPhong on PhieuDatPhong.ID = PhieuNhanPhong.IDPhieuDatPhong
	inner join KhachHang on KhachHang.ID = PhieuDatPhong.IDKhachHang
	ORDER BY NgayTao DESC
END
GO

---------------------------------------------------------------------
--                                CHI TIẾT HÓA ĐƠN                            
---------------------------------------------------------------------
create Proc [dbo].[CheckDichVu_ChiTietHoaDon]--Kq > 0 :TH3, ngược lại TH2. Tuy nhiên, trước khi kt đk này phải chắc chắn tồn tại Hóa đơn
@idRoom char(10),@idservice char(10)
as
begin
	select *
	from HoaDon A,ChiTietHoaDon B,PhieuNhanPhong C
	where A.IDTrangThaiHoaDon=1 and A.ID=B.IDHoaDon and C.ID=A.IDPhieuNhanPhong and C.IDPhong=@idRoom and B.IDDichVu=@idservice
end
GO

--thêm chi tiết hóa đơn
CREATE proc [dbo].[ThemChiTietHoaDon]
@idBill char(10),@idService char(10),@count int
as
begin
		declare @totalPrice int,@price int
		select @price=GiaDichVu
		from DichVu
		where ID=@idService
		set @totalPrice=@price*@count
		insert into ChiTietHoaDon(IDHoaDon,IDDichVu,SoLuong,TongTien)
		values(@idBill,@idService,@count,@totalPrice)
end
GO

--Cập nhật chi tiết hóa đơn
CREATE proc [dbo].[CapNhatChiTietHoaDon]
@idBill char(10),@idService char(10),@_count int
as
begin
	declare @totalPrice int,@price int,@count int

	select @price=GiaDichVu
	from DichVu
	where ID=@idService

	select @count=SoLuong
	from HoaDon A,ChiTietHoaDon B
	where A.ID=B.IDHoaDon and A.ID=@idBill and A.IDTrangThaiHoaDon=1 and B.IDDichVu=@idService

	set @count=@count+@_count
	if(@count>0)
	begin
		set @totalPrice=@count*@price
		update ChiTietHoaDon
		set SoLuong=@count,TongTien=@totalPrice
		where IDHoaDon=@idBill and IDDichVu=@idService
	end
	else
	begin
		delete from ChiTietHoaDon
		where IDHoaDon=@idBill and IDDichVu=@idService
	end
end
GO

---------------------------------------------------------------------
--                                DỊCH VỤ                            
---------------------------------------------------------------------
--Load dịch vụ theo loại dịch vụ lên combobox
create proc [dbo].[LoadDichVuTheoLoaiDichVu]
@idServiceType char(10)
as
begin
	select *
	from DichVu
	where IDLoaiDichVu=@idServiceType
end
GO