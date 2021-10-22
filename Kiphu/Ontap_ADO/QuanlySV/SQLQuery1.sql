use master
go
create database QLSVV1
go
use QLSVV1
go

create table Khoa (
	Makhoa nchar(10) not null primary key,
	Tenkhoa nvarchar(30)
)
create table Sinhvien(
	Masv nchar(10) not null primary key,
	Tensv nvarchar(30),
	Ngaysinh datetime,
	gioitinh nchar(10),
	Diem int,
	Makhoa nchar(10),
	constraint Fk_sv foreign key (Makhoa) references Khoa(Makhoa)
)

insert into Khoa values('K1','CNTT')
insert into Khoa values('K2','KTPM')
insert into Khoa values('K3','KHMT')

insert into Sinhvien values('SV1','Dong','9/1/2000','Nam',10,'K1')

select * from Khoa
select * from Sinhvien