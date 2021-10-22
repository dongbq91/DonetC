use QLBHADO
go

create table HangSX (
	MaHang char(10) not null primary key,
	TenHang nvarchar(30),
	Diachi nvarchar(30),
	sodt int
)
create table SanPham (
	MaSP char(10) not null primary key,
	TenSP nvarchar(30),
	Mausac nvarchar(30),
	Soluong int,
	giaban int,
	MaHang char(10),
	constraint Fk_SP foreign key (MaHang) references HangSX(MaHang)
)

insert into  HangSX values ('H1','Vjp-So1','Ha Noi',098768998)
insert into  HangSX values ('H2','Vjp-So2','Ha tay',098764532)
insert into  HangSX values ('H3','Vjp-So3','Ha Nam,',098743232)

insert into Sanpham values ('SP1','Banh','Do',10,1000,'H1')