use master 
go
create database QLHang
go
use QLHang
go

create table LoaiHang (
	Maloai nchar(10) not null primary key,
	Tenloai nvarchar(30)
)
create table Hang(
	Mahang nchar(10) not null primary key,
	Tenhang nvarchar(30),
	Dongia int,
	Maloai nchar(10),
	constraint Fk_Hang foreign key (Maloai) references LoaiHang(Maloai)
)

insert into LoaiHang values('H1','Loai xin')
insert into LoaiHang values('H2','Loai binh thuong')
insert into LoaiHang values('H3','Loai vjp')