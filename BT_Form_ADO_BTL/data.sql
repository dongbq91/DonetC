use master
go
create database QLBH
go
use QLBH
go
create table Hangsx (
	Mahang nchar(10) primary key ,
	Tenhang nvarchar(30),
	diachi nvarchar(30),
	sodt nchar(10)
)
create table Sanpham (
	Masp nchar(10)primary key,
	Tensp nvarchar(30),
	mausac nvarchar(10),
	soluong int ,
	giaban money,
	Mahang nchar(10),
	constraint f_Bq foreign key (Mahang) references Hangsx(Mahang)
)
insert into Hangsx values ('D1', N'BBQ',N'Hà Nội','09090909')
insert into Hangsx values ('D2', N'CCQ',N'Hà Tây','12345666')
insert into Hangsx values ('D3', N'DDQ',N'Hà Nam','55533245')
insert into Sanpham values ('SP1', N'Máy tính ',N'Hồng',10,1000000,'D1')
insert into Sanpham values ('SP2', N'Camera ',N'Đen',19,800000,'D2')
insert into Sanpham values ('SP3', N'Pen',N'ĐỎ',90,8800000,'D3')
select * from Hangsx
select * from Sanpham