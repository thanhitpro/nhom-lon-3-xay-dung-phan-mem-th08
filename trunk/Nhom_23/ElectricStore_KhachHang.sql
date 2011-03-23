use ESTORE
go
create table KHACHHANG
(
	MaKhachHang int identity(1,1) not null,
	HoVaTenLot	nvarchar(30) not null,
	TenKhachHang	nvarchar(10) not null,
	GioiTinhNam	bit not null,
	CMND		char(9),
	constraint PK_KHACHHANG primary key (MaKhachHang)
)
go
insert into KHACHHANG values(N'Trần Trung',N'Kiên', 1, '024787878')
insert into KHACHHANG values(N'Nguyễn Duy',N'Khương', 1, '024787899')
insert into KHACHHANG values(N'Trần Tấn',N'Kiệt', 1, '024709078')
insert into KHACHHANG values(N'Phan Phước',N'Lâm', 1, '024754789')
insert into KHACHHANG values(N'Đỗ Minh',N'Khương', 1, '024654778')
insert into KHACHHANG values(N'Vũ Đình',N'Khôi', 1, '024565689')



