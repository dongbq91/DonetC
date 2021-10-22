use master
go
create database QLTiemThuoc
go
use QLTiemThuoc
go
create table KhachHang( MaKhacHang nchar(10) primary key,
						TenKhachHang nvarchar(50),
						SDT nchar(11),
						DiaChi nvarchar(100),
						GhiChu nvarchar(100)
						)
create table NhaCungCap (MaNCC nchar(10) primary key, 
						TenNCC nvarchar(50),
						DienThoai nchar(11),
						DiaChi nvarchar(100),
						GhiChu nvarchar(100)
						)
create table NhanVien (MaNhanVien nchar(10) primary key,
						TenNV nvarchar(50), 
						DienThoai nchar(11),
						DiaChi nvarchar(50),
						TaiKhoan nchar(50),
						MatKhau int, 
						Quyen nchar, 
						GhiChu nvarchar(50)
						)
create table LoaiThuoc(MaLoaiThuoc nchar(10) primary key,
					   LoaiThuoc nvarchar(50))
create table DonViTinh(MaDonViTinh nchar(10) primary key,
					   TenDVT nvarchar(50),
					   GhiChu nvarchar(50)
					   )
create table Thuoc( MaThuoc nchar(10) primary key,
					TenThuoc nvarchar(50),
					MaDonViTinh nchar(10),
					SoLuongCon int,
					GiaMua int,
					GiaBan int,
					MaLoaiThuoc nchar(10),
					CONSTRAINT F_THUOC_MALOAITHUOC foreign key (MaLoaiThuoc) REFERENCES LoaiThuoc(MaLoaiThuoc),
					CONSTRAINT F_THUOC_DVT foreign key (MaDonViTinh) REFERENCES DonViTinh(MaDonViTinh)
					)
create table BangGia( MaBangGia nchar(10) not null,
					  MaThuoc nchar(10) not null,
					  MaDonViTinh nchar(10) not null,
					  SoLuong int,
					  GiaMua int,
					  GiaBan int,
					CONSTRAINT PK_BangGia_THUOC primary key (MaBangGia,MaThuoc),
					CONSTRAINT FK_BangGia_DVT foreign key (MaDonViTinh) REFERENCES DonViTinh(MaDonViTinh)
					)
create table DonHangBan (MaDHBan nchar(10) primary key, 
						 NgayDH date,
						 MaNhanVien nchar(10),
						 MaKhacHang nchar(10),
						 TongGiaTri int,
						 CONSTRAINT F_DonBanHang_KhachHang foreign key (MaKhacHang) references KhachHang(MaKhacHang),
						 CONSTRAINT F_DonBanHang_NhanVien foreign key (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
						 )
create table ChiTietDonHangBan (MaChiTietBan nchar(10) not null,
								MaDHBan nchar(10) not null,
								MaThuoc nchar(10) not null,
								GiaMua int,
								GiaBan int,
								SoLuong int,
								ThanhTien int,
							CONSTRAINT PK_CTDonBanHang_THUOC primary key (MaChiTietBan,MaThuoc),
							CONSTRAINT FK_CTDonBanHang_THUOC foreign key (MaThuoc) references Thuoc(MaThuoc),
							CONSTRAINT F_CTDonBanHang_DH foreign key(MaDHBan) references DonHangBan(MaDHBan)
								)
create table DonHangMua (MaDHMua nchar(10) primary key ,
						 NgayDH date,
						 MaNhanVien nchar(10),
						 MaNCC nchar(10),
						 TongGiaTri int
						 CONSTRAINT F_DonBanMua_NhaCungCap foreign key (MaNCC) references NhaCungCap(MaNCC),
						 CONSTRAINT F_DonBanMua_NhanVien foreign key (MaNhanVien) REFERENCES NhanVien(MaNhanVien)
						 )
create table ChiTietDonHangMua (MaChiTietMua nchar(10),
								MaDHMua nchar(10), 
								MaThuoc nchar(10), 
								SoLuong int,
								GiaMua int,
								ThanhTien int,
						CONSTRAINT PK_CTDonBanMua_THUOC primary key (MaChiTietMua,MaThuoc),
						CONSTRAINT F_CTDonBanMua_THuoc foreign key(MaThuoc) references Thuoc(MaThuoc),	
						CONSTRAINT F_CTDonBanMua_DH foreign key(MaDHMua) references DonHangMua(MaDHMua)		
								)

