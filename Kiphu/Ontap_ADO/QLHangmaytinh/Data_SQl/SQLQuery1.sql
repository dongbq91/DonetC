use QLHMT
go

create table Category (
	Maloai nchar(10) not null primary key,
	Tenloai nvarchar(30)
)
create table Product(
	Mahang nchar(10) not null primary key,
	Tenhang nvarchar(30),
	Ngaynhap date,
	slcon int
)
alter table Product add Nhasanxuat nvarchar(30)
ALTER TABLE Product alter COLUMN Ngaynhap datetime
ALTER TABLE Product add Ngaynhap datetime
insert into Category values('L1','Laptop')
insert into Category values('L2','May tinh bang')
insert into Category values('L3','Destop')

insert into Product values('H6','Samsung',10,'MVP','10/21/2020')
select * from Product

