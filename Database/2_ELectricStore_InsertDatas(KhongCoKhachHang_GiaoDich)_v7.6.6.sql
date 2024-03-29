use ESTORE

--Nhà Sản Xuất
--1
insert into NHASANXUAT(TenNhaSanXuat) values (N'Apple')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Sony')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Gateway')
insert into NHASANXUAT(TenNhaSanXuat) values (N'NVIDIA')
insert into NHASANXUAT(TenNhaSanXuat) values (N'LG')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Acer')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Samsung')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Toshiba')
insert into NHASANXUAT(TenNhaSanXuat) values (N'IBM-Lenovo')
--10
insert into NHASANXUAT(TenNhaSanXuat) values (N'Asus')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Compag')
insert into NHASANXUAT(TenNhaSanXuat) values (N'HP')
insert into NHASANXUAT(TenNhaSanXuat) values (N'DELL')
insert into NHASANXUAT(TenNhaSanXuat) values (N'MSI')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Axioo')
insert into NHASANXUAT(TenNhaSanXuat) values (N'ATI')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Sound Max')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Creative')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Logitech')
--20
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
--30
insert into NHASANXUAT(TenNhaSanXuat) values (N'Microsoft')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Mitsumi')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Intel')
insert into NHASANXUAT(TenNhaSanXuat) values (N'Colorvis')

-- Nguoi dung
insert into NGUOIDUNG(TenDangNhap, MatKhau) values ('admin' ,'123456' )

-- Loại Sản Phẩm
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (10 ,2 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (20 ,4 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (10 ,2 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (15, 3)
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (15,3 )
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (5, 1)
insert into BANGDIEM_KHOANGTANG(Diem, KhoangTang) values (10 ,2 )


--Chi tiết công nghệ Ram
insert into CHITIETCONGNGHERAM(TenCongNgheRAM,HeSo) values (N'DDR3', 1.5  )

--Chi tiết bộ nhớ Ram
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'4Gb', 2.5  )
insert into CHITIETBONHORAM(TenChiTietBoNhoRAM,HeSo) values (N'2Gb', 1.5  )

--Thêm CHITIETDONGRAM
insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
	TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,1 ,N'4GB DDRAM3 KINGMAX' ,1 , 23   )
	--VỊ TRÍ THÊM
	insert into CHITIETDONGRAM(MaChiTietBoNhoRAM,MaChiTietCongNgheRAM,
		TenDongRAM	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 2,1 ,N'2GB DDRAM3 KINGMAX' ,1 , 23   )


--Chi tiết công nghệ CPU
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core i7', 2.5  )
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core i5',  1.5 )
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core i3',  1 )
insert into CHITIETCONGNGHECPU(TenChiTietCongNgheCPU,HeSo) values (N'Core 2 dual',  0 )

--Thêm CHITIETDONGCPU
--1
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 1,N'Intel Core i7-950 (3.06GHz)' ,2 , 32)
--2
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 1,N'Intel® Core™ i7-2600 (3.4GHz)' ,2 ,32 )
--3
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 2,N'Intel Core i5-760 (2.8GHz)' ,2 ,32 )
--4
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat)
values ( 2,N'Intel® Core™ i5-2300 (2.8GHz)' ,2 ,32 )
--5
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 2,N'Intel® Core™ i5-2500 (3.3GHz)' , 2,32 )
--6
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 2,N'Intel® Core™ i5-2500K (3.3GHz)' ,2 , 32)
--7s
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 3,N'Intel Core i3-540 (3.06GHz)' ,2 ,32)
--8
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 3,N'Intel Core i3-560 (3.33GHz)' ,2 ,32 )
--9
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
values ( 3,N'Intel Core i3-560 (3.33GHz)' , 2,32 )
--10
insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat)
values ( 4,N'Intel Core2 Duo-E7500' ,2 ,32 )
	-- VỊ TRÍ THÊM
	--11
	insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
	values ( 2,N'Intel Core i5-460 (2.53GHz)' ,2 ,32 )	
	--12
	insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
	values ( 3,N'Intel Core i3-370 (2.4GHz)' ,2 ,32 )	
	--13
	insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
	values ( 4,N'Intel Core 2 Duo 1.86GHz - 6M' ,2 ,32 )	
	--14
	insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
	values ( 4,N'Intel Core 2 Duo 1.4GHz - 3M' ,2 ,32 )	
	--15
	insert into CHITIETDONGCPU(MaChiTietCongNgheCPU,TenDongCPU	,MaBangDiem_KhoangTang,MaNhaSanXuat) 
	values ( 4,N'Intel Core 2 Duo 2.13GHz - 3M' ,2 ,32 )	

--Chi tiết dung lượng ổ cứng
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'<= 160GB ',1   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'từ 160GB  đến bằng 320GB	', 1.5  )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'từ 320GB đến bằng 500GB',2   )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'từ 500GB đến bằng 1TB', 2.5  )
insert into CHITIETDUNGLUONGOCUNG(TenCHITIETDUNGLUONGOCUNG,HeSo) values (N'lớn hơn 1TB',3   )


--Chi tiết vòng quay ở cứng
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'Vòng quay  5400rpm  ', 1  )
insert into CHITIETVONGQUAYOCUNG(TenCHITIETVONGQUAYOCUNG,HeSo) values (N'Vòng quay  7200rpm ',1.5   )

--Thêm CHITIETDONGOCUNG
insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
	TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 2, 2,N'HDD 320GB 7200rpm' ,3 ,2 )
	--VI TRÍ THÊM
	insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
		TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1, 4,N'HDD 640GB 5400rpm' ,4 ,2 )
	insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
			TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1, 4,N'HDD 500GB 5400rpm' ,4 ,2 )
	insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
			TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1, 3,N'HDD 320GB 5400rpm' ,3 ,7 )
	insert into CHITIETDONGOCUNG(MaChiTietVongQuayOCung, MaChiTietDungLuongOCung, 
			TenDongOCung,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1, 3,N'HDD 250GB 5400rpm' ,2 ,7 )


--Chi tiết kích thước màn hình
insert into CHITIETKICHTHUOCMANHINH(TenChiTietKichThuocManHinh,HeSo) values (N'<=10',1   )
insert into CHITIETKICHTHUOCMANHINH(TenChiTietKichThuocManHinh,HeSo) values (N'10->13.3', 1.5  )
insert into CHITIETKICHTHUOCMANHINH(TenChiTietKichThuocManHinh,HeSo) values (N'13.3->15', 2  )
insert into CHITIETKICHTHUOCMANHINH(TenChiTietKichThuocManHinh,HeSo) values (N'>15',  2.5 )
insert into CHITIETKICHTHUOCMANHINH(TenChiTietKichThuocManHinh,HeSo) values (N'LED', 0  )

--Thêm CHITIETDONGMANHINH
insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
	TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'11.6 inches HD WLED' , 3,6 )
	-- VỊ TRÍ THÊM
	insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
		TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'13.3 inches HD WLED' , 3,2 )
	insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
			TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 4,N'15.5 inches WXGA' , 3,2 )
	insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
			TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'15.6 inches HD TruBrite® LED ' , 3,7 )
	insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
			TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'13.3 LED ' , 3,1 )
	insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
			TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'15.4 LED ' , 3,1 )
	--7
	insert into CHITIETDONGMANHINH(MaChiTietKichThuocManHinh,
			TenDongManHinh	,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 5,N'14.1 LED ' , 3,1 )

--Chi tiết bộ nhớ Card Đồ họa
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'Nhỏ hơn 512MB',  1 )
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'từ 512 MB đến bằng 1 GB',   1.5)
insert into CHITIETBONHOCARDDOHOA(TenCHITIETBONHOCARDDOHOA,HeSo) values (N'Lớn hơn 1GB',   2)

--Thêm CHITIETDONGCARDDOHOA
insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
	TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,N'NDIVIA' ,5 ,5 )
	--VỊ TRÍ THÊM 
	insert into CHITIETDONGCARDDOHOA(MaChiTietBoNhoCardDoHoa, 
		TenDongCardDoHoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 3,N'GMA' ,5 ,5 )

--Thêm CHITIETDONGLOA
insert into CHITIETDONGLOA(CoMicro, 
	TenDongDongLoa,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,N'Creative' ,6 , 18)

--Chi tiết các khả năng ổ đĩa quang
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'Có khả năng ghi đĩa ', 2  )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'Chỉ đọc được DVD ',  1 )
insert into CHITIETCACKHANANGODIAQUANG(TenCHITIETCACKHANANGODIAQUANG,HeSo) values (N'Đọc được cả Bluray ', 1.5  )

--Thêm CHITIETDONGODIAQUANG
insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODiaQuang, 
	TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 2,N'DVD-16X SAMSUNG READER' ,7 ,5 )
	--VỊ TRÍ THÊM
	insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODiaQuang, 
		TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 1,N'DVD-16X SAMSUNG WRITER' ,7 ,5 )
	insert into CHITIETDONGODIAQUANG(MaChiTietCacKhaNangODiaQuang, 
		TenDongODiaQuang,MaBangDiem_KhoangTang,MaNhaSanXuat) values ( 3,N'BWU-100A ' ,7 ,5 )
	
--Chi tiết card mạng
insert into CHITIETLOAIKETNOICARDMANG
(	TenLoaiKetNoiCardMang ,HeSo )
values (N'Có wifi ',1 )
insert into CHITIETLOAIKETNOICARDMANG
(	TenLoaiKetNoiCardMang ,HeSo )
values (N'Có kết nối bluetooth ',0 )
insert into CHITIETLOAIKETNOICARDMANG
(	TenLoaiKetNoiCardMang ,HeSo )
values (N'Có wifi + Bluetooth',1.5 )

-- thêm CHITIETDONGCARDMANG
insert into CHITIETDONGCARDMANG
( 	MaChiTietLoaiKetNoiCardMang ,	TenDongCardMang, MaBangDiem_KhoangTang, MaNhaSanXuat  )
values (1 ,N'1 ',1 ,1)
	--VỊ TRÍ THÊM
	insert into CHITIETDONGCARDMANG
	( 	MaChiTietLoaiKetNoiCardMang ,	TenDongCardMang, MaBangDiem_KhoangTang, MaNhaSanXuat  )
	values (3 ,N'3 ',1 ,2)

--Chi tiết công nghệ CardReader
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

--thêm CHITIETDONGCARDREADER
insert into CHITIETDONGCARDREADER
(MaChiTietCongNgheCardReader ,	TenDongCardReader,MaBangDiem_KhoangTang ,	MaNhaSanXuat )
values ( 1,N' 1',1 ,1)

--Chi tiết độ phân giải WebCam
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

--thêm CHITIETDONGWEBCAM
insert into CHITIETDONGWEBCAM
(	MaChiTietLoaiDoPhanGiaiWebCam ,	TenDongWebCam, DoPhanGiai ,	MaBangDiem_KhoangTang ,MaNhaSanXuat)
values ( 1,N'Colorvis 2005', 1, 1, 33)
	--VỊ TRÍ THÊM
	insert into CHITIETDONGWEBCAM
	(	MaChiTietLoaiDoPhanGiaiWebCam ,	TenDongWebCam, DoPhanGiai ,	MaBangDiem_KhoangTang ,MaNhaSanXuat)
	values ( 2,N'Colorvis (3.0)', 3, 1, 33)
	insert into CHITIETDONGWEBCAM
	(	MaChiTietLoaiDoPhanGiaiWebCam ,	TenDongWebCam, DoPhanGiai ,	MaBangDiem_KhoangTang ,MaNhaSanXuat)
	values ( 3,N'Logitech C510', 5, 1, 19)	
	insert into CHITIETDONGWEBCAM
	(	MaChiTietLoaiDoPhanGiaiWebCam ,	TenDongWebCam, DoPhanGiai ,	MaBangDiem_KhoangTang ,MaNhaSanXuat)
	values ( 4,N'Logitech Portable Webcam C905', 9, 1, 19)

--Chi tiết thời lượng Pin
insert into CHITIETTHOILUONGPIN
(	TenThoiLuongPin ,	HeSo )
values (N'Nhỏ hơn hoặc bằng 2 giờ ', 1 )
insert into CHITIETTHOILUONGPIN
(	TenThoiLuongPin ,	HeSo )
values (N'Lớn hơn 2h nhỏ bằng 5 giờ', 1 )
insert into CHITIETTHOILUONGPIN
(	TenThoiLuongPin ,	HeSo )
values (N'Lớn hơn 5 giờ', 1 )

--thêm CHITIETDONGPIN	
insert into CHITIETDONGPIN
(MaChiTietThoiLuongPin ,	TenDongPin,ThoiGianSuDung, MaBangDiem_KhoangTang ,	MaNhaSanXuat)
values ( 1,N'3 giờ',3 ,1 , 1)
	--VỊ TRÍ THÊM
	insert into CHITIETDONGPIN
	(MaChiTietThoiLuongPin ,	TenDongPin,ThoiGianSuDung, MaBangDiem_KhoangTang ,	MaNhaSanXuat)
	values ( 2,N'4 giờ ',4 ,1 , 1)
	insert into CHITIETDONGPIN
	(MaChiTietThoiLuongPin ,	TenDongPin,ThoiGianSuDung, MaBangDiem_KhoangTang ,	MaNhaSanXuat)
	values ( 3,N'5 giờ ',5 ,1 , 1)

--Chi tiết hệ điều hành
insert into CHITIETHEDIEUHANH
(TenHeDieuHanh ,	HeSo )
values (N'Win 7 Home Premium ', 1 )
insert into CHITIETHEDIEUHANH
(TenHeDieuHanh ,	HeSo )
values (N'Win 7 Professional ', 1.5 )
insert into CHITIETHEDIEUHANH
(TenHeDieuHanh ,	HeSo )
values (N'Win 7 Ultimate ', 2 )
	--VỊ TRÍ THÊM
	insert into CHITIETHEDIEUHANH
	(TenHeDieuHanh ,	HeSo )
	values (N'Apple MacOS X 10.6 ', 2 )

--thêm HEDIEUHANH
insert into HEDIEUHANH
(MaChiTietHeDieuHanh,MaBangDiem_KhoangTang, MaNhaSanXuat )
values ( 1,1 ,1 )
	--VỊ TRÍ THÊM
	insert into HEDIEUHANH
	(MaChiTietHeDieuHanh,MaBangDiem_KhoangTang, MaNhaSanXuat )
	values ( 2,1 ,1 )
	insert into HEDIEUHANH
	(MaChiTietHeDieuHanh,MaBangDiem_KhoangTang, MaNhaSanXuat )
	values ( 3,1 ,1 )
	insert into HEDIEUHANH
	(MaChiTietHeDieuHanh,MaBangDiem_KhoangTang, MaNhaSanXuat )
	values ( 4,1 ,1 )

--Chi tiết trọng lượng
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

--thêm CHITIETTRONGLUONG
insert into CHITIETTRONGLUONG
(	MaChiTietLoaiTrongLuong ,GiaTriTrongLuong,	MaBangDiem_KhoangTang )
values (1  ,1 , 2)
	--VỊ TRÍ THÊM
	insert into CHITIETTRONGLUONG
	(	MaChiTietLoaiTrongLuong ,  GiaTriTrongLuong,MaBangDiem_KhoangTang )
	values (2  ,2.5,2 )
	insert into CHITIETTRONGLUONG
	(	MaChiTietLoaiTrongLuong ,	GiaTriTrongLuong, MaBangDiem_KhoangTang )
	values (3 ,3.5, 1 )
	insert into CHITIETTRONGLUONG
	(	MaChiTietLoaiTrongLuong ,	GiaTriTrongLuong, MaBangDiem_KhoangTang )
	values (4 ,4,6 )
	insert into CHITIETTRONGLUONG
	(	MaChiTietLoaiTrongLuong ,GiaTriTrongLuong,	MaBangDiem_KhoangTang )
	values (5  ,5,6 )
	insert into CHITIETTRONGLUONG
	(	MaChiTietLoaiTrongLuong ,GiaTriTrongLuong,	 MaBangDiem_KhoangTang )
	values (6  ,6, 6 )

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

-- DÒNG ACER
insert into CHITIETDONGLAPTOP
(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
	MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
	MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
	MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
	HinhAnh		,	MauSac	, NgayNhap, Deleted
)
values (N'ACER Aspire 4745 352G32Mn 041',1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,2,6,1,10454,N'ko có',50,09,12,N'image/1.png',N'Màu Đen','12/20/2010', 0 )

--DÒNG LENOVO
insert into CHITIETDONGLAPTOP
(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
	MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
	MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
	MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
	HinhAnh		,	MauSac	, NgayNhap, Deleted
)
values (N'LAPTOP LENOVO S10 - 3c ',1,2,1,1,1,1,1,1,1,1,1,1,1,1,1,2,9,1,16599,N'ko có',30,19,12,N'image/2.png',N'Màu Đen đỏ','12/20/2010', 0 )

--DÒNG DELL
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'Dell Inspiron 14R N4030-JM1W74',1,3,1,1,1,1,1,1,1,1,1,1,1,1,1,2,9,1,11399,N'ko có',40,15,12,N'image/4.png',N'Màu Đen ','12/20/2010', 0 )
	
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'Dell Inspiron 15R-N5010',1,4,3,4,1,1,1,2,1,2,2,1,2,1,1,3,13,1,18440,N'ko có',40,15,12,N'image/16.png',N'Màu Đen ','12/20/2010', 0 )
	
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'Dell Inspiron 15R-N5010',1,4,3,4,1,1,1,2,1,2,2,1,2,1,1,3,13,1,18440,N'ko có',40,15,12,N'image/17.png',N'Màu Đen ','12/20/2010', 0 )
	
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'Dell VOSTRO 1014',1,15,1,7,1,1,1,2,1,2,2,1,2,0,1,3,13,1,11440,N'ko có',40,15,12,N'image/16.png',N'Màu Đen ','12/20/2010', 0 )
	
	-- DÒNG SONY
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'SONY VAIO S131FM/S',1,11,2,2,2,1,1,2,1,2,2,1,2,1,1,3,2,1,25418,N'ko có',40,40,1,N'image/5.png',N'Màu đen','12/20/2010',0)

	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'LAPTOP SONY VGN - CF112FX ',1,4,1,1,1,1,1,1,1,1,1,1,1,1,1,2,9,1,23700,N'ko có',20,10,12,N'image/3.png',N'Màu Đen','12/20/2010', 0 )

	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'SONY VAIO S131FM/S',1,11,2,2,2,1,1,2,1,2,2,1,2,1,1,3,2,1,25418,N'ko có',40,40,1,N'image/6.png',N'Màu đen','12/20/2010',0)

	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'SONY VAIO VPC-EB3KFX/BJ',1,11,3,3,2,1,1,2,1,2,2,2,2,1,1,3,2,1,19270,N'ko có',40,30,1,N'image/7.png',N'Màu đen','12/20/2010',0)

	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'SONY VAIO EA24FM/L',1,12,3,6,2,1,1,2,1,2,2,1,2,1,1,3,2,1,18634,N'ko có',40,30,1,N'image/12.png',N'Màu xanh dương','12/20/2010',0)
	
	-- DÒNG TOSHIBA
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'TOSHIBA L655-S5117',1,12,4,4,1,1,1,1,1,2,3,1,3,0,1,3,7,1,13546,N'ko có',40,20,1,N'image/8.png',N'Màu đen','12/20/2010',0)
	
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'TOSHIBA L655-S5115',1,12,5,4,1,1,1,1,1,2,3,1,3,0,1,3,7,1,12720,N'ko có',40,20,1,N'image/13.png',N'Màu đen','12/20/2010',0)

	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'TOSHIBA E105-S1802 MOCHA',1,15,3,4,1,1,1,2,1,2,3,1,2,1,1,3,7,1,18440,N'ko có',40,20,1,N'image/14.png',N'Màu bạc','12/20/2010',0)

	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'Toshiba L655-S5157',1,12,3,3,1,1,1,1,1,2,3,1,2,0,1,3,7,1,14818,N'ko có',40,20,1,N'image/15.png',N'Màu bạc','12/20/2010',0)
	

	--DÒNG MACBOOK
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'MacBook Pro MC374E/A',1,13,4,5,1,1,2,2,1,2,3,4,1,1,1,3,1,1,38000,N'ko có',40,20,1,N'image/9.png',N'Màu trắng','12/20/2010',0)
	
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'Macbook Pro MC371ZP/A',1,4,4,6,1,1,2,2,1,2,3,4,1,1,1,3,1,1,39220,N'ko có',40,20,1,N'image/10.png',N'Màu trắng','12/20/2010',0)
	
	insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (N'MACBOOK Air MC505ZP/A',1,14,4,5,1,1,2,2,1,2,3,4,1,1,1,3,1,1,34360,N'ko có',40,20,1,N'image/11.png',N'Màu trắng','12/20/2010',0)


--Ver 9.6 Thêm 13 laptop khác
use ESTORE

insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'SAMSUNG SF410 S02VN',-- TenChiTietDongLapTop
1,--MaDongRAM
11, --MaDongCPU
4,	--MaDongOCung
7,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
2,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
4,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
18600,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
20,	--SoLuongNhap,
10,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/18.png',	--HinhAnh		,
N'Màu Đen',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)


insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'SAMSUNG Q528 DU02VN',-- TenChiTietDongLapTop
1,--MaDongRAM
4, --MaDongCPU
4,	--MaDongOCung
7,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
2,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
2,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
16600,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
50,	--SoLuongNhap,
12,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/19.png',	--HinhAnh		,
N'Màu Xám',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)






insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'SAMSUNG R538 DS01VN Silver',-- TenChiTietDongLapTop
2,--MaDongRAM
7, --MaDongCPU
4,	--MaDongOCung
5,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
2,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
14400,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
25,	--SoLuongNhap,
11,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/20.png',	--HinhAnh		,
N'Màu Bạc',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)



insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'ACER Aspire 4750G 2414G50Mnk',-- TenChiTietDongLapTop
2,--MaDongRAM
11, --MaDongCPU
3,	--MaDongOCung
4,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
4,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
13200,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
50,	--SoLuongNhap,
02,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/21.png',	--HinhAnh		,
N'Màu Đen',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)









insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'ACER Aspire 4750G 2414G50Mnk',-- TenChiTietDongLapTop
2,--MaDongRAM
12, --MaDongCPU
4,	--MaDongOCung
6,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
3,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
14230,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
10,	--SoLuongNhap,
08,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/22.png',	--HinhAnh		,
N'Màu Đen',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)




insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'Sony Vaio VPC-EA42EG',-- TenChiTietDongLapTop
2,--MaDongRAM
12	, --MaDongCPU
4,	--MaDongOCung
4,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
16355,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
18,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/23.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)












insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'Sony Vaio VPC-YA15FG/B',-- TenChiTietDongLapTop
2,--MaDongRAM
12	, --MaDongCPU
4,	--MaDongOCung
1,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
1,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
14536,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
05,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/24.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)








insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'Sony Vaio VPC-YA15FG/B',-- TenChiTietDongLapTop
1,--MaDongRAM
12	, --MaDongCPU
4,	--MaDongOCung
3,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
18173,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
05,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/25.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)










insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'Sony Vaio VPC-YA15FG/B',-- TenChiTietDongLapTop
1,--MaDongRAM
12	, --MaDongCPU
4,	--MaDongOCung
3,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
18173,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
05,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/26.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)





insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'Sony Vaio VPC-YA15FG/B',-- TenChiTietDongLapTop
1,--MaDongRAM
12	, --MaDongCPU
4,	--MaDongOCung
3,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
18173,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
05,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/27.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)







insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'ASUS G51J i7-720QM',-- TenChiTietDongLapTop
1,--MaDongRAM
1	, --MaDongCPU
3,	--MaDongOCung
3,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
30000,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
15,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/28.png',	--HinhAnh		,
N'Màu Đen',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)












insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'ASUS K42JY-VX041',-- TenChiTietDongLapTop
1,--MaDongRAM
12	, --MaDongCPU
3,	--MaDongOCung
3,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
13900,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
30,	--SoLuongNhap,
05,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/29.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)





insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'ASUS U35JC RX147',-- TenChiTietDongLapTop
2,--MaDongRAM
12	, --MaDongCPU
4,	--MaDongOCung
1,	--MaDongManHinh
2,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
1,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
16090,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
20,	--SoLuongNhap,
15,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/30.png',	--HinhAnh		,
N'Màu Trắng',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)





insert into CHITIETDONGLAPTOP
	(	TenChiTietDongLapTop ,	MaDongRAM,	MaDongCPU,	MaDongOCung,	MaDongManHinh ,		MaDongCardDoHoa ,
		MaDongLoa ,	MaDongODiaQuang ,	MaDongCardMang,		MaDongCardReader,	MaDongWebCam,	MaDongPin,
		MaHeDieuHanh ,	MaChiTietTrongLuong ,	FingerprintReader,	HDMI ,	SoLuongCongUSB,	MaNhaSanXuat,
		MaDanhGia,	GiaBanHienHanh , MoTaThem ,	SoLuongNhap,	SoLuongConLai,	ThoiGianBaoHanh,
		HinhAnh		,	MauSac	, NgayNhap, Deleted
	)
	values (
N'ASUS N43JF VX071',-- TenChiTietDongLapTop
1,--MaDongRAM
4	, --MaDongCPU
3,	--MaDongOCung
2,	--MaDongManHinh
1,	--MaDongCardDoHoa
1,	--MaDongLoa
1,	--MaDongODiaQuang
2,	--MaDongCardMang
1,	--MaDongCardReader
2,	--MaDongWebCam
3,	--MaDongPin
1,	--MaHeDieuHanh
2,	--MaChiTietTrongLuong
1,	--FingerprintReader
1,	--	HDMI 
3,	--SoLuongCongUSB
1,	--	MaNhaSanXuat
1,	--MaDanhGia
23635,	--GiaBanHienHanh
N'ko có',	--MoTaThem ,				
50,	--SoLuongNhap,
15,	--SoLuongConLai,
12,	--	ThoiGianBaoHanh,
N'image/31.png',	--HinhAnh		,
N'Màu Đen',	--MauSac	,
'12/20/2010',	-- NgayNhap,
0-- Deleted
)





---VỊ TRÍ MỚI CẬP NHẬT---
-- insert Thông Tin Khách Hàng 
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Học sinh')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Sinh viên')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Doanh nhân')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Bác sĩ')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Dược sĩ')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Kỹ sư xây dựng')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Kỹ sư cơ khí')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Kế toán')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Kiến trúc sư')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Chuyên viên đồ họa')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Lập trình viên')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Nhân viên văn phòng')
insert into NGHENGHIEP(TenNgheNghiep)
values (N'Nghề khác...')
--------------------------------------------
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Chơi game')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Xem phim')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Học tập')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Đánh văn bản')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Mục đích khác')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Thiết kế đồ họa chuyên nghiệp')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Thiết kế công trình')
insert into MUCDICHSUDUNG(	TenMucDichSuDung)
values (N'Lập trình')
--------------------------------------------
insert into DOTUOI(	TenDoTuoi)
values (N'0 đến 10 tuổi')
insert into DOTUOI(	TenDoTuoi)
values (N'11 đến 17 tuổi')
insert into DOTUOI(	TenDoTuoi)
values (N'18 đến 22 tuổi')
insert into DOTUOI(	TenDoTuoi)
values (N'23 đến 30 tuổi')
insert into DOTUOI(	TenDoTuoi)
values (N'31 đến 40 tuổi')
insert into DOTUOI(	TenDoTuoi)
values (N'trên 40 tuổi')
--------------------------------------------
insert into TINHTHANH(	TenTinhThanh)
values (N'TP. Hồ Chí Minh')
insert into TINHTHANH(	TenTinhThanh)
values (N'TP  Hà Nội')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bắc Giang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bắc Kạn')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bắc Ninh')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Cao Băng')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Điện Biên')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hà Giang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hà Nam')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hà Tây')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hải Dương')
insert into TINHTHANH(	TenTinhThanh)
values (N'TP Hải Phòng')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hòa Bình')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hưng Yên')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Lai Châu')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Lào Cai')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Lạng Sơn')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Nam Định')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Ninh Bình')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Phú Thọ')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Quảng Ninh')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Sơn La')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Thái Bình')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Thái Nguyên')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Tuyên Quang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Vĩnh Phúc')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Yên Bái')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Yên Bái')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bình Định')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Đắk Lắk')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Đắk Nông')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Gia Lai')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hà Tĩnh')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Khánh Hòa')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Kon Tum')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Nghệ An')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Phú Yên')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Quảng Bình')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Quảng Nam')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Quảng Ngãi')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Quảng Trị')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Thanh Hóa')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Thừa Thiên Huế')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh An Giang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bà Rịa Vũng Tàu')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bạc Liêu')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bến Tre')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bình Dương')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bình Phước')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Bình Thuận')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Cà Mau')
insert into TINHTHANH(	TenTinhThanh)
values (N'TP Cần Thơ')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Đồng Nai')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Đồng Tháp')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Hậu Giang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Kiên Giang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Lâm Đồng')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Long An')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Ninh Thuận')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Sóc Trăng')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Tây Ninh')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Tiền Giang')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Trà Vinh')
insert into TINHTHANH(	TenTinhThanh)
values (N'Tỉnh Vĩnh Long')
insert into TINHTHANH(	TenTinhThanh)
values (N'Nơi khác ...')

--TOÀN BỘ DỮ LIỆU GIÃ LẬP ĐƯỢC THỰC HIỆN TRÊN 3 NHÓM NGƯỜI CHÍNH: HỌC SINH, SINH VIÊN, DOANH NHÂN
--SAU NÀY SẼ MỞ RỘNG 
-----------------------------------------------------------------------------------------


