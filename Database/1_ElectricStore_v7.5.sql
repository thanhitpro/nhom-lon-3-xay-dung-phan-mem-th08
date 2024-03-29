create database ESTORE
go
use ESTORE

create table NHASANXUAT
(
	MaNhaSanXuat int Identity(1,1) not null,
	TenNhaSanXuat nvarchar(30) not null,
	constraint PK_NHASANXUAT  primary key(MaNhaSanXuat)
)

create table NGUOIDUNG
(
	MaNguoiDung int Identity(1,1) not null,
	TenDangNhap varchar(15) not null,
	MatKhau varchar(15) not null
 constraint PK_NGUOIDUNG primary key(MaNguoiDung)
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
	constraint FK_CHITIETDONGRAM_CHITIETCONGNGHERAM	foreign key (MaChiTietBoNhoRAM) references CHITIETBONHORAM(MaChiTietBoNhoRAM),
	constraint FK_CHITIETDONGRAM_CHITIETBONHORAM	foreign key (MaChiTietCongNgheRAM) references CHITIETCONGNGHERAM(MaChiTietCongNgheRAM) ,
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
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGManHinh	foreign key (MaDongManHinh)  references CHITIETDONGMANHINH(MaDongManHinh),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGOCung	foreign key (MaDongOCung)  references CHITIETDONGOCUNG(MaDongOCung),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGCARDDOHOA	foreign key (MaDongCardDoHoa)  references CHITIETDONGCARDDOHOA(MaDongCardDoHoa),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGLoa	foreign key (MaDongLoa)  references CHITIETDONGLoa( MaDongLoa),
	constraint FK_CHITIETDONGLAPTOP_CHITIETDONGODIAQUANG	foreign key (MaDongODiaQuang)  references CHITIETDONGODIAQUANG(MaDongODiaQuang),
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

-- update table khách hàng ngày 28/03/2011

create table NGHENGHIEP
(
	MaNgheNghiep int identity(1,1),
	TenNgheNghiep nvarchar(30),
	constraint PK_NGHENGHIEP    primary key (MaNgheNghiep)
)

create table MUCDICHSUDUNG
(
	MaMucDichSuDung int identity(1,1),
	TenMucDichSuDung nvarchar(30),
	constraint  PK_MUCDICHSUDUNG   primary key (MaMucDichSuDung)
)

create table DOTUOI
(
	MaDoTuoi int identity(1,1),
	TenDoTuoi nvarchar(30),
	constraint  PK_DOTUOI   primary key (MaDoTuoi)
)

create table TINHTHANH
(
	MaTinhThanh int identity(1,1),
	TenTinhThanh nvarchar(30),
	constraint PK_TINHTHANH     primary key (MaTinhThanh)
)

create table KHACHHANG
(
	MaKhachHang int identity(1,1),
	MaNgheNghiep int not null,
	MaMucDichSuDung int not null,
	MaDoTuoi	int not null,
	GioiTinhNam	bit not null,
	MaTinhThanh	int not null,
	constraint  PK_KHACHHANG primary key (MaKhachHang),
	constraint	FK_KHACHHANG_NGHENGHIEP	foreign key (MaNgheNghiep) references NGHENGHIEP(MaNgheNghiep),
	constraint	FK_KHACHHANG_MUCDICHSUDUNG	foreign key	(MaMucDichSuDung)	references MUCDICHSUDUNG (MaMucDichSuDung),
	constraint	FK_KHACHHANG_DOTUOI	foreign key	(MaDoTuoi)	references DOTUOI (MaDoTuoi),
	constraint	FK_KHACHHANG_TINHTHANH	foreign key	(MaTinhThanh)	references TINHTHANH(MaTinhThanh)
)
create table GIAODICH
(
	MaGiaoDich int identity(1,1),
	MaKhachHang int not null,
	MaDongLaptop int not null,
	NgayMua		datetime not null,
	constraint PK_GIAODICH    primary key (MaGiaoDich),
	constraint FK_GIAODICH_KHACHHANG foreign key (MaKhachHang) references KHACHHANG(MaKhachHang),
	constraint FK_GIAODICH_CHITINHDONGLAPTOP foreign key (MaDongLapTop) references CHITIETDONGLAPTOP(MaDongLapTop)
)


-- Version 7.3

alter table CHITIETDONGLAPTOP
add Deleted bit

alter table CHITIETDONGLAPTOP
add NgayNhap datetime

