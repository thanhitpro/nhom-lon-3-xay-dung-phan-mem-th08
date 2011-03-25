create database ESTORE
go
use ESTORE

create table NHASANXUAT
(
	MaNhaSanXuat int Identity(1,1) not null,
	TenNhaSanXuat nvarchar(30) not null,
	constraint PK_NHASANXUAT  primary key(MaNhaSanXuat)
)



create table BANGDIEM_KHOANGTANG
(
	MaBangDiem_KhoangTang int Identity(1,1) not null,
	Diem int  not null,
	KhoangTang int  not null
constraint PK_BANGDIEM_KHOANGTANG  primary key(MaBangDiem_KhoangTang)
)



create table CHITIETCONGNGHERAM
(
	MaChiTietCongNgheRAM	int Identity(1,1) not null,
	TenCongNgheRam	nvarchar(30) not null,
	HeSo	float  not null
constraint PK_CHITIETCONGNGHERAM  primary key(MaChiTietCongNgheRAM)
)


CREATE TABLE CHITIETBONHORAM
(
	MaChiTietBoNhoRAM	int Identity(1,1) not null,
	TenChiTietBoNhoRAM	nvarchar(30) not null,
	HeSo	float
constraint PK_CHITIETBONHORAM  primary key(MaChiTietBoNhoRAM)
)


CREATE TABLE CHITIETDONGRAM
(
	MaDongRAM	int identity(1,1) not null,
	MaChiTietBoNhoRAM	int not null,
	MaChiTietCongNgheRAM	int not null,
	TenDongRAM		nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGRAM  primary key(MaDongRAM),
	constraint FK_CHITIETDONGRAM_CHITIETCONGNGHERAM	foreign key (MaChiTietBoNhoRAM) references CHITIETCONGNGHERAM(MaChiTietCongNgheRAM),
	constraint FK_CHITIETDONGRAM_CHITIETBONHORAM	foreign key (MaChiTietCongNgheRAM) references CHITIETBONHORAM(MaChiTietBoNhoRAM),
	constraint FK_CHITIETDONGRAM_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGRAM_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)

CREATE TABLE CHITIETCONGNGHECPU
(
	MaChiTietCongNgheCPU	int Identity(1,1) not null,
	TenChiTietCongNgheCPU	nvarchar(30),
	HeSo	float
constraint PK_CHITIETCONGNGHECPU  primary key(MaChiTietCongNgheCPU)
)


CREATE TABLE CHITIETDONGCPU
(
	MaDongCPU	int identity(1,1) not null,
	MaChiTietCongNgheCPU	int not null,
	TenDongCPU		nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGCPU  primary key(MaDongCPU),
	constraint FK_CHITIETDONGCPU_CHITIETCONGNGHECPU	foreign key (MaChiTietCongNgheCPU) references CHITIETCONGNGHECPU(MaChiTietCongNgheCPU ),
	constraint FK_CHITIETDONGCPU_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGCPU_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)


CREATE TABLE CHITIETKICHTHUOCMANHINH
(
	MaChiTietKichThuocManHinh	int Identity(1,1) not null,
	TenChiTietKichThuocManHinh	nvarchar(30),
	HeSo	float
constraint PK_CHITIETKICHTHUOCMANHINH  primary key(MaChiTietKichThuocManHinh)
)


CREATE TABLE CHITIETDONGMANHINH
(
	MaDongManHinh	int identity(1,1) not null,
	MaChiTietKichThuocManHinh	int not null,
	TenDongManHinh		nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGMANHINH  primary key(MaDongManHinh),
	constraint FK_CHITIETDONGMANHINH_CHITIETKICHTHUOCMANHINH	foreign key (MaChiTietKichThuocManHinh) references CHITIETKICHTHUOCMANHINH(MaChiTietKichThuocManHinh ),
	constraint FK_CHITIETDONGMANHINH_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGMANHINH_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )	
)


CREATE TABLE CHITIETDUNGLUONGOCUNG
(
	MaChiTietDungLuongOCung	int Identity(1,1) not null,
	TenChiTietDungLuongOCung	nvarchar(30),
	HeSo	float
constraint PK_CHITIETDUNGLUONGOCUNG  primary key(MaChiTietDungLuongOCung)
)


CREATE TABLE CHITIETVONGQUAYOCUNG
(
	MaChiTietVongQuayOCung	int Identity(1,1) not null,
	TenChiTietVongQuayOCung	nvarchar(30),
	HeSo	float
constraint PK_CHITIETVONGQUAYOCUNG  primary key(MaChiTietVongQuayOCung)
)


CREATE TABLE CHITIETDONGOCUNG
(
	MaDongOCung	int identity(1,1) not null,
	MaChiTietVongQuayOCung	int not null,
	MaChiTietDungLuongOCung	int not null,
	TenDongOCung		nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGOCUNG  primary key(MaDongOCung),
	constraint FK_CHITIETDONGOCUNG_CHITIETDUNGLUONGOCUNG	foreign key (MaChiTietDungLuongOCung) references CHITIETDUNGLUONGOCUNG(MaChiTietDungLuongOCung ),
	constraint FK_CHITIETDONGOCUNG_CHITIETVONGQUAYOCUNG	foreign key (MaChiTietVongQuayOCung) references CHITIETVONGQUAYOCUNG(MaChiTietVongQuayOCung ),
	constraint FK_CHITIETDONGOCUNG_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGOCUNG_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)


CREATE TABLE CHITIETBONHOCARDDOHOA
(
	MaChiTietBoNhoCardDoHoa int Identity(1,1) not null,
	TenChiTietBoNhoCardDoHoa	nvarchar(30),
	HeSo	float
constraint PK_CHITIETBONHOCARDDOHOA primary key(MaChiTietBoNhoCardDoHoa )
)


CREATE TABLE CHITIETDONGCARDDOHOA
(
	MaDongCardDoHoa	int identity(1,1) not null,
	MaChiTietBoNhoCardDoHoa	int not null,
	TenDongCardDoHoa	nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGCARDDOHOA  primary key(MaDongCardDoHoa),
	constraint FK_CHITIETDONGCARDDOHOA_CHITIETBONHOCARDDOHOA	foreign key (MaChiTietBoNhoCardDoHoa) references CHITIETBONHOCARDDOHOA(MaChiTietBoNhoCardDoHoa ),
	constraint FK_CHITIETDONGCARDDOHOA_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGCARDDOHOA_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)



CREATE TABLE CHITIETDONGLOA
(
	MaDongLoa	int identity(1,1) not null,
	CoMicro	bit not null,
	TenDongDongLoa		nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGLOA  primary key(MaDongLoa),
	constraint FK_CHITIETDONGLOA_NHASANXUAT	foreign key (MaNhaSanXuat ) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGLOA_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang ) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)



CREATE TABLE CHITIETCACKHANANGODIAQUANG
(
	MaChiTietCacKhaNangODiaQuang	int Identity(1,1) not null,
	TenChiTietCacKhaNangODiaQuang	nvarchar(30),
	HeSo	float
constraint PK_CHITIETCACKHANANGODIAQUANG  primary key(MaChiTietCacKhaNangODiaQuang)
)


CREATE TABLE CHITIETDONGODIAQUANG
(
	MaDongODiaQuang	int identity(1,1) not null,
	MaChiTietCacKhaNangODiaQuang	int not null,
	TenDongODiaQuang		nvarchar(30),
	MaBangDiem_KhoangTang	int not null,
	MaNhaSanXuat	int not null,
	
	constraint PK_CHITIETDONGODIAQUANG  primary key(MaDongODiaQuang),
	constraint FK_CHITIETDONGODIAQUANG_CHITIETCACKHANANGODIAQUANG	foreign key (MaChiTietCacKhaNangODiaQuang)  references CHITIETCACKHANANGODIAQUANG(MaChiTietCacKhaNangODiaQuang ),
	constraint FK_CHITIETDONGODIAQUANG_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
	constraint FK_CHITIETDONGODIAQUANG_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)

CREATE TABLE CHITIETLOAIDANHGIA
(	MaLoaiDanhGia int identity (1,1) not null, 
	TenLoaiDanhGia nvarchar(30) not null,
	GiaTri  int not null, -- Giá trị  của loại đánh giá
	HeSo float,
	constraint PK_CHITIETLOAIDANHGIA  primary key(MaLoaiDanhGia)
)
CREATE TABLE DANHGIA
(
	MaDanhGia int identity (1,1) not null,

	TongDiem	int not null,  -- Từ tổng điểm và số người đánh giá => điểm trung bình => Mã Loại Đánh Giá
	SoNguoiDanhGia int not null,
	MaBangDiem_KhoangTang	int not null,
	constraint PK_DANHGIA  primary key(MaDanhGia),
	constraint FK_DANHGIA_BANGDIEM_KHOANGTANG	foreign key (MaBangDiem_KhoangTang) references BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang )
)




CREATE TABLE CHITIETDONGLAPTOP
(
	MaDongLapTop int identity (1,1) not null,
	TenChiTietDongLapTop nvarchar(30),
	MaDongRAM	int ,
	MaDongCPU	int,
	MaDongOCung int,
	MaDongManHinh int,	
	MaDongCardDoHoa int,
	MaDongLoa int,
	MaDongODiaQuang int,
--Thêm Vào
	MaDongCardMang int,	
	MaDongCardReader int,
	MaDongWebCam int,		
	MaDongPin int,
	MaHeDieuHanh int,
	MaChiTietTrongLuong int,	
--
	FingerprintReader bit,
	HDMI bit,
	SoLuongCongUSB int,
	MaNhaSanXuat int,
	MaDanhGia int,
	GiaBanHienHanh float, -- nhân 1000 VNĐ
	MoTaThem nvarchar(512),
	SoLuongNhap int,
	SoLuongConLai	int,
	ThoiGianBaoHanh int,
	HinhAnh		nvarchar(256),
	MauSac		nvarchar(30),

constraint PK_CHITIETDONGLAPTOP  primary key(MaDongLapTop),
	
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGRAM	foreign key (MaDongRAM)  references CHITIETDONGRAM (MaDongRAM),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGCPU	foreign key (MaDongCPU)  references CHITIETDONGCPU(MaDongCPU),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGManHinh	foreign key (MaDongManHinh)  references CHITIETDONGManHinh(MaDongManHinh),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGOCung	foreign key (MaDongOCung)  references CHITIETDONGOCung(MaDongOCung),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGCardDoHoa	foreign key (MaDongCardDoHoa)  references CHITIETDONGCardDoHoa(MaDongCardDoHoa),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGLoa	foreign key (MaDongLoa)  references CHITIETDONGLoa( MaDongLoa),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGODiaQuang	foreign key (MaDongODiaQuang)  references CHITIETDONGODiaQuang(MaDongODiaQuang),
	constraint FK_CHITIETDONGLAPTOP_DANHGIA	foreign key (MaDanhGia)  references DANHGIA(MaDanhGia),
	constraint FK_CHITIETDONGLAPTOP_NHASANXUAT	foreign key (MaNhaSanXuat) references NHASANXUAT(MaNhaSanXuat ),
)

--Thêm Vào

CREATE TABLE CHITIETDONGCARDMANG
(
	MaDongCardMang int identity(1,1)NOT NULL,
	MaNhaSanXuat int,
	MaBangDiem_KhoangTang int,
	MaChiTietLoaiKetNoiCardMang int,
	TenDongCardMang nvarchar(30)
)

CREATE TABLE CHITIETLOAIKETNOICARDMANG
(
	MaChiTietLoaiKetNoiCardMang int identity (1,1) NOT NULL,
	TenLoaiKetNoiCardMang nvarchar (30),
	HeSo float
)

CREATE TABLE CHITIETDONGCARDREADER
(
	MaDongCardReader int identity (1,1) NOT NULL,
	MaBangDiem_KhoangTang int,
	MaNhaSanXuat int,
	MaChiTietCongNgheCardReader int,
	TenDongCardReader nvarchar (30)
)

CREATE TABLE CHITIETCONGNGHECARDREADER
(
	MaChiTietCongNgheCardReader int identity (1,1) NOT NULL,
	TenCongNgheCardReader nvarchar (30),
	HeSo float	
)

CREATE TABLE CHITIETDONGWEBCAM
(
	MaDongWebCam int identity (1,1) NOT NULL,
	MaNhaSanXuat int,
	MaBangDiem_KhoangTang int,
	MaChiTietLoaiDoPhanGiaiWebCam int,
	TenDongWebCam nvarchar (30),
	DoPhanGiai float,
)

CREATE TABLE CHITIETLOAIDOPHANGIAIWEBCAM
(
	MaChiTietLoaiDoPhanGiaiWebCam  int identity (1,1) NOT NULL,
	TenChiTietLoaiDoPhanGiaiWebcam nvarchar (30),
	HeSo float
)

CREATE TABLE CHITIETDONGPIN
(	
	MaDongPin int identity (1,1) NOT NULL,	
	MaBangDiem_KhoangTang int,
	MaNhaSanXuat int,
	MaChiTietThoiLuongPin int,
	TenDongPin nvarchar(30),
	ThoiGianSuDung float -- đơn vị là hour
)

CREATE TABLE CHITIETTHOILUONGPIN
(
	MaChiTietThoiLuongPin int identity (1,1) NOT NULL,
	TenThoiLuongPin nvarchar (30),
	HeSo float
)

CREATE TABLE HEDIEUHANH
(
	MaHeDieuHanh int identity (1,1) NOT NULL,
	MaBangDiem_KhoangTang int,
	MaChiTietHeDieuHanh int,
	MaNhaSanXuat int
)

CREATE TABLE CHITIETHEDIEUHANH
(
	MaChiTietHeDieuHanh int identity (1,1) NOT NULL,
	TenHeDieuHanh nvarchar (30),
	HeSo float
)

CREATE TABLE CHITIETTRONGLUONG
(
	MaChiTietTrongLuong int identity (1,1) NOT NULL,
	MaChiTietLoaiTrongLuong int,
	GiaTriTrongLuong float,--Đơn vị kg
	MaBangDiem_KhoangTang int,
)

CREATE TABLE CHITIETLOAITRONGLUONG
(
	MaChiTietLoaiTrongLuong int identity (1,1) NOT NULL,
	TenLoaiTrongLuong nvarchar(30),
	GiaTriTrongLuong int, -- Đơn vị kg 
	--Nếu giá trị nguyên Giá trị trong lượng của bảng CHITIETTRONGLUONG = GiaTriTrongLuong của bảng này thì 
	--CHITIETTRONGLUONG đó thuộc CHITIETLOAITRONGLUONG này
	HeSo float
)

--TẤT CẢ CÁC KHÓA CHÍNH--


ALTER TABLE CHITIETDONGCARDMANG
ADD CONSTRAINT PK_CHITIETDONGCARDMANG
PRIMARY KEY (MaDongCardMang)

ALTER TABLE CHITIETLOAIKETNOICARDMANG
ADD CONSTRAINT PK_CHITIETLOAIKETNOICARDMANG
PRIMARY KEY (MaChiTietLoaiKetNoiCardMang)

ALTER TABLE CHITIETDONGCARDREADER
ADD CONSTRAINT PK_CHITIETDONGCARDREADER
PRIMARY KEY (MaDongCardReader)

ALTER TABLE CHITIETCONGNGHECARDREADER
ADD CONSTRAINT PK_CHITIETCONGNGHECARDREADER
PRIMARY KEY (MaChiTietCongNgheCardReader)

ALTER TABLE CHITIETDONGWEBCAM
ADD CONSTRAINT PK_CHITIETDONGWEBCAM
PRIMARY KEY (MaDongWebCam)

ALTER TABLE CHITIETLOAIDOPHANGIAIWEBCAM
ADD CONSTRAINT PK_CHITIETLOAIDOPHANGIAIWEBCAM
PRIMARY KEY (MaChiTietLoaiDoPhanGiaiWebCam)

ALTER TABLE CHITIETDONGPIN
ADD CONSTRAINT PK_CHITIETDONGPIN
PRIMARY KEY (MaDongPin)

ALTER TABLE CHITIETTHOILUONGPIN
ADD CONSTRAINT PK_CHITIETTHOILUONGPIN
PRIMARY KEY (MaChiTietThoiLuongPin)

ALTER TABLE HEDIEUHANH
ADD CONSTRAINT PK_HEDIEUHANH
PRIMARY KEY (MaHeDieuHanh)

ALTER TABLE CHITIETHEDIEUHANH
ADD CONSTRAINT PK_CHITIETHEDIEUHANH
PRIMARY KEY (MaChiTietHeDieuHanh)

ALTER TABLE CHITIETTRONGLUONG
ADD CONSTRAINT PK_CHITIETTRONGLUONG
PRIMARY KEY (MaChiTietTrongLuong)

ALTER TABLE CHITIETLOAITRONGLUONG
ADD CONSTRAINT PK_CHITIETLOAITRONGLUONG
PRIMARY KEY (MaChiTietLoaiTrongLuong)

--TẤT CẢ CÁC KHÓA NGOẠI--

-- KHÓA NGOẠI TRONG BẢNG "CHITIETDONGLAPTOP"
ALTER TABLE CHITIETDONGLAPTOP
ADD CONSTRAINT FK_MaDongCardMangLAPTOP
FOREIGN KEY (MaDongCardMang)
REFERENCES CHITIETDONGCARDMANG(MaDongCardMang)

ALTER TABLE CHITIETDONGLAPTOP
ADD CONSTRAINT FK_MaDongCardReaderLAPTOP
FOREIGN KEY (MaDongCardReader)
REFERENCES CHITIETDONGCARDREADER(MaDongCardReader)

ALTER TABLE CHITIETDONGLAPTOP
ADD CONSTRAINT FK_MaDongWebCamLAPTOP
FOREIGN KEY (MaDongWebCam)
REFERENCES CHITIETDONGWEBCAM(MaDongWebCam)

ALTER TABLE CHITIETDONGLAPTOP
ADD CONSTRAINT FK_MaDongPinLAPTOP
FOREIGN KEY (MaDongPin)
REFERENCES CHITIETDONGPIN(MaDongPin)

ALTER TABLE CHITIETDONGLAPTOP
ADD CONSTRAINT FK_MAHEDIEUHANHLAPTOP
FOREIGN KEY (MaHeDieuHanh)
REFERENCES HEDIEUHANH(MaHeDieuHanh)

ALTER TABLE CHITIETDONGLAPTOP
ADD CONSTRAINT FK_CHITIETTRONGLUONGLAPTOP
FOREIGN KEY (MaChiTietTrongLuong)
REFERENCES CHITIETTRONGLUONG(MaChiTietTrongLuong)
-------------------------------------------
-- KHÓA NGOẠI CÁC BẢNG "LOẠI..."

--CHITIETDONGCARDMANG
ALTER TABLE CHITIETDONGCARDMANG
ADD CONSTRAINT FK_NHASANXUATCARDMANG
FOREIGN KEY (MaNhaSanXuat)
REFERENCES NHASANXUAT(MaNhaSanXuat)

ALTER TABLE CHITIETDONGCARDMANG
ADD CONSTRAINT FK_BANGDIEM_KHOANGTANGCARDMANG
FOREIGN KEY (MaBangDiem_KhoangTang)
REFERENCES BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang)

ALTER TABLE CHITIETDONGCARDMANG
ADD CONSTRAINT FK_CHITIETLOAIKETNOICARDMANG
FOREIGN KEY (MaChiTietLoaiKetNoiCardMang)
REFERENCES CHITIETLOAIKETNOICARDMANG(MaChiTietLoaiKetNoiCardMang)
------------------------------------------------------------

--CHITIETDONGCARDREADER--
ALTER TABLE CHITIETDONGCARDREADER
ADD CONSTRAINT FK_NHASANXUATCARDREADER
FOREIGN KEY (MaNhaSanXuat)
REFERENCES NHASANXUAT(MaNhaSanXuat)

ALTER TABLE CHITIETDONGCARDREADER
ADD CONSTRAINT FK_BANGDIEM_KHOANGTANGCARDREADER
FOREIGN KEY (MaBangDiem_KhoangTang)
REFERENCES BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang)

ALTER TABLE CHITIETDONGCARDREADER
ADD CONSTRAINT FK_CHITIETCONGNGHECARDREADER
FOREIGN KEY (MaChiTietCongNgheCardReader)
REFERENCES CHITIETCONGNGHECARDREADER(MaChiTietCongNgheCardReader)

--CHITIETDONGWEBCAM--
ALTER TABLE CHITIETDONGWEBCAM
ADD CONSTRAINT FK_NHASANXUATWEBCAM
FOREIGN KEY (MaNhaSanXuat)
REFERENCES NHASANXUAT(MaNhaSanXuat)

ALTER TABLE CHITIETDONGWEBCAM
ADD CONSTRAINT FK_BANGDIEM_KHOANGTANGWEBCAM
FOREIGN KEY (MaBangDiem_KhoangTang)
REFERENCES BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang)

ALTER TABLE CHITIETDONGWEBCAM
ADD CONSTRAINT FK_CHITIETLOAIDOPHANGIAIWEBCAM
FOREIGN KEY (MaChiTietLoaiDoPhanGiaiWebCam)
REFERENCES CHITIETLOAIDOPHANGIAIWEBCAM(MaChiTietLoaiDoPhanGiaiWebCam)
--CHITIETDONGPIN--
ALTER TABLE CHITIETDONGPIN
ADD CONSTRAINT FK_NHASANXUATPIN
FOREIGN KEY (MaNhaSanXuat)
REFERENCES NHASANXUAT(MaNhaSanXuat)

ALTER TABLE CHITIETDONGWEBCAM
ADD CONSTRAINT FK_BANGDIEM_KHOANGTANGPIN
FOREIGN KEY (MaBangDiem_KhoangTang)
REFERENCES BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang)

ALTER TABLE CHITIETDONGPIN
ADD CONSTRAINT FK_CHITIETTHOILUONGPIN
FOREIGN KEY (MaChiTietThoiLuongPin)
REFERENCES CHITIETTHOILUONGPIN(MaChiTietThoiLuongPin)
--HEDIEUHANH
ALTER TABLE HEDIEUHANH
ADD CONSTRAINT FK_NHASANXUATHEDIEUHANH
FOREIGN KEY (MaNhaSanXuat)
REFERENCES NHASANXUAT(MaNhaSanXuat)

ALTER TABLE HEDIEUHANH
ADD CONSTRAINT FK_BANGDIEM_KHOANGTANGPHEDIEUHANH
FOREIGN KEY (MaBangDiem_KhoangTang)
REFERENCES BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang)

ALTER TABLE HEDIEUHANH
ADD CONSTRAINT FK_CHITIETHEDIEUHANH
FOREIGN KEY (MaChiTietHeDieuHanh)
REFERENCES CHITIETHEDIEUHANH(MaChiTietHeDieuHanh)
--TRONGLUONG--

ALTER TABLE CHITIETTRONGLUONG
ADD CONSTRAINT FK_CHITIETLOAITRONGLUONG
FOREIGN KEY (MaChiTietLoaiTrongLuong)
REFERENCES CHITIETLOAITRONGLUONG(MaChiTietLoaiTrongLuong)

ALTER TABLE CHITIETTRONGLUONG
ADD CONSTRAINT FK_CHITIETLOAITRONGLUONG_BANGDIEM_KHOANGTANG
FOREIGN KEY (MaBangDiem_KhoangTang)
REFERENCES BANGDIEM_KHOANGTANG(MaBangDiem_KhoangTang)

-------------------------------------------

use ESTORE

-- Thêm nhà Sản Xuất
insert into NHASANXUAT(TenNhaSanXuat) values (N'Apple')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Sony')
insert into NHASANXUAT(TenNhaSanXuat) values (N'el')
insert into NHASANXUAT(TenNhaSanXuat) values (N'NVIDIA')
insert into NHASANXUAT(TenNhaSanXuat) values (N'LG')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Acer')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Samsung')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Toshiba')
insert into NHASANXUAT(TenNhaSanXuat) values (N'IBM-Lenovo')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Asus')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Compaq')
insert into NHASANXUAT(TenNhaSanXuat) values (N'HP')
insert into NHASANXUAT(TenNhaSanXuat) values (N'DELL')
insert into NHASANXUAT(TenNhaSanXuat) values (N'MSI')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Axioo')
insert into NHASANXUAT(TenNhaSanXuat) values (N'ATI')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Sound Max')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Creative')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Logitech')
insert into NHASANXUAT(TenNhaSanXuat) values (N'NIKON')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Genius')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Canon')
insert into NHASANXUAT(TenNhaSanXuat) values (N'KINGMAX')
insert into NHASANXUAT(TenNhaSanXuat) values (N'KINGSTON')
insert into NHASANXUAT(TenNhaSanXuat) values (N'AMD')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Western')
insert into NHASANXUAT(TenNhaSanXuat) values (N'A-DATA')
insert into NHASANXUAT(TenNhaSanXuat) values (N'ZADEZ')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Razer')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Microsoft')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Mitsumi')


-- Thêm Loai San Phẩm
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (10 ,2 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (20 ,4 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values ( 10 ,2 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values ( 15, 3)
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (15,3 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values ( 5, 1)
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (10 ,2 )
/*insert into BANGDIEM_KHOANGTANG(TenLoaiSanPham,Diem, KhoangTang) values (N'',  , )
insert into BANGDIEM_KHOANGTANG(TenLoaiSanPham,Diem, KhoangTang) values (N'',  , )
insert into BANGDIEM_KHOANGTANG(TenLoaiSanPham,Diem, KhoangTang) values (N'',  , )
insert into BANGDIEM_KHOANGTANG(TenLoaiSanPham,Diem, KhoangTang) values (N'',  , )
insert into BANGDIEM_KHOANGTANG(TenLoaiSanPham,Diem, KhoangTang) values (N'',  , )
insert into BANGDIEM_KHOANGTANG(TenLoaiSanPham,Diem, KhoangTang) values (N'',  , )*/


--Thêm CHITIETCONGNGHERAM
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'DDR3', 1.5  )
/*insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'',   )*/

--Thêm CHITIETBONHORAM
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'4Gb', 2.5  )
/*insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'',   )*/



go
--Thêm CHITIETDONGRAM
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,1 ,N'4GB DDRAM3 KINGMAX' ,1 , 23   )
/*insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , ,    )*/


--Thêm CHITIETCONGNGHECPU
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core i7', 2.5  )
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core i5',  1.5 )
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core i3',  1 )
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core 2 dual',  0 )


--Thêm CHITIETDONGCPU
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 1,N'EL Core i7-950 (3.06GHz)' ,2 , 3)
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 1,N'el® Core™ i7-2600 (3.4GHz)' ,2 ,3 )
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 2,N'EL Core i5-760 (2.8GHz)' ,2 ,3 )
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat)
 values ( 2,N'el® Core™ i5-2300 (2.8GHz)' ,2 ,3 )
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 2,N'el® Core™ i5-2500 (3.3GHz)' , 2,3 )
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 2,N'el® Core™ i5-2500K (3.3GHz)' ,2 , 3)
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 3,N'EL Core i3-540 (3.06GHz)' ,2 ,3)
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 3,N'EL Core i3-560 (3.33GHz)' ,2 ,3 )
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 3,N'EL Core i3-560 (3.33GHz)' , 2,3 )
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat)
 values ( 4,N'EL Core2 Duo-E7500' ,2 ,3 )


--Thêm CHITIETKICHTHUOCMANHINH
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'<=10',1   )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'10->13.3', 1.5  )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'13.3->15', 2  )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'>15',  2.5 )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'LED', 0  )
/*insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'',   )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'',   )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'',   )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'',   )
insert into CHITIETKICHTHUOCMANHINH(TenCHITIETKICHTHUOCMANHINH,HeSo) values (N'',   )*/

--Thêm CHITIETDONGMANHINH
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'11.6 inches HD WLED' , 3,6 )
/*insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )*/



--Thêm CHITIETDUNGLUONGOCUNG
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'<= 160GB ',1   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'từ 160GB  đến bằng 320GB	', 1.5  )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'từ 320GB đến bằng 500GB',2   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'từ 500GB đến bằng 1TB', 2.5  )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'lớn hơn 1TB',3   )
/*insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'',   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'',   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'',   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'',   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'',   )*/


--Thêm CHITIETVONGQUAYOCUNG
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'Vòng quay  5400rpm  ', 1  )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'Vòng quay  7200rpm ',1.5   )
/*insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'',   )*/

--Thêm CHITIETDONGOCUNG
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 2, 2,N'Sony HDD 320GB 7200rpm' ,4 ,2 )
/*insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( , ,N'' , , )*/



--Thêm CHITIETBONHOCARDDOHOA
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'Nhỏ hơn 512MB',  1 )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'từ 512 MB đến bằng 1 GB',   1.5)
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'Lớn hơn 1GB',   2)
/*insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'từ GB đến bằng GB',   )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'',   )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'',   )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'',   )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'',   )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'',   )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'',   )*/



--Thêm CHITIETDONGCARDDOHOA

insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,N'NDIVIA' ,5 ,5 )
/*insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )*/



--Thêm CHITIETDONGLOA

insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,N'Creative' ,6 , 18)
/*insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )*/


--Thêm CHITIETCACKHANANGODIAQUANG
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'Có khả năng ghi đĩa ', 2  )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'Chỉ đọc được DVD ',  1 )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'Đọc được cả Bluray ', 1.5  )
/*insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'',   )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'',   )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'',   )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'',   )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'',   )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'',   )*/


--Thêm CHITIETDONGODIAQUANG
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODiaQuang, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 2,N'DVD-16X SAMSUNG' ,7 ,5 )
/*insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODia, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( ,N'' , , )*/

--CHITIETCARDMANG

insert into CHITIETLOAIKETNOICARDMANG
(	TenLoaiKetNoiCardMang ,HeSo )
values (N'Có wifi ',1 )
insert into CHITIETLOAIKETNOICARDMANG
(	TenLoaiKetNoiCardMang ,HeSo )
values (N'Có kết nối bluetooth ',0 )
insert into CHITIETLOAIKETNOICARDMANG
(	TenLoaiKetNoiCardMang ,HeSo )
values (N'Có wifi + Bluetooth',1.5 )

insert into CHITIETDONGCARDMANG
( 	MaChiTietLoaiKetNoiCardMang ,	TenDongCardMang, MaBangDiem_KhoangTang, MaNhaSanXuat  )
values (1 ,N'1 ',1 ,1)



insert into CHITIETCONGNGHECARDREADER
(TenCongNgheCardReader ,HeSo 	)
values (N'MMC ', 1)
insert into CHITIETCONGNGHECARDREADER
(TenCongNgheCardReader ,HeSo 	)
values (N'MS ', 1.5)
insert into CHITIETCONGNGHECARDREADER
(TenCongNgheCardReader ,HeSo 	)
values (N'SD', 2)
insert into CHITIETCONGNGHECARDREADER
(TenCongNgheCardReader ,HeSo 	)
values (N'XD', 2.5)


insert into CHITIETDONGCARDREADER
(MaChiTietCongNgheCardReader ,	TenDongCardReader,MaBangDiem_KhoangTang ,	MaNhaSanXuat )
values ( 1,N' 1',1 ,1)


insert into CHITIETLOAIDOPHANGIAIWEBCAM
(TenChiTietLoaiDoPhanGiaiWebcam ,HeSo )
values (N' Nhỏ hơn hoặc bằng 1 MP',1 )
insert into CHITIETLOAIDOPHANGIAIWEBCAM
(TenChiTietLoaiDoPhanGiaiWebcam ,HeSo )
values (N'Lớn hơn 1MP nhỏ bằng 3MP',1.5 )
insert into CHITIETLOAIDOPHANGIAIWEBCAM
(TenChiTietLoaiDoPhanGiaiWebcam ,HeSo )
values (N'Lớn hơn 3MP nhỏ bằng 8MP',2 )
insert into CHITIETLOAIDOPHANGIAIWEBCAM
(TenChiTietLoaiDoPhanGiaiWebcam ,HeSo )
values (N'Lớn hơn 8MP',2.5)

insert into CHITIETDONGWEBCAM
(	MaChiTietLoaiDoPhanGiaiWebCam ,	TenDongWebCam, DoPhanGiai ,	MaBangDiem_KhoangTang ,MaNhaSanXuat)
values ( 1,N'1 ', 1, 1,1)



insert into CHITIETTHOILUONGPIN
(	TenThoiLuongPin ,	HeSo )
values (N'Nhỏ hơn hoặc bằng 2 giờ ', 1 )
insert into CHITIETTHOILUONGPIN
(	TenThoiLuongPin ,	HeSo )
values (N'Lớn hơn 2h nhỏ bằng 5 giờ', 1 )
insert into CHITIETTHOILUONGPIN
(	TenThoiLuongPin ,	HeSo )
values (N'Lớn hơn 5 giờ', 1 )

insert into CHITIETDONGPIN
(MaChiTietThoiLuongPin ,	TenDongPin,ThoiGianSuDung, MaBangDiem_KhoangTang ,	MaNhaSanXuat)
values ( 1,N'1',1 ,1 , 1)

insert into CHITIETHEDIEUHANH
(TenHeDieuHanh ,	HeSo )
values (N'Win home ', 1 )
insert into CHITIETHEDIEUHANH
(TenHeDieuHanh ,	HeSo )
values (N'Win professional ', 1.5 )
insert into CHITIETHEDIEUHANH
(TenHeDieuHanh ,	HeSo )
values (N'Win Ultimate ', 2 )

insert into HEDIEUHANH
(MaChiTietHeDieuHanh,MaBangDiem_KhoangTang, MaNhaSanXuat )
values ( 1,1 ,1 )

insert into CHITIETLOAITRONGLUONG
(TenLoaiTrongLuong ,GiaTriTrongLuong ,HeSo )
values (N'Nhỏ hơn hoặc 1KG', 0, 2.5 )
insert into CHITIETLOAITRONGLUONG
(TenLoaiTrongLuong,GiaTriTrongLuong ,HeSo )
values (N'Lớn hơn ,bằng 1KG nhỏ  2KG' ,1,2 )
insert into CHITIETLOAITRONGLUONG
(TenLoaiTrongLuong,GiaTriTrongLuong ,HeSo )
values (N'Lớn hơn,bằng 2KG nhỏ 3KG' ,2, 1.5 )
insert into CHITIETLOAITRONGLUONG
(TenLoaiTrongLuong,GiaTriTrongLuong ,HeSo )
values (N'Lớn hơn,bằng 3KG nhỏ 4KG' ,3,1 )
insert into CHITIETLOAITRONGLUONG
(TenLoaiTrongLuong,GiaTriTrongLuong ,HeSo )
values (N'Lớn hơn,bằng 4KG nhỏ 5KG' ,4,0 )
insert into CHITIETLOAITRONGLUONG
(TenLoaiTrongLuong,GiaTriTrongLuong ,HeSo )
values (N'Lớn hơn,bằng 5KG nhỏ 6KG' ,5,0 )


insert into CHITIETTRONGLUONG
(	MaChiTietLoaiTrongLuong ,	GiaTriTrongLuong, MaBangDiem_KhoangTang )
values (1 ,1 ,1 )


--Thêm 6 cái của Luyến ở đây


--Thêm DANHGIA
insert into DANHGIA
(	TongDiem,	SoNguoiDanhGia, MaBangDiem_KhoangTang)
values ( 1000, 500, 1)

insert into CHITIETLOAIDANHGIA
(TenLoaiDanhGia, GiaTri,	HeSo )
values (N'Nhỏ hơn hoặc 1*', 0, 0)
insert into CHITIETLOAIDANHGIA
(TenLoaiDanhGia,	GiaTri,	HeSo )
values (N'Lớn hơn,bằng 1* nhỏ 2*', 1, 0.5)
insert into CHITIETLOAIDANHGIA
(TenLoaiDanhGia,	GiaTri,	HeSo )
values (N'Lớn hơn,bằng 2* nhỏ 3*', 2, 1)
insert into CHITIETLOAIDANHGIA
(TenLoaiDanhGia,	GiaTri,	HeSo )
values (N'Lớn hơn,bằng 3* nhỏ 4*', 3, 1.5)
insert into CHITIETLOAIDANHGIA
(TenLoaiDanhGia,	GiaTri ,	HeSo )
values (N'Lớn hơn,bằng 4* nhỏ 5*', 4, 2)
insert into CHITIETLOAIDANHGIA
(TenLoaiDanhGia,	GiaTri ,	HeSo )
values (N'= 5KG', 5, 2.5)

--Thêm CHITIETDONGLAPTOP


insert into CHITIETDONGLAPTOP
(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
	MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
	MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
	MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
	HinhAnh		,	MauSac	
)
values (N'ACER Aspire 4745 352G32Mn 041', 1, 1, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,2,6,1,10.454,N'ko có',50,09,12,N'images/1.png',N'Màu Đen' )


insert into CHITIETDONGLAPTOP
(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
	MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
	MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
	MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
	HinhAnh		,	MauSac	
)
values (N'LAPTOP LENOVO S10 - 3c ', 1, 2, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,2,9,1,6.599,N'ko có',30,19,12,N'images/2.png',N'Màu Đen đỏ' )

insert into CHITIETDONGLAPTOP
(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
	MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
	MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
	MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
	HinhAnh		,	MauSac	
)
values (N'LAPTOP SONY VGN - CF112FX ', 1, 4, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,2,9,1,23.700,N'ko có',20,10,12,N'images/3.png',N'Màu Đen' )

insert into CHITIETDONGLAPTOP
(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
	MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
	MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
	MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
	HinhAnh		,	MauSac	
)
values (N'DELL Inspiron 14R N4030-JM1W74', 1, 3, 1, 1, 1, 1, 1, 1, 1,1,1,1,1,1,1,2,9,1,11.399,N'ko có',40,15,12,N'images/4.png',N'Màu Đen ' )