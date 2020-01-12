﻿use master;
go

--================================= PHẦN CƠ BẢN =================================
create database QLBV
go

use QLBV
go

create table Khoa
(
	MaKhoa char(3) primary key,
	TenKhoa nvarchar(100) not null,
	NamThanhLap datetime not null
)
go

create table NhanVien
(
	MaNhanVien char(4) primary key,
	TenNhanVien nvarchar(100) not null,
	NgaySinh datetime not null,
	MaKhoa char(3) references Khoa(MaKhoa)
)
go

create table BenhNhan
(
	MaBenhNhan char(5) primary key,
	TenBenhNhan nvarchar(100) not null,
	NgaySinh datetime not null,
	Benh nvarchar(100) not null,
	MaKhoa char(3) references Khoa(MaKhoa),
	NgayNhap datetime not null,
	NgayXuat datetime not null
)
go

--Phải thêm cái dòng này trước khi chèn dữ liệu có liên quan đến ngày tháng,
--nếu đề cho theo dạng năm/tháng/ngày thì ghi là ymd, nếu ngày/tháng/năm thì dmy, tháng/ngày/năm là mdy
set dateformat ymd;
go

-- Câu 1
-- Câu a: Chèn dữ liệu

insert into khoa values ('K01', N'Khoa Nội', '1989/03/23');
insert into khoa values ('K02', N'Khoa Ngoại', '1989/03/23');
insert into khoa values ('K03', N'Khoa Nhi', '1989/03/23');
insert into khoa values ('K04', N'Khoa Thần kinh', '1993/06/15');
go

insert into nhanvien values ('N001', N'Tôn Thất Tùng', '1939/03/02', 'K01');
insert into nhanvien values ('N002', N'Trần Quán Anh', '1945/06/20', 'K01'); 
insert into nhanvien values ('N003', N'Phạm Thị Tươi', '1966/06/24', 'K02'); 
insert into nhanvien values ('N004', N'Phạm Thanh Thảo', '1975/10/20', 'K02'); 
insert into nhanvien values ('N005', N'Nguyễn Hà Thanh', '1977/11/2', 'K02'); 
insert into nhanvien values ('N006', N'Trần Văn Trà', '1982/1/23', 'K02'); 
insert into nhanvien values ('N007', N'Nguyễn Văn An', '1980/12/23', 'K03'); 
insert into nhanvien values ('N008', N'Tô Huy Rứa', '1950/2/13', 'K03'); 
insert into nhanvien values ('N009', N'Vũ Thái Hà', '1960/3/15', 'K03'); 
insert into nhanvien values ('N010', N'Phạm Văn Hùng', '1970/12/13', 'K04'); 
insert into nhanvien values ('N011', N'Nguyễn Vũ Trường Sơn', '1965/3/15', 'K04'); 
go

insert into benhnhan values ('B0001', N'Nguyễn Quang A', '1945/4/5', N'Đau ruột thừa', 'K01', '2009/3/12', '2009/3/18');
insert into benhnhan values ('B0002', N'Trần Văn Tuất', '1946/4/15', N'Đau đầu', 'K04', '2009/3/12', '2009/3/23');
insert into benhnhan values ('B0003', N'Phạm Tuấn Tú', '2003/9/15', N'Viêm họng', 'K03', '2009/3/15', '2009/3/20');
insert into benhnhan values ('B0004', N'Phạm Bình Minh', '2006/9/25', N'Viêm họng', 'K03', '2009/3/16', '2009/3/17');
insert into benhnhan values ('B0005', N'Vũ Văn Minh', '1980/5/25', N'Gãy chân', 'K02', '2009/3/17', '2009/3/27');
insert into benhnhan values ('B0006', N'Phạm Thị Mùi', '2008/3/5', N'Đau dạ dày', 'K03', '2009/3/19', '2009/4/20');
insert into benhnhan values ('B0007', N'Tô Hương Linh', '1995/2/15', N'Viêm dạ dày', 'K01', '2009/4/01', '2009/4/21');
insert into benhnhan values ('B0008', N'Trường Giang', '1992/2/15', N'Đau chân', 'K02', '2009/4/05', '2009/4/12');
insert into benhnhan values ('B0009', N'Tô Hiến Thành', '1954/6/11', N'Viêm dây thần kinh tim', 'K04', '2009/4/10', '2009/4/15');
insert into benhnhan values ('B0010', N'Tăng Thanh Hà', '1987/10/15', N'Viêm họng', 'K01', '2009/4/12', '2009/4/12');
go

select * from Khoa
select * from NhanVien
select * from BenhNhan
go

-- Câu b:
/*Số lượng dữ liệu có thể lưu trong cơ sở dữ liệu phụ thuộc vào:
1. Thuộc tính MAX SIZE được quy định của tập tin cơ sở dữ liệu;
2. Kích thước dữ liệu của từng dòng;
3. Các thủ tục, hàm, view, trigger,... được định nghĩa;
4. Số lượng index trong bảng;
5. Dung lượng của ổ cứng...
*/

-- Câu 2
-- Câu 2.1. Liệt kê các nhân viên khoa Nội và tuổi lớn hơn 50.
select *, DATEDIFF(year, NgaySinh, GetDate()) as Tuoi
from NhanVien NV, Khoa K
where NV.MaKhoa = K.MaKhoa and TenKhoa = N'Khoa Nội'
	and DATEDIFF(year, NgaySinh, GetDate()) > 50;
go

-- Câu 2.2. Hãy thống kê số lượng nhân viên theo khoa
select TenKhoa, count(*) as SoLuong
from NhanVien NV, Khoa K
where NV.MaKhoa = K.MaKhoa
group by TenKhoa
go

-- Câu 2.3. Hãy thống kê số bệnh nhân theo khoa
select TenKhoa, count(*) as SoLuong
from BenhNhan BN, Khoa K
where BN.MaKhoa = K.MaKhoa
group by TenKhoa
go

-- Câu 2.4. Tạo mới một bảng ảo tên là canbokhoanhi gồm đầy đủ thông tin của các nhân viên khoa Nhi. 
create view CanBoKhoaNhi
as
	select MaNhanVien, TenNhanVien, NgaySinh, NV.MaKhoa, TenKhoa
	from NhanVien NV, Khoa K
	where NV.MaKhoa = K.MaKhoa and TenKhoa = N'Khoa Nhi'
go

select * from CanBoKhoaNhi
go

-- Câu 2.5. Tạo mới một thủ tục tên là DSBN liệt kê đầy đủ thông tin về các bệnh nhân của một khoa nào đó. Thủ tục này có tham số truyền 
-- vào là tên một khoa. Sau đó viết lệnh để gọi thủ tục này để đưa ra danh sách bệnh nhân khoa Nhi.
create proc DSBN
	@TenKhoa nvarchar(100)
as
	select MaBenhNhan, TenBenhNhan, NgaySinh, Benh, K.MaKhoa, TenKhoa, NgayNhap, NgayXuat
	from BenhNhan BN, Khoa K
	where BN.MaKhoa = K.MaKhoa and TenKhoa = @TenKhoa
go

exec DSBN N'Khoa Nhi'
go

-- Câu 2.6. Tạo mới một hàm có tên là SLBN đếm số lượng bệnh nhân của một khoa nào đó. Hàm này có tham số truyền vào là tên một khoa và 
-- trả ra số lượng bệnh nhân của khoa đó. Hãy viết lệnh gọi hàm này để tìm số lượng bệnh nhân của khoa Ngoại.
create function SLBN (@TenKhoa nvarchar(100))
returns int
as
begin
	declare @SoLuong int
	select @SoLuong = count(*)
	from BenhNhan BN, Khoa K
	where BN.MaKhoa = K.MaKhoa and TenKhoa = @TenKhoa
	return @SoLuong
end
go

select dbo.SLBN(N'Khoa Ngoại')
go

-- Câu 2.7. Tạo Trigger ràng buộc ngày xuất viện của bệnh nhân phải sau ngày nhập viện.
create trigger Trigger_NXuatVien_Sau_NNhapVien
on BenhNhan for insert, update -- Trigger cho bảng BenhNhan, thao tác tự động kiểm tra mỗi khi insert, update
as
	if update(NgayXuat) or update(NgayNhap) -- Nếu cột cần kiểm tra có sự thay đổi
		if exists(select TenBenhNhan from inserted where NgayXuat < NgayNhap) -- Nếu dữ liệu chèn vào (inserted) SAI
			begin	-- Thông báo lỗi và quay lại trạng thái ban đầu
				raiserror ('Ngay xuat vien phai sau ngay nhap vien', 15, 1) -- 15 với 1 là mã lỗi: Level 15, State 1
				rollback tran
			end
go

insert into BenhNhan values ('B0100', N'Nguyễn Thị C', '1990/4/15', N'Đau đầu', 'K04', '2019/11/23', '2019/11/20');
go

-- Câu 2.8. Tạo Trigger ràng buộc ngày nhập viện phải sau ngày thành lập bệnh viện.
create trigger Trigger_NNhapVien_Sau_NgayThanhLap
on BenhNhan for insert, update
as
	if update(NgayNhap)
		if exists (select TenBenhNhan from inserted I, Khoa K where I.MaKhoa = K.MaKhoa and NgayNhap < NamThanhLap)
			begin
				raiserror ('Ngay nhap vien phai sau ngay thanh lap', 15, 1)
				rollback tran
			end
go

insert into BenhNhan values ('B0100', N'Nguyễn Thị C', '1990/4/15', N'Đau đầu', 'K04', '1992/11/23', '2019/11/20');
go

-- Câu 2.9. Hãy tạo mới một login tên là nhanvien và cấp các quyền trích chọn (select) hoặc thực hiện (execute) trên các bảng ảo và thủ tục đã 
-- tạo trong câu e, f, g.

-- Cách 1:
-- create login NhanVien
-- with password = '123'
-- go

-- Cách 2:
exec sp_addlogin 'NhanVien', '123'
go

-- Cách 1:
-- create user NhanVien for login NhanVien
-- go
-- Cách 2:
exec sp_adduser 'NhanVien'
go

-- Cấp quyền cho user, mỗi lần chỉ được một quyền hoặc ALL
use QLBV
grant select on CanBoKhoaNhi to NhanVien
grant exec on DSBN to NhanVien
grant exec on SLBN to NhanVien
go

-- Câu 2.10. Hãy login vào SQL server bằng login nhanvien và thực hiện các lệnh sau:
-- 	Hãy liệt kê các nhân viên khoa Nhi tuổi nhỏ hơn 50.
-- 	Hãy liệt kê các bệnh nhân khoa Nội.
-- 	Hãy cho biết số bệnh nhân khoa Nội.

-- Có thể đăng nhập vào cửa sổ login của SQL Server kiểm tra
EXECUTE AS USER = 'NhanVien'
go

-- Khi đã đăng nhập vào NhanVien thì 3 lệnh truy vấn bên dưới không thực hiện được
select * from BenhNhan BN, Khoa K
where BN.MaKhoa = K.MaKhoa and TenKhoa = N'Khoa Nhi' and DATEDIFF(year, NgaySinh, GETDATE()) < 50
go

select * from BenhNhan BN, Khoa K
where BN.MaKhoa = K.MaKhoa and TenKhoa = N'Khoa Nội'
go

select TenKhoa, count(*) as SoLuong 
from BenhNhan BN, Khoa K
where BN.MaKhoa = K.MaKhoa and TenKhoa = N'Khoa Nội'
group by TenKhoa
go

--================================= PHẦN NÂNG CAO =================================

/* THÊM RÀNG BUỘC VÀ XÓA RÀNG BUỘC
Có hai cách thêm ràng buộc dữ liệu:
1. Thêm trực tiếp vào cùng dòng trong tạo bảng:
Ví dụ:
	create table Khoa
	(
		MaKhoa char(3) primary key,
		TenKhoa nvarchar(100) not null,
		NamThanhLap datetime not null
	)
2. Thêm vào cuối dòng hoặc alter table:
Ví dụ 1:
	create table Khoa
	(
		MaKhoa char(3),
		TenKhoa nvarchar(100) not null,
		NamThanhLap datetime not null,
		constraint [pk_MaKhoa] primary key (MaKhoa) -- Trong đó pk_MaKhoa là tên khóa, có thể có hoặc không
	)
Ví dụ 2:
	alter table Khoa
	add constraint [pk_MaKhoa] primary key (MaKhoa)

LƯU Ý:
	Tên ràng buộc có thể có hoặc không
	Ví dụ 1:
		create table Khoa
		(
			MaKhoa char(3),
			TenKhoa nvarchar(100) not null,
			NamThanhLap datetime not null,
			primary key (MaKhoa)
		)
	Ví dụ 2:
		alter table Khoa
		add primary key (MaKhoa)
3. Xóa ràng buộc:
Ví dụ 1:
	alter table Khoa
	drop primary key (MaKhoa)
Ví dụ 2:
	alter table Khoa
	drop constraint [pk_MaKhoa]
*/

/* CÁC LOẠI RÀNG BUỘC DỮ LIỆU:
1. Ràng buộc khóa chính:
(Phần trên)
2. Ràng buộc khóa ngoại:
Ví dụ 1:
	create table NhanVien
	(
		MaNhanVien char(4) primary key,
		TenNhanVien nvarchar(100) not null,
		NgaySinh datetime not null,
		MaKhoa char(3) references Khoa(MaKhoa)
	)
Ví dụ 2:
	create table NhanVien
	(
		MaNhanVien char(4) primary key,
		TenNhanVien nvarchar(100) not null,
		NgaySinh datetime not null,
		MaKhoa char(3),
		constraint [fk_MaKhoa] foreign key (MaKhoa) references Khoa(MaKhoa)
	)
Ví dụ 3:
	alter table NhanVien
	add constraint [fk_MaKhoa] foreign key (MaKhoa) references Khoa(MaKhoa)
3. Ràng buộc duy nhất:
Lưu ý: Tự primary key đã ràng buộc duy nhất rồi nên ta chỉ thêm vào các cột không phải là khóa
Ví dụ 1:
	create table NhanVien
	(
		MaNhanVien char(4) primary key,
		TenNhanVien nvarchar(100) unique not null,
		NgaySinh datetime not null,
		MaKhoa char(3) references Khoa(MaKhoa)
	)
Ví dụ 2:
	create table NhanVien
	(
		MaNhanVien char(4) primary key,
		TenNhanVien nvarchar(100) not null,
		NgaySinh datetime not null,
		MaKhoa char(3),
		constraint [u_TenNhanVien] unique (TenNhanVien)
	)
Ví dụ 3:
	alter table NhanVien
	add constraint [u_TenNhanVien] unique (TenNhanVien)
4. Not null:
Ví dụ 1:
	create table Khoa
	(
		MaKhoa char(3) primary key,
		TenKhoa nvarchar(100) not null,
		NamThanhLap datetime not null
	)
Ví dụ 2:
	alter table Khoa
	MODIFY TenKhoa nvarchar(100) NOT NULL
5. Ràng buộc Miền giá trị:
Ví dụ 1:
	CREATE TABLE SINHVIEN
	(
		MASV INT IDENTITY(1,1),
		HO NVARCHAR(100),
		TEN NVARCHAR(100),
		NGAYSINH DATETIME,
		GIOITINH NVARCHAR(3) CHECK (GIOITINH IN (N'Nam', N'Nữ')),
		MAKHOA INT
	)
Ví dụ 2:
	CREATE TABLE SINHVIEN
	(
		MASV INT IDENTITY(1,1),
		HO NVARCHAR(100),
		TEN NVARCHAR(100),
		NGAYSINH DATETIME,
		GIOITINH NVARCHAR(3) DEFAULT N'Nữ',
		MAKHOA INT,
		CONSTRAINT [CHK_GIOITINH] CHECK (GIOITINH IN (N'Nam', N'Nữ'))
	)
Ví dụ 3:
	ALTER TABLE SINHVIEN
	ADD CONSTRAINT [CHK_GIOITINH] CHECK (GIOITINH IN (N'Nam', N'Nữ'))
6. Ràng buộc mặc định:
Ví dụ 1:
	CREATE TABLE SINHVIEN
	(
		MASV INT IDENTITY(1,1),
		HO NVARCHAR(100),
		TEN NVARCHAR(100),
		NGAYSINH DATETIME,
		GIOITINH NVARCHAR(3) DEFAULT N'Nữ',
		MAKHOA INT
	)
Ví dụ 2:
	ALTER TABLE SINHVIEN
	ADD CONSTRAINT [df_GIOITINH] DEFAULT N'Nữ' FOR GIOITINH
*/

-- NỘI DUNG ĐẾN ĐÂY LÀ HẾT, CÁC BẠN CÓ THỂ ĐỌC THÊM TẠI https://www.w3schools.com/sql/default.asp