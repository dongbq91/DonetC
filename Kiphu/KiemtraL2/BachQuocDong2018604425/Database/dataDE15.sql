create database DE15
go
use DE15
go



create table Khachhang(
	Makhachhang nchar(10) not null primary key,
	Tenkhachhang nvarchar(30),
	Socmnd int,
	Sophong int,
	gioitinh nchar(10),
	Ngaycheckin datetime,
)
