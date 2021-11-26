create database QuanLyHangHoa
go
use QuanLyHangHoa
go
create table DanhMuc(
	MaDanhMuc INT identity primary key,
	TenDanhMuc nvarchar(100))
	go
create table QuiCach(
	MaQuiCach int identity primary key,
	TenQuiCach nvarchar(100))
	go
	create table DonViTinh(
	MaDonViTinh int identity primary key,
	TenDonViTinh nvarchar(100))
	go
	create table LoiNhuan(
	GiaTriLoiNhuan float)
	go
	create tabel NhanVien(
	MaNhanVien int identity primary key,
	TenNhanVien nvarchar(100))
	go
	create table MatHang(
	MaMatHang int identity,
	TenMatHang nvarchar(100))
	go
	Create table NhaCungCap(
	MaNhaCungCap int identity primary key,
	TenNhaCungCap nvarchar(100))
	go
	create table HangHoa(
	MaHangHoa int identity primary key,
	MaMatHang int  foreign key references MatHang(MaMatHang) not null,
	MaNhaCungCap int  foreign key references NhaCungCap(MaNhaCungCap) not null,
	MaQuiCach int  foreign key references QuiCach(MaQuiCach) not null,
	MaDonViTinh int  foreign key references DonViTinh(MaDonViTinh) not null,
	TrangThai bit,)
	go
	Create table PhieuNhapHang(
	MaPhieuNhap int identity primary,
	MaHangHoa int foreign key references HangHoa(MaHangHoa),
	MaNhanVien int foreign key references NhanVien(MaNhanVien),
	SoLuong int,
	GiaNhap float
	)
	go
