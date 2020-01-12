use master
go

--drop database QLSV_3

CREATE DATABASE QLSV_3 ON 
(
	NAME = QLSV,
	FILENAME = 'D:\OneDrive\Thang\HOCTAP\2019-2020\HKI\HQTCSDL\Lab\QLSV3.MDF',
	SIZE = 10 MB,
	MAXSIZE = 50 MB,
	FILEGROWTH = 5 MB
) 
LOG ON 
(
	NAME = QLSV_LOG,
	FILENAME = 'D:\OneDrive\Thang\HOCTAP\2019-2020\HKI\HQTCSDL\Lab\QLSV3_LOG.LDF',
	SIZE = 5 MB,
	MAXSIZE = 25 MB,
	FILEGROWTH = 5 MB
)
GO

use QLSV_3
go

create table Khoa
(
	MaKhoa nvarchar(6),
	TenKhoa nvarchar(30),
	constraint pk_Khoa primary key (MaKhoa)
)
go

create table SinhVien
(
	MaSo int,
	HoTen nvarchar(50),
	NgaySinh datetime,
	GioiTinh bit, --0: Nam, 1: Nữ
	DiaChi nvarchar(50) null,
	DienThoai int null,
	MaKhoa nvarchar(6),
	constraint pk_SinhVien primary key (MaSo)
)
go

alter table SinhVien
	add constraint fk_SinhVien foreign key (MaKhoa) references Khoa(MaKhoa);
go

create table Mon
(
	MaMH nvarchar(6),
	TenMH nvarchar(50),
	SoTiet int,
	constraint pk_Mon primary key (MaMH)
)
go

create table KetQua
(
	MaSo int,
	MaMH nvarchar(6),
	Diem tinyint,
	constraint pk_KetQua primary key (MaSo, MaMH),
	constraint fk_KetQua_MaSo foreign key (MaSo) references SinhVien(MaSo),
	constraint fk_KetQua_MaMH foreign key (MaMH) references Mon(MaMH)
)
go

insert into Khoa values ('CNTT', N'Công nghệ thông tin')
insert into Khoa values ('LH', N'Luật học')
insert into Khoa values ('SH', N'Công nghệ sinh học')
insert into Khoa values ('NL', N'Nông lâm')
insert into Khoa values ('QTKD', N'Quản trị kinh doanh')
select * from Khoa
go

insert into Mon values ('MLN1', N'Triết học Mác-Lênin', 45)
insert into Mon values ('MLN2', N'Kinh tế chính trị', 30)
insert into Mon values ('TTHCM', N'Tư tưởng Hồ Chí Minh', 30)
insert into Mon values ('CNXHKH', N'Chủ nghĩa xã hội khoa học', 30)
insert into Mon values ('LSD', N'Lịch sử Đảng', 30)
select * from Mon
go

--delete from SinhVien
set dateformat dmy
insert into SinhVien values (1610207, N'La Quốc Thắng', '5/7/1998', 0, N'KTX tỉnh', 987610260, 'CNTT')
insert into SinhVien values (1610208, N'Nguyễn Văn A', '6/6/1998', 0, N'KTX tỉnh', 987610261, 'LH')
insert into SinhVien values (1610209, N'Trần Thị B', '7/5/1998', 1, N'KTX tỉnh', 987610262, 'SH')
insert into SinhVien values (1610210, N'Lê Ngọc C', '8/4/1998', 1, N'KTX tỉnh', 987610263, 'NL')
insert into SinhVien values (1610211, N'Vũ Ngọc D', '9/3/1998', 1, N'KTX tỉnh', 987610264, 'QTKD')
insert into SinhVien values (1610212, N'Phạm Anh E', '10/2/1998', 0, N'KTX tỉnh', 987610265, 'CNTT')
select * from SinhVien
go

insert into KetQua values (1610207, 'MLN1', 10)
insert into KetQua values (1610207, 'TTHCM', 9)
insert into KetQua values (1610207, 'LSD', 8)
insert into KetQua values (1610208, 'MLN2', 7)
insert into KetQua values (1610208, 'LSD', 6)
insert into KetQua values (1610208, 'CNXHKH', 5)
insert into KetQua values (1610209, 'MLN1', 4)
insert into KetQua values (1610209, 'MLN2', 2)
insert into KetQua values (1610209, 'CNXHKH', 0)
insert into KetQua values (1610210, 'CNXHKH', 6)
insert into KetQua values (1610210, 'TTHCM', 5)
insert into KetQua values (1610210, 'LSD', 4)
insert into KetQua values (1610211, 'LSD', 6)
insert into KetQua values (1610211, 'MLN1', 9)
insert into KetQua values (1610211, 'MLN2', 7)
insert into KetQua values (1610212, 'LSD', 2)
insert into KetQua values (1610212, 'CNXHKH', 3)
insert into KetQua values (1610212, 'MLN2', 7)
select * from KetQua
go