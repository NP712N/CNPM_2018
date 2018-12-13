use master 
if not exists (select* from Sysdatabases where name ='QUANLYCACDAILY')
Create database QUANLYCACDAILY
go 
use QUANLYCACDAILY

Create table DINHMUC(
MaDinhMuc char(9) constraint PK_MaDinhMuc Primary Key,
CapDaiLy char(3),
NoiDungDinhMuc nvarchar(max))

Create table DAILY(
MaDaiLy char(9) constraint PK_MaDaiLy primary key,
MaDinhMuc char (9) constraint FK_MaDinhMuc foreign key (MaDinhMuc) references DINHMUC(MaDinhMuc),
MaHopDong char(9),
NgayLap Date default Getdate(),
CMND char(9),
HoTenChuDaiLy nvarchar(20),
NgaySinh date,
CapDaiLy char(3),
TenDaiLy nvarchar(20),
NoiDung nvarchar(max))

Create table UUDAI(
MaUuDai char(9) constraint PK_MaUuDai primary key,
TenUuDai nvarchar(20),
NgayBatDau date default getdate(),
NgayKetThuc date,
CapDaiLy char(3),
PhanTram float)

Create table CHITIETUUDAI(
MaDaiLy char(9) references DAILY(MaDaiLy) not null,
MaUuDai char(9) references UUDAI(MaUuDai) not null,
primary key(MaDaiLy,MaUuDai))

Create table HANGHOA(
MaHangHoa char (9) constraint PK_MaHangHoa primary key,
TenMatHang nvarchar(20),
DonGia int,
SoLuongCon int)

Create table DONHANG(
MaDonHang char(9) constraint PK_MaDonHang primary key,
MaDaiLy char(9) constraint FK_MaDaiLyDH foreign key (MaDaiLy) references DAILY(MaDaiLy),
NgayDangKy Date default Getdate())

Create table PHIEUXUAT(
MaPhieuXuat char(9) constraint PK_PhieuXuat primary key,
NgayXuat date default getdate(),
ThanhTien float)

Create table CHITIETHANGHOAXUAT(
MaPhieuXuat char(9) references PHIEUXUAT(MaPhieuXuat) not null,
MaHangHoa char(9) references HANGHOA(MaHangHoa) not null,
primary key (MaPhieuXuat, MaHangHoa),
SoLuong int)

Create table HOADON(
MaHoaDon char(9) constraint PK_MaHoaDon primary key,
MaDonHang char(9) constraint FK_MaDonHangHD foreign key(MaDonHang) references DONHANG(MaDonHang),
MaPhieuXuat char(9) constraint FK_MaPhieuXuatHD foreign key (MaPhieuXuat) references PHIEUXUAT(MaPhieuXuat),
NgayLap date default Getdate(),
ThanhTien float)

Create table PHIEUTHU(
MaPhieuThu char(9) constraint PK_MaPhieuThu primary key,
MaHoaDon char(9) constraint FK_MaHoaDonPT foreign key(MaHoaDon) references HOADON(MaHoaDon),
NgayLapPhieu date default getdate(),
SoTienDaThu float)

Create table NODAILY(
MaNoDaiLy char(9) constraint PK_MaNoDaiLy primary key,
MaDaiLy char(9) constraint FK_MaDaiLyNo foreign key (MaDaiLy) references DAILY(MaDaiLy),
MaPhieuThu char(9) constraint FK_MaPhieuThuNo foreign key(MaPhieuThu) references PHIEUTHU(MaPhieuThu),
TienNo float)

Create table BAOCAODOANHTHU(
MaBaoCaoDoanhThu char(9) constraint PK_MaBaoCaoDoanhThu primary key,
MaDaiLy char(9) constraint FK_MaDaiLyBCDT foreign key (MaDaiLy) references DAILY(MaDaiLy),
NgayLap date default getdate(),
DenNgay date,
TongDoanhThu float)

Create table BAOCAOCONGNO(
MaBaoCaoCongNo char(9) constraint PK_MaBaoCaoCongNo primary key,
MaDaiLy char(9) constraint FK_MaDaiLyBCCN foreign key (MaDaiLy) references DAILY(MaDaiLy),
NgayLap date default getdate(),
DenNgay date,
TongNo float)