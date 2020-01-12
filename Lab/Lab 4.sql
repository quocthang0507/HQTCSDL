--DROP DATABASE QLTV
CREATE DATABASE QLTV
ON PRIMARY
(
	NAME='QLTV',
    FILENAME='D:\OneDrive\Thang\HOCTAP\2019-2020\HKI\HQTCSDL\Lab\QLTV.mdf',
    SIZE=4MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB
)
LOG ON
( 
	NAME='QLTV_LOG',
    FILENAME ='D:\OneDrive\Thang\HOCTAP\2019-2020\HKI\HQTCSDL\Lab\QLTV_LOG.ldf',
    SIZE=1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB
);
GO

USE QLTV;
GO

CREATE TABLE NhaXuatBan (
	MaNXB char(4) NOT NULL PRIMARY KEY,
	TenNXB nvarchar(30) NOT NULL,
);
GO

CREATE TABLE BanDoc (
	MaThe char(6) NOT NULL PRIMARY KEY,
	TenBanDoc nvarchar(30) NOT NULL,
	DiaChi nvarchar(30),
	SoDT nchar(10)
);
GO

CREATE TABLE TheLoai (
	MaTL char(2) NOT NULL PRIMARY KEY,
	TenTL nvarchar(20) NOT NULL,
);
GO

CREATE TABLE Sach (
	MaSach char(6) NOT NULL PRIMARY KEY,
	Tuade nvarchar(30) NOT NULL,
	MaNXB char(4) REFERENCES NhaXuatBan(MaNXB),
	TacGia	nvarchar(30),
	SoLuong int,
	NgayNhap Datetime,
	MaTL char(2) REFERENCES TheLoai(MaTL)
);
GO

CREATE TABLE MuonSach (
	MaThe char(6) REFERENCES BanDoc(Mathe),
	MaSach char(6) REFERENCES Sach(MaSach),
	NgayMuon Datetime,
	NgayTra Datetime,
	constraint pk_MuonSach primary key (MaThe, MaSach)
);
GO

USE QLTV
INSERT INTO NhaXuatBan VALUES ('N001', N'Giáo dục');
INSERT INTO NhaXuatBan VALUES ('N002', N'Khoa học kỹ thuật');
INSERT INTO NhaXuatBan VALUES ('N003', N'Thống Kê');
SELECT * FROM NhaXuatBan;
GO

INSERT INTO BanDoc VALUES ('050001', N'Trần Xuân', N'17 Yersin', '858936');
INSERT INTO BanDoc VALUES ('050002', N'Lê Nam', N'5 Hai Bà Trưng', '845623');
INSERT INTO BanDoc VALUES ('060001', N'Nguyễn Nam', N'10 Lý Tự Trọng', '823456');
INSERT INTO BanDoc VALUES ('060002', N'Trần Hùng', N'20 Trần Phú', '841256');
SELECT * FROM BanDoc
GO

INSERT INTO TheLoai VALUES ('TH', N'Tin học')
INSERT INTO TheLoai VALUES ('HH', N'Hóa học')
INSERT INTO TheLoai VALUES ('KT', N'Kinh tế')
INSERT INTO TheLoai VALUES ('TN', N'Toán học')
SELECT * FROM TheLoai;
GO

INSERT INTO Sach VALUES ('TH0001', N'Sử dụng Corel Draw', 'N002', N'Đậu Quang Tuấn', 3, '08/09/2005', 'TH')
INSERT INTO Sach VALUES ('TH0002', N'Lập trình mạng', 'N003', N'Phạm Vĩnh Hưng', 2, '03/12/2003', 'TH')
INSERT INTO Sach VALUES ('TH0003', N'Thiêt kế mạng chuyên nghiệp', 'N002', N'Phạm Vĩnh Hưng', 5, '04/05/2003', 'TH')
INSERT INTO Sach VALUES ('TH0004', N'Thực hành mạng', 'N003', N'Trần Quang', 3, '06/05/2004', 'TH')
INSERT INTO Sach VALUES ('TH0005', N'3D Studio kỹ xảo hoạt hình T1',  'N001', N'Trương Bình', 2, '05/02/2004', 'TH')
INSERT INTO Sach VALUES ('TH0006', N'3D Studio kỹ xảo hoạt hình T2', 'N001', N'Trương Bình', 3, '05/06/2004', 'TH')
INSERT INTO Sach VALUES ('TH0007', N'Giáo trình Access 2000', 'N001', N'Thiện Tâm', 5 ,'11/12/2005', 'TH')
SELECT * FROM Sach
GO

INSERT INTO MuonSach VALUES ('050001', 'TH0006', '12/12/2006', '2007/03/01')
INSERT INTO MuonSach(Mathe,MaSach, NgayMuon) VALUES ('050001', 'TH0007', '12/12/2006')
INSERT INTO MuonSach VALUES ('050002', 'TH0001', '2006/03/08', '2007/04/15')
INSERT INTO MuonSach(Mathe,MaSach, NgayMuon) VALUES ('050002', 'TH0004', '2007/03/04')
INSERT INTO MuonSach VALUES ('050002', 'TH0002', '2007/03/04', '04/04/2007')
INSERT INTO MuonSach  VALUES ('050002', 'TH0003', '02/04/2007', '2007/04/15')
INSERT INTO MuonSach (Mathe,MaSach, NgayMuon) VALUES ('060002', 'TH0001', '2007/04/08')
INSERT INTO MuonSach VALUES ('060002', 'TH0007', '2007/03/15', '2007/04/15')
SELECT * FROM MuonSach
GO

--VIEW NXBKHKT

CREATE VIEW [dbo].[VIEW_NXBKHKT]
	AS SELECT MaSach, Tuade, TacGia
	FROM NhaXuatBan NXB, Sach S
	WHERE NXB.MaNXB = S.MaNXB AND TenNXB = N'Khoa học kỹ thuật' OR S.MaNXB = 'N002'
GO

--VIEW DSMUONTIN

CREATE VIEW [dbo].[VIEW_DSMUONTIN]
	AS SELECT TenBanDoc, DiaChi, SoDT, S.MaSach, Tuade
	FROM TheLoai TL, MuonSach M, Sach S, BanDoc BD
	WHERE S.MaSach = M.MaSach AND S.MaTL = TL.MaTL AND BD.MaThe = M.MaThe AND TenTL = N'Tin học'
GO

--Thủ tục InDanhSach

CREATE PROCEDURE INDANHSACH
	@TEN VARCHAR
AS
BEGIN
	SELECT *
	FROM SACH
	WHERE CHARINDEX(@TEN, Tuade) > 0
END
GO

EXEC INDANHSACH '3D'
GO

-- Thủ tục DanhSachMuon

CREATE PROCEDURE DANHSACHMUON
	@MaThe char(6),
	@TenBanDoc nvarchar(30)
AS
BEGIN
	SELECT S.MaSach, S.Tuade, MS.NgayMuon, MS.NgayTra
	FROM Sach S, MuonSach MS, BanDoc BD
	WHERE S.MaSach = MS.MaSach AND MS.MaThe = BD.MaThe AND BD.MaThe = @MaThe AND BD.TenBanDoc = @TenBanDoc
END
GO

EXEC DANHSACHMUON '060002', N'Trần Hùng'
GO

-- Hàm SoLuongSach

CREATE FUNCTION SoLuongSach (@TenTheLoai AS NVARCHAR(20))
RETURNS INT
AS
BEGIN
	RETURN (SELECT SUM(S.SoLuong)
	FROM TheLoai TL INNER JOIN Sach S
	ON TL.MaTL = S.MaTL
	WHERE TenTL LIKE @TenTheLoai)
END
GO

DECLARE @KQ INT
SET @KQ = DBO.SoLuongSach(N'Tin học')
PRINT N'Số lượng sách có thể loại Tin học là : ' + CAST(@KQ AS NVARCHAR)
GO

-- Hàm SoLuongSachXuatBan

CREATE FUNCTION SoLuongSachXuatBan (@TenNXB NVARCHAR(30))
RETURNS INT
AS
BEGIN
	RETURN (SELECT COUNT(S.SoLuong)
	FROM NhaXuatBan NXB INNER JOIN SACH S
	ON NXB.MaNXB = S.MaNXB
	WHERE TenNXB LIKE @TenNXB)
END
GO

DECLARE @KQ INT
SET @KQ = DBO.SoLuongSachXuatBan(N'Giáo dục')
PRINT N'Số lượng sách xuất bản bởi nhà xuất bản Giáo dục là : ' + CAST(@KQ AS NVARCHAR)
GO

-- Hàm InDanhSach

CREATE FUNCTION UDF_InDanhSach (@TIEUDE NVARCHAR(30))
RETURNS TABLE
AS
	RETURN (SELECT *
	FROM SACH
	WHERE CHARINDEX(@TIEUDE, Tuade) > 0);
GO

SELECT * FROM DBO.UDF_InDanhSach('3D')
GO

-- Hàm DanhSachMuon

CREATE FUNCTION UDF_DanhSachMuon 
	(@MaThe char(6), @TenBanDoc nvarchar(30))
RETURNS TABLE
AS
	RETURN (SELECT S.MaSach, S.Tuade, MS.NgayMuon, MS.NgayTra
	FROM Sach S, MuonSach MS, BanDoc BD
	WHERE S.MaSach = MS.MaSach AND MS.MaThe = BD.MaThe AND BD.MaThe = @MaThe AND BD.TenBanDoc = @TenBanDoc)
GO

SELECT * FROM DBO.UDF_DanhSachMuon('060002', N'Trần Hùng')