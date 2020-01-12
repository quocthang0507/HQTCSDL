USE master

--DROP DATABASE QLSV_2
GO

CREATE DATABASE QLSV_2 ON 
(
	NAME = QLSV,
	FILENAME = 'D:\OneDrive\Thang\HOCTAP\2019-2020\HKI\HQTCSDL\Lab\QLSV2.MDF',
	SIZE = 10 MB,
	MAXSIZE = 50 MB,
	FILEGROWTH = 5 MB
) 
LOG ON 
(
	NAME = QLSV_LOG,
	FILENAME = 'D:\OneDrive\Thang\HOCTAP\2019-2020\HKI\HQTCSDL\Lab\QLSV2_LOG.LDF',
	SIZE = 5 MB,
	MAXSIZE = 25 MB,
	FILEGROWTH = 5 MB
)
GO

USE QLSV_2
GO

--Tao Bang Khoa

CREATE TABLE KHOA
(
	 MAKHOA CHAR (4) NOT NULL PRIMARY KEY, 
	 TENKHOA NVARCHAR(100), 
	 NAMTHANHLAP INT
)
GO

--NHAP DU LIEU CHO BANG KHOA

INSERT INTO KHOA VALUES ('TOAN', 'Toán', 1976)
GO

INSERT INTO KHOA VALUES ('HOA', 'Hóa', 1980)
GO

INSERT INTO KHOA VALUES ('SINH', 'SINh', 1981)
GO

INSERT INTO KHOA VALUES ('VLY', 'Vật Lý', 1982)
GO

--Tao bang sinh vien

CREATE TABLE SVIEN
(
	MASV CHAR (8) NOT NULL PRIMARY KEY, 
	TENSV NVARCHAR (100) NOT NULL, 
	NAM INT, 
	MAKHOA CHAR (4)
)
GO

--NHAP LIEU CHO BANG SVIEN

INSERT INTO SVIEN VALUES ('K27.0017', N'Nguyễn Công Phú', 1, 'TOAN')
GO

INSERT INTO SVIEN VALUES ('K26.0008', N'Phan Anh Khanh', 2, 'TOAN')
GO

INSERT INTO SVIEN VALUES ('K25.0005', N'Lý Thành', 3, 'HOA')
GO

INSERT INTO SVIEN VALUES ('K27.0018', N'Hàn Quốc Việt', 2, 'VLY')
GO

--Tao bang MHOC

CREATE TABLE MHOC
(
	MAMH CHAR (6) NOT NULL PRIMARY KEY, 
	TENMH NVARCHAR (100) NOT NULL, 
	TINCHI INT, 
	MAKHOA CHAR (4)
)
GO

--NHAP DU LIEU CHO BANG MHOC

INSERT INTO MHOC VALUES ('TH0001', N'Tin học đại cương A1', 4, 'TOAN')
GO

INSERT INTO MHOC VALUES ('TH0002', N'Cấu trúc dữ liệu', 4, 'TOAN')
GO

INSERT INTO MHOC VALUES ('TO0001', N'Toán rời rạc', 3, 'TOAN')
GO

INSERT INTO MHOC VALUES ('HH0001', N'Hóa đại cương A1', 5, 'HOA')
GO

INSERT INTO MHOC VALUES ('HH0002', N'Hóa đại cương A2', 5, 'HOA')
GO

INSERT INTO MHOC VALUES ('VL0002', N'Vật lý đại cương A2', 4, 'VLY')
GO

INSERT INTO MHOC VALUES ('TH0003', N'Cơ sở dữ liệu', 5, 'TOAN')
GO

INSERT INTO MHOC VALUES ('VL0001', N'Vật lý đại cương A1', 5, 'VLY')
GO

--Tao bang Điều kiện

CREATE TABLE DKIEN
(
	MAMH CHAR (6)NOT NULL, 
	MAMH_TRUOC CHAR (6) NOT NULL 
)
GO

ALTER TABLE DKIEN ADD
CONSTRAINT PK_DIEUKIEN PRIMARY KEY (MAMH, MAMH_TRUOC)
GO

--NHAP DU LIEU CHO BANG DKIEN

INSERT INTO DKIEN VALUES ('TH0003', 'TO0001')
GO

INSERT INTO DKIEN VALUES ('TH0003', 'TH0002')
GO

INSERT INTO DKIEN VALUES ('TH0002', 'TH0001')
GO

INSERT INTO DKIEN VALUES ('HH0002', 'HH0001')
GO

INSERT INTO DKIEN VALUES ('VL0002', 'VL0001')
GO

--TAO BANG HPHAN

CREATE TABLE HPHAN
(
	MAHP INT NOT NULL PRIMARY KEY, 
	MAMH CHAR (6), 
	HOCKY INT, 
	NAM INT, 
	GV NVARCHAR (50)
)
GO

--NHAP DU LIEU CHO BANG HPHAN

INSERT INTO HPHAN VALUES (1, 'TH0001', 1, 1996, N'N.D. LÂM')
GO

INSERT INTO HPHAN VALUES (2, 'VL0001', 1, 1996, N'T.N. DUNG')
GO

INSERT INTO HPHAN VALUES (3, 'HH0002', 1, 1997, N'H. TUÂN')
GO

INSERT INTO HPHAN VALUES (4, 'TH0001', 1, 1997, N'N.D. LÂM')
GO

INSERT INTO HPHAN VALUES (5, 'TH0003', 2, 1997, N'N.C. PHÚ')
GO

INSERT INTO HPHAN VALUES (6, 'HH0001', 1, 1996, N'L.T. PHÚC')
GO

INSERT INTO HPHAN VALUES (7, 'TH0002', 1, 1998, N'P.T. NHƯ')
GO

INSERT INTO HPHAN VALUES (8, 'TO0001', 1, 1996, N'N.C. PHÚ')
GO

-- TAO BANG KQUA

CREATE TABLE KQUA
(
	MASV CHAR (8) NOT NULL, 
	MAHP INT NOT NULL, 
	DIEM FLOAT
)
GO

ALTER TABLE KQUA ADD
CONSTRAINT PK_KQUA PRIMARY KEY (MASV, MAHP)
GO

--NHAP DU LIEU CHO BANG KQUA

INSERT INTO KQUA VALUES ('K27.0017', 4, 9.5)
GO

INSERT INTO KQUA VALUES ('K26.0008', 1, 10)
GO

INSERT INTO KQUA VALUES ('K25.0005', 6, 6)
GO

INSERT INTO KQUA VALUES ('K27.0018', 2, 8)
GO

INSERT INTO KQUA VALUES ('K26.0008', 3, 9)
GO

-- TAO RANG BUOC KHOA NGOAI CHO BANG SVIEN

ALTER TABLE SVIEN ADD
CONSTRAINT FK_SV_KHOA FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
GO

--TAO RANG BUOC KHOA NGOAI CHO BANG MHOC

ALTER TABLE MHOC ADD
CONSTRAINT FK_MH_KHOA FOREIGN KEY (MAKHOA) REFERENCES KHOA(MAKHOA)
GO

--TAO RANG BUOC KHOA NGOAI CHO BANG DKIEN

ALTER TABLE DKIEN ADD
CONSTRAINT FK_DK_MH FOREIGN KEY (MAMH) REFERENCES MHOC(MAMH)
GO

ALTER TABLE DKIEN ADD
CONSTRAINT FK_DK_MH_TRUOC FOREIGN KEY (MAMH_TRUOC) REFERENCES MHOC(MAMH)
GO

-- TAO RANG BUOC KHOA NGOAI CHO BANG HPHAN

ALTER TABLE HPHAN ADD
CONSTRAINT FK_HP_MHOC FOREIGN KEY (MAMH) REFERENCES MHOC(MAMH)
GO

--TAO RANG BUOC KHOA NGOAI CHO BANG KQUA

ALTER TABLE KQUA ADD
CONSTRAINT FK_KQ_SV FOREIGN KEY (MASV) REFERENCES SVIEN(MASV)
GO

ALTER TABLE KQUA ADD
CONSTRAINT FK_KQ_HPHAN FOREIGN KEY (MAHP) REFERENCES HPHAN(MAHP)
GO

--Cau 1: Liệt kê các sinh viên học ở khoa toán
--Thuộc tính: TENSV, MAKHOA
--Quan hệ: SVIEN
--Điều kiện: MAKHOA='TOAN'

SELECT TENSV
FROM SVIEN
WHERE MAKHOA='TOAN'
GO

--Cau 2: Liệt kê tên môn học và số tín chỉ
--Thuộc tính: TENMH, TINCHI
--Quan hệ: MHOC
--Điều kiện:

SELECT TENMH, TINCHI
FROM MHOC
GO

--Cau 3: Liệt kê kết quả học tập của SV có mã sinh viên K26.0008
--Thuộc tính: MASV, MAHP, DIEM
--Quan hệ: KQUA
--Điều kiện: MASV = 'K26.0008'

SELECT MASV, MAHP, DIEM
FROM KQUA
WHERE MASV='K26.0008'
GO

--Cau 4: Liệt kê tên sinh viên và mã môn học mà sv đó đăng ký với kết quả cuối khóa trên 7 điểm
--Thuộc tính: TENSV, MAHP, DIEM
--Quan hệ: KQUA, SVIEN, HPHAN
--Điều kiện: DIEM>=7

SELECT TENSV, MAMH
FROM KQUA Q, SVIEN S, HPHAN H
WHERE (Q.DIEM>=7 AND ((Q.MAHP = H.MAHP) AND ( S.MASV=Q.MASV )))
GO

--Cau 5: Liệt kê sinh viên thuộc về khoa có phụ trách môn toán rời rạc
--Thuộc tính: TENSV, TENMH, MAKHOA
--Quan hệ: MHOC, SVIEN
--Điều kiện: TENMH = ‘Toán rời rạc’

SELECT TENSV
FROM MHOC M, SVIEN S 
WHERE (TENMH = 'Toán rời rạc' AND ( M.MAKHOA = S.MAKHOA))
GO

--Cau 6: Liệt kê tên SV, tên môn học và điểm số của SV đó ở HK 1 năm 1996
--Thuộc tính: TENSV, TENMH, DIEM, HOCKY, NAM, MAMH, MAHP
--Quan hệ: HPHAN H, SVIEN S, KQUA K, MHOC M
--Điều kiện: HOCKY =1, NAM =1996

SELECT TENSV, TENMH, DIEM
FROM HPHAN H, SVIEN S, KQUA K, MHOC M
WHERE ((hocky =1) AND (H.NAM = 1996) AND (H.MAMH=M.MAMH) AND (H.MAHP=K.MAHP) AND (K.MASV=S.MASV))
GO

--Cau 7: Liet ke mon hoc phai hoc ngay truoc mon CSDL
--Thuộc tính: TENMH, MAMH, MAMH_TRUOC
--Quan hệ: MHOC, DKIEN
--Điều kiện: Mhoc phai hoc truoc mon csdl 

SELECT tenmh
FROM mhoc
WHERE mamh IN (
	SELECT mamh_truoc
	FROM mhoc m, dkien d
	WHERE tenmh='Cơ sở dữ liệu' AND m.mamh=d.mamh
)
GO

--Cau 8: Liet ke mon hoc phai hoc sau mon CSDL
--Thuộc tính: TENMH, MAMH, MAMH_TRUOC
--Quan hệ: MHOC, DKIEN
--Điều kiện: Mhoc phai hoc sau mon csdl

SELECT tenmh
FROM mhoc
WHERE mamh IN (
	SELECT d.mamh
	FROM mhoc m, dkien d
	WHERE tenmh='Cơ sở dữ liệu' AND d.mamh_truoc = m.mamh
)
GO

--Cau 9: Liet ke mon hoc phai hoc truoc mon co so tIN chi nho hon bang 4
--Thuộc tính: TTENMH, MAMH, MAMH_TRUOC, TINCHI
--Quan hệ: MHOC, DKIEN
--Điều kiện: môn học trước của môn có số tín chỉ nhỏ hơn bằng 4

SELECT *
FROM mhoc
WHERE mamh IN (
	SELECT mamh_truoc
	FROM mhoc m, dkien d
	WHERE tINchi<=4 AND m.mamh=d.mamh
)
GO

--Cau 10: Liet ke DS sinh vien, diem cua mon csdl o hk 1 nam 1996 va duoc sap xep theo thu tu giam dan neu trung thi sap theo ten tang dan
--Thuộc tính: TENSV, DIEM, HOCKY, NAM, MANH, MAHP
--Quan hệ: SVIEN, KQUA, HPHAN, MHOC
--Điều kiện: co hoc o hk 1 nam 1996 voi mon csdl

SELECT TENSV, DIEM
FROM svien s, kqua k, hphan h, mhoc m
WHERE ((TENMH='Cơ sở dữ liệu') AND (h.HOCKY =1 ) AND (h.nam =1996) AND (m.mamh = h.mamh) AND (k.mahp=h.mahp) AND (k.masv=s.masv))
ORDER BY diem DESC, s.tensv
GO

--Cau 11: Liệt kê mã HP và số lượng sinh viên đăng ký theo từng học phần
--Thuộc tính: MAHP, MASV
--Quan hệ: Kqua
--Điều kiện:

SELECT MAHP, count (masv) as SL
FROM kqua
GROUP BY mahp
GO

--Cau 12: Liệt kê tên SINh viên và điểm trung bình của SV đó ở từng học kỳ của từng niên học
--Thuộc tính: TENSV, MASV, HOCKY, NAM, DIEM
--Quan hệ: KQUA, SVIEN, HPHAN
--Điều kiện: điểm trong từng học kỳ của từng niên học

SELECT Tensv, avg(diem) as DTB
FROM kqua k, svien s, hphan h
WHERE k.masv=s.masv AND k.mahp = h.mahp
GROUP BY k.masv, tensv, hocky, h.nam
GO

--Cau 13: Liệt kê sinh viên đạt điểm cao nhất
--Thuộc tính: DIEM, MASV
--Quan hệ: SVIEN, KQUA
--Điều kiện:là sinh viên đạt điểm cao nhất

SELECT tensv, diem
FROM svien s, kqua k
WHERE diem>=all(SELECT diem FROM kqua) AND kqua.masv=svien.masv
GO

--Cau 14: Liệt kê tên sinh viên đạt điểm cao nhất ở học kỳ một năm 1996 của môn CSDL
--Thuộc tính: MAMH, MAHP, HOCKY, NAM, DIEM, TENMH
--Quan hệ: HPHAN, SVIEN, KQUA, MHOC
--Điều kiện: Điểm lớn nhất của môn CSDL ở HK 1 năm 1996

SELECT TENSV
FROM HPHAN H, SVIEN S, KQUA K, MHOC M
WHERE ((hocky =1) AND (H.NAM = 1996) AND (H.MAMH=M.MAMH) AND (H.MAHP=.MAHP) AND (K.MASV=S.MASV))
AND (diem>=all(SELECT diem FROM kqua)) AND tenmh = 'Cơ sở dữ liệu'
GO

--Cau 15: Liệt kê tên SV có điểm trung bình cao nhất ở HK1 năm 1996
--Thuộc tính: MAMH, MAHP, HOCKY, NAM, DIEM, TENMH
--Quan hệ: HPHAN, SVIEN, KQUA, MHOC
--Điều kiện: Điểm TB lớn nhất ở HK 1 năm 1996

SELECT Tensv, avg(diem) as DTB
FROM HPHAN H, SVIEN S, KQUA K, MHOC M
WHERE ((hocky =1) AND (H.NAM = 1996) AND (H.MAMH=M.MAMH) AND (H.MAHP=K.MAHP) AND (K.MASV=S.MASV))
GROUP BY K.masv, tensv
HAVING avg(diem)>=all (SELECT avg(diem) FROM kqua)
GO

--cau 16: Liệt kê danh sách 10 sinh viên đạt điểm cao nhất của môn CSDL ở HK 1 năm 1996
--Thuộc tính: DIEM, TENSV, MAMH, TENMH, NAM, HOCKY
--Quan hệ: HPHAN, SVIEN, KQUA, MHOC

SELECT top 10 Diem, TENSV
FROM HPHAN H, SVIEN S, KQUA K, MHOC M
WHERE ((hocky =1) AND (H.NAM = 1996) AND (H.MAMH=M.MAMH) AND (H.MAHP=K.MAHP) AND (K.MASV=S.MASV))
AND tenmh = 'Cơ sở dữ liệu'
ORDER BY diem DESC
GO

--Cau 17: Liệt kê tên SV chưa ĐK môn toán rời rạc
--Thuộc tính: MASV, TENMH
--Quan hệ: SVIEN, KQUA, HPHAN, MHOC
--Điều kiện: chưa đăng ký học môn Toán rời rạc

SELECT masv, tensv
FROM svien
WHERE masv not IN (SELECT kq.masv FROM kqua kq, hphan hp, mhoc mh WHERE kq.mahp=hp.mahp AND mh.tenmh = 'Toán rời rạc' AND mh.mamh = hp.mamh)
GO

--Cau 18: liệt kê những môn học thuộc khoa toán nhưng không được dạy ở HK 1 năm 1996
--Thuộc tính: MAKHOA, HOCKY, NAM, MAMH
--Quan hệ: MHOC, HPHAN
--Điều kiện: MAKHOA = ‘TOAN’ ^ HOCKY =1 ^ NAM = 1996

SELECT *
FROM mhoc 
WHERE makhoa = 'toan' AND mamh not IN (SELECT m.mamh FROM mhoc m, hphan h WHERE(hocky =1) AND (H.NAM = 1996) AND (H.MAMH=m.MAMH))
GO

--Cau 19: Liệt kê danh sách sinh viên năm 3 thuộc khoa toán mà chưa đăng ký học môn cơ sở dữ liệu ở HK1 năm 1996
--Thuộc tính: MAKHOA, MASV, MAHP, MAMH, TENMH
--Quan hệ: MHOC, HPHAN, SVIEN, KQUA
--Điều kiện: SV năm 3 thuộc khoa toán mà chưa đăng ký học môn CSDL

SELECT Masv, Tensv
FROM svien
WHERE nam=3 AND makhoa = 'TOAN' AND (masv not IN (SELECT kq.masv FROM kqua kq, hphan hp, mhoc mh WHERE kq.mahp=hp.mahp AND mh.tenmh ='Cơ sở dữ liệu' AND mh.mamh = hp.mamh))
GO

--Cau 20: Liệt kê danh sách sinh viên có đk trên 3 học phần của hk1 năm 1996
--Thuộc tính: MASV, MAHP, TENSV, HOCKY, NAM
--Quan hệ: SVIEN, HPHAN, KQUA
--Điều kiện: Đăng ký trên 3 HP ở HK 1 năm 1996

SELECT TENSV
FROM SVIEN s, KQUA q, HPHAN h
WHERE s.masv=q.masv AND h.mahp = q.mahp AND h.hocky =1 AND h.nam =1996
GROUP BY tensv, q.masv
HAVING count (q.masv) >=3
GO