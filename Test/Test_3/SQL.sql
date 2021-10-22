use master
go
create database QLsach
go
use Qlsach 
go
create table Theloai(
	matheloai nchar(10) primary key,
	tentheloai nvarchar(30),
)
create table Sach(
	masach nchar(10) primary key,
	tensach nvarchar(30),
	sotrang int,
	matheloai nchar(10),
	constraint f_k foreign key (matheloai) references Theloai(matheloai)
)
insert into Theloai values('L1','ABC')
insert into Theloai values('L2','DDD')
insert into Theloai values('L3','MMMM')
