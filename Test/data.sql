use master
go
create database QLSV
go
use QLSV
go
-- DONGBQ-PC
-- Data Source=DONGBQ-PC;Initial Catalog=QLSV;Integrated Security=True
create table Lop (
	Malop nchar(10) not null primary key,
	Tenlop nvarchar(20) not null ,
	Phong nchar(10),
)
select * from Lop

-- Data Source=DONGBQ-PC;Initial Catalog=QLMT;Integrated Security=True