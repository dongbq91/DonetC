use master 
go
create database De1
go
Use De1
go

create table Hanghoa(
	MaHang nchar(10) not null primary key,
	TenHang nvarchar(30),
	LuuY nvarchar(10),
	NgaySanXuat date,
	SoLuong int
)
alter table Hanghoa alter COLUMN NgaySanXuat date
insert into Hanghoa values('H1','Keo','De vo','10/11/2020',10)
