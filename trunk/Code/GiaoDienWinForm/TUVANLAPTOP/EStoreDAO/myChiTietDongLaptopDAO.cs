using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EStoreDTO;

namespace EStoreDAO
{

    public class myChiTietDongLaptopDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Ham tra ve Thong tin day du cua Laptop co ID chi ra
        /// </summary>
        /// <param name="_iMaChiTietDongLaptop"></param>
        /// <returns></returns>
        public static myChiTietDongLaptopDTO LayChiTietDongLaptop(int _iMaChiTietDongLaptop)
        {
            myChiTietDongLaptopDTO chiTietDongLaptop = null;

            var query = from dongLaptop in m_eStoreDataContext.CHITIETDONGLAPTOPs where dongLaptop.MaDongLapTop == _iMaChiTietDongLaptop select dongLaptop;
            if (query.Count() > 0)
            {
                CHITIETDONGLAPTOP temp = query.Single();
                chiTietDongLaptop = new myChiTietDongLaptopDTO();
               
                //Ma laptop:
                chiTietDongLaptop.IMaDongLaptop = temp.MaDongLapTop;

                //FingerprintReader:
                chiTietDongLaptop.BFingerprintReader = BitConverter.GetBytes(temp.FingerprintReader.Value)[0];

                
                //BHDMI:
                chiTietDongLaptop.BHDMI = BitConverter.GetBytes(temp.HDMI.Value)[0];

                //RAM:
                chiTietDongLaptop.ChiTietDongRam = myChiTietDongRamDAO.LayChiTietDongRam(temp.CHITIETDONGRAM.MaDongRAM);

                //CardDoHoa:
                 chiTietDongLaptop.ChiTietDongCacDoHoa = myChiTietDongCardDoHoaDAO.LayChiTietDongCardDoHoa(temp.CHITIETDONGCARDDOHOA.MaDongCardDoHoa);

                //Card Mang:
                chiTietDongLaptop.ChiTietDongCardMang = myChiTietDongCardMangDAO.LayChiTietDongCardMang(temp.CHITIETDONGCARDMANG.MaDongCardMang);

                //Card Reader:
                chiTietDongLaptop.ChiTietDongCardReader = myChiTietDongCardReaderDAO.LayChiTietDongCardReader(temp.CHITIETDONGCARDREADER.MaDongCardReader);

                //CPU:
                chiTietDongLaptop.ChiTietDongCPU = myChiTietDongCPUDAO.LayChiTietDongCPU(temp.CHITIETDONGCPU.MaDongCPU);

                //Loa:
                chiTietDongLaptop.ChiTietDongLoa = myChiTietDongLoaDAO.LayChiTietDongLoa(temp.CHITIETDONGLOA.MaDongLoa);

                //Man hinh:
                chiTietDongLaptop.ChiTietDongManHinh = myChiTietDongManHinhDAO.LayChiTietDongManHinh(temp.CHITIETDONGMANHINH.MaDongManHinh);

                //O cung:
                chiTietDongLaptop.ChiTietDongOCung = myChiTietDongOCungDAO.LayChiTietDongOCung(temp.CHITIETDONGOCUNG.MaDongOCung);

                //O quang:
                chiTietDongLaptop.ChiTietDongODiaQuang = myChiTietDongODiaQuangDAO.LayChiTietDongODiaQuang(temp.CHITIETDONGODIAQUANG.MaDongODiaQuang);

                //Pin:
                chiTietDongLaptop.ChiTietDongPin = myChiTietDongPinDAO.LayChiTietDongPin(temp.CHITIETDONGPIN.MaDongPin);

                //WebCam:
                chiTietDongLaptop.ChiTietDongWebCam = myChiTietDongWebcamDAO.LayChiTietDongWebcam(temp.CHITIETDONGWEBCAM.MaDongWebCam);

                //He dieu hanh:
                chiTietDongLaptop.ChiTietHeDieuHanh = myChiTietHeDieuHanhDAO.LayChiTietHDH(temp.HEDIEUHANH.CHITIETHEDIEUHANH.MaChiTietHeDieuHanh);

                //Danh gia:
                chiTietDongLaptop.DanhGia = myDanhGiaDAO.LayDanhGia(temp.DANHGIA.MaDanhGia);

                //Nha SX:
                chiTietDongLaptop.NhaSanXuat = new myNhaSanXuatDTO(temp.NHASANXUAT.TenNhaSanXuat);

                //Hinh anh:
                chiTietDongLaptop.SHinhAnh = temp.HinhAnh;

                //Mau sac:
                chiTietDongLaptop.SMauSac = temp.MauSac;
                
                //Mo ta them:
                chiTietDongLaptop.SMoTaThem = temp.MoTaThem;

                //Ten laptop:
                chiTietDongLaptop.STenChiTietDongLapTop = temp.TenChiTietDongLapTop;

                //Gia:
                chiTietDongLaptop.FGiaBanHienHanh = (float)temp.GiaBanHienHanh.Value;

                //So luong cong USB:
                chiTietDongLaptop.ISoLuongCongUSB = temp.SoLuongCongUSB.Value;

                //So luong Nhap:
                chiTietDongLaptop.ISoLuongNhap = temp.SoLuongNhap.Value;

                //Thoi gian bao hanh:
                chiTietDongLaptop.IThoiGianBaoHanh = temp.ThoiGianBaoHanh.Value;

                //Trong luong:
                chiTietDongLaptop.ChiTietTrongLuong = myChiTietTrongLuongDAO.LayChiTietTrongLuong(temp.CHITIETTRONGLUONG.MaChiTietTrongLuong);
            }

            return chiTietDongLaptop;
        }

        public List<myChiTietDongLaptopDTO> LayChiTietDongLaptop()
        {
            /*List<myChiTietDongLaptopDTO> danhsachChiTietDongLapTop = new List<myChiTietDongLaptopDTO>();

            foreach (CHITIETDONGLAPTOP chitietdonglaptop_DAO in m_eStoreDataContext.CHITIETDONGLAPTOPs)
            {

                    myChiTietDongLaptopDTO chiTietDongLaptop = new myChiTietDongLaptopDTO() ;
                    chiTietDongLaptop = new myChiTietDongLaptopDTO();
                    chiTietDongLaptop.BFingerprintReader = BitConverter.GetBytes(chitietdonglaptop_DAO.FingerprintReader.Value)[0];
                    chiTietDongLaptop.BHDMI = BitConverter.GetBytes(chitietdonglaptop_DAO.HDMI.Value)[0];
                    myChiTietDongCardDoHoaDAO chitietDongCardDoHoa_DAO = new myChiTietDongCardDoHoaDAO();
                    chiTietDongLaptop.ChiTietDongCacDoHoa = chitietDongCardDoHoa_DAO.LayChiTietDongCardDoHoa(chitietdonglaptop_DAO.MaDongCardDoHoa.Value);
                    myChiTietDongCardMangDAO chitietDongCardMang_DAO = new myChiTietDongCardMangDAO();
                    chiTietDongLaptop.ChiTietDongCardMang = chitietDongCardMang_DAO.LayChiTietDongCardMang(chitietdonglaptop_DAO.MaDongCardMang.Value);
                    myChiTietDongCardReaderDAO chitietDongCardReader_DAO = new myChiTietDongCardReaderDAO();
                    chiTietDongLaptop.ChiTietDongCardReader = chitietDongCardReader_DAO.LayChiTietDongCardReader(chitietdonglaptop_DAO.MaDongCardReader.Value);
                    myChiTietDongCPUDAO chitietDongCPU_DAO = new myChiTietDongCPUDAO();
                    chiTietDongLaptop.ChiTietDongCPU = chitietDongCPU_DAO.LayChiTietDongCPU(chitietdonglaptop_DAO.MaDongCPU.Value);
                    myChiTietDongLoaDAO chitietDongLoa_DAO = new myChiTietDongLoaDAO();
                    chiTietDongLaptop.ChiTietDongLoa = chitietDongLoa_DAO.LayChiTietDongLoa(chitietdonglaptop_DAO.MaDongLoa.Value);
                    myChiTietDongManHinhDAO chitietDongManHinh_DAO = new myChiTietDongManHinhDAO();
                    chiTietDongLaptop.ChiTietDongManHinh = chitietDongManHinh_DAO.LayChiTietDongManHinh(chitietdonglaptop_DAO.MaDongManHinh.Value);
                    myChiTietDongOCungDAO chitietDongOCung_DAO = new myChiTietDongOCungDAO();
                    chiTietDongLaptop.ChiTietDongOCung = chitietDongOCung_DAO.LayChiTietDongOCung(chitietdonglaptop_DAO.MaDongOCung.Value);
                    myChiTietDongODiaQuangDAO chitietDongODiaQuang_DAO = new myChiTietDongODiaQuangDAO();
                    chiTietDongLaptop.ChiTietDongODiaQuang = chitietDongODiaQuang_DAO.LayChiTietDongODiaQuang(chitietdonglaptop_DAO.MaDongODiaQuang.Value);
                    myChiTietDongPinDAO chitietDongPin_DAO = new myChiTietDongPinDAO();
                    chiTietDongLaptop.ChiTietDongPin = chitietDongPin_DAO.LayChiTietDongPin(chitietdonglaptop_DAO.MaDongPin.Value);
                    myChiTietDongWebcamDAO chitietDongWebCam_DAO = new myChiTietDongWebcamDAO();
                    chiTietDongLaptop.ChiTietDongWebCam = chitietDongWebCam_DAO.LayChiTietDongWebcam(chitietdonglaptop_DAO.MaDongWebCam.Value);
                    myChiTietHeDieuHanhDAO chitietHeDieuHanh_DAO = new myChiTietHeDieuHanhDAO();
                    chiTietDongLaptop.ChiTietHeDieuHanh = chitietHeDieuHanh_DAO.LayChiTietHeDieuHanh(chitietdonglaptop_DAO.MaHeDieuHanh.Value);
                    myDanhGiaDAO danhgia_DAO = new myDanhGiaDAO();
                    chiTietDongLaptop.DanhGia = danhgia_DAO.LayDanhGia(chitietdonglaptop_DAO.DANHGIA.MaDanhGia);
                    chiTietDongLaptop.FGiaBanHienHanh = (float)chitietdonglaptop_DAO.GiaBanHienHanh.Value;
                    chiTietDongLaptop.ISoLuongCongUSB = chitietdonglaptop_DAO.SoLuongCongUSB.Value;
                    chiTietDongLaptop.ISoLuongNhap = chitietdonglaptop_DAO.SoLuongNhap.Value;
                    chiTietDongLaptop.IThoiGianBaoHanh = chitietdonglaptop_DAO.ThoiGianBaoHanh.Value;
                    myNhaSanXuatDAO nhaSanXuat_DAO = new myNhaSanXuatDAO();
                    chiTietDongLaptop.NhaSanXuat = nhaSanXuat_DAO.LayNhaSanXuat(chitietdonglaptop_DAO.MaNhaSanXuat.Value);
                    chiTietDongLaptop.SHinhAnh = chitietdonglaptop_DAO.HinhAnh;
                    chiTietDongLaptop.SMauSac = chitietdonglaptop_DAO.MauSac;
                    chiTietDongLaptop.SMoTaThem = chitietdonglaptop_DAO.MoTaThem;
                    chiTietDongLaptop.STenChiTietDongLapTop = chitietdonglaptop_DAO.TenChiTietDongLapTop;
                    danhsachChiTietDongLapTop.Add(chiTietDongLaptop);

            }
            return danhsachChiTietDongLapTop;*/
            return null;
        }
    }
}
