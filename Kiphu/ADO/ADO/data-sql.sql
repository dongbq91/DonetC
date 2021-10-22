create database QLNS
go
use QLNS
go

create table Departments(
	DepartmentID int not null primary key,
	DepartmentName nvarchar(30),
	Description nvarchar(30)
)
create table Employees (
	EmployeeID int not null primary key,
	DepartmentID int,
	fullName nvarchar(30) ,
	Gender char(10),
	Birthday datetime,
	Address nvarchar(30),
	constraint Fk_ID foreign key (DepartmentID) references Departments (DepartmentID)
)

insert into Departments values('1','IT','Hoc dot')
insert into Departments values('2','BA','Hoc qua dot')
insert into Departments values('3','Hacker','Hoc ngu')