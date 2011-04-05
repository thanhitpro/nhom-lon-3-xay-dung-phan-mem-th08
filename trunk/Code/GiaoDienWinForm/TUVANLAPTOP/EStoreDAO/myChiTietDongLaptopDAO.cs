using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{

    public class myChiTietDongLaptopDAO
    {
        private DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public myChiTietDongLaptopDTO LayChiTietDongLaptop(int _iMaChiTietDongLaptop)
        {
           /* myChiTietDongLaptopDTO chitietdonglaptop_DTO = null;
            foreach (CHITIETDONGLAPTOP chitietdonglaptop_DAO in m_eStoreDataContext.CHITIETDONGLAPTOPs)
            {
                if (chitietdonglaptop_DAO.MaDongLapTop == _iMaChiTietDongLaptop)
                {
                    chitietdonglaptop_DTO = new myChiTietDongLaptopDTO();
                    chitietdonglaptop_DTO.BFingerprintReader = BitConverter.GetBytes(chitietdonglaptop_DAO.FingerprintReader.Value)[0];
                    chitietdonglaptop_DTO.BHDMI = BitConverter.GetBytes(chitietdonglaptop_DAO.HDMI.Value)[0];
                    myChiTietDongCardDoHoaDAO chitietDongCardDoHoa_DAO = new myChiTietDongCardDoHoaDAO();
                    chitietdonglaptop_DTO.ChiTietDongCacDoHoa = chitietDongCardDoHoa_DAO.LayChiTietDongCardDoHoa(chitietdonglaptop_DAO.MaDongCardDoHoa.Value);
                    myChiTietDongCardMangDAO chitietDongCardMang_DAO = new myChiTietDongCardMangDAO();
                    chitietdonglaptop_DTO.ChiTietDongCardMang = chitietDongCardMang_DAO.LayChiTietDongCardMang(chitietdonglaptop_DAO.MaDongCardMang.Value );
                    myChiTietDongCardReaderDAO chitietDongCardReader_DAO = new myChiTietDongCardReaderDAO();
                    chitietdonglaptop_DTO.ChiTietDongCardReader = chitietDongCardReader_DAO.LayChiTietDongCardReader(chitietdonglaptop_DAO.MaDongCardReader.Value);
                    myChiTietDongCPUDAO chitietDongCPU_DAO = new myChiTietDongCPUDAO();
                    chitietdonglaptop_DTO.ChiTietDongCPU = chitietDongCPU_DAO.LayChiTietDongCPU(chitietdonglaptop_DAO.MaDongCPU.Value);
                    myChiTietDongLoaDAO chitietDongLoa_DAO = new myChiTietDongLoaDAO();
                    chitietdonglaptop_DTO.ChiTietDongLoa = chitietDongLoa_DAO.LayChiTietDongLoa(chitietdonglaptop_DAO.MaDongLoa.Value);
                    myChiTietDongManHinhDAO chitietDongManHinh_DAO = new myChiTietDongManHinhDAO();
                    chitietdonglaptop_DTO.ChiTietDongManHinh = chitietDongManHinh_DAO.LayChiTietDongManHinh(chitietdonglaptop_DAO.MaDongManHinh.Value);
                    myChiTietDongOCungDAO chitietDongOCung_DAO = new myChiTietDongOCungDAO();
                    chitietdonglaptop_DTO.ChiTietDongOCung = chitietDongOCung_DAO.LayChiTietDongOCung(chitietdonglaptop_DAO.MaDongOCung.Value);
                    myChiTietDongODiaQuangDAO chitietDongODiaQuang_DAO = new myChiTietDongODiaQuangDAO();
                    chitietdonglaptop_DTO.ChiTietDongODiaQuang  = chitietDongODiaQuang_DAO.LayChiTietDongODiaQuang (chitietdonglaptop_DAO.MaDongODiaQuang.Value);
                    myChiTietDongPinDAO chitietDongPin_DAO = new myChiTietDongPinDAO();
                    chitietdonglaptop_DTO.ChiTietDongPin = chitietDongPin_DAO.LayChiTietDongPin(chitietdonglaptop_DAO.MaDongPin.Value);
                    myChiTietDongWebcamDAO chitietDongWebCam_DAO = new myChiTietDongWebcamDAO();
                    chitietdonglaptop_DTO.ChiTietDongWebCam = chitietDongWebCam_DAO.LayChiTietDongWebcam(chitietdonglaptop_DAO.MaDongWebCam.Value);
                    myChiTietHeDieuHanhDAO chitietHeDieuHanh_DAO = new myChiTietHeDieuHanhDAO();
                    chitietdonglaptop_DTO.ChiTietHeDieuHanh = chitietHeDieuHanh_DAO.LayChiTietHeDieuHanh(chitietdonglaptop_DAO.MaHeDieuHanh.Value);
                    myDanhGiaDAO danhgia_DAO = new myDanhGiaDAO();
                    chitietdonglaptop_DTO.DanhGia = danhgia_DAO.LayDanhGia(chitietdonglaptop_DAO.DANHGIA.MaDanhGia);
                    chitietdonglaptop_DTO.FGiaBanHienHanh = (float)chitietdonglaptop_DAO.GiaBanHienHanh.Value;
                    chitietdonglaptop_DTO.ISoLuongCongUSB = chitietdonglaptop_DAO.SoLuongCongUSB.Value;
                    chitietdonglaptop_DTO.ISoLuongNhap = chitietdonglaptop_DAO.SoLuongNhap.Value;
                    chitietdonglaptop_DTO.IThoiGianBaoHanh = chitietdonglaptop_DAO.ThoiGianBaoHanh.Value;
                    myNhaSanXuatDAO nhaSanXuat_DAO = new myNhaSanXuatDAO();
                    chitietdonglaptop_DTO.NhaSanXuat = nhaSanXuat_DAO.LayNhaSanXuat(chitietdonglaptop_DAO.MaNhaSanXuat.Value);
                    chitietdonglaptop_DTO.SHinhAnh = chitietdonglaptop_DAO.HinhAnh;
                    chitietdonglaptop_DTO.SMauSac = chitietdonglaptop_DAO.MauSac;
                    chitietdonglaptop_DTO.SMoTaThem = chitietdonglaptop_DAO.MoTaThem;
                    chitietdonglaptop_DTO.STenChiTietDongLapTop = chitietdonglaptop_DAO.TenChiTietDongLapTop;
                }
            }
            return chitietdonglaptop_DTO;*/
            return null;
        }

        public List<myChiTietDongLaptopDTO> LayChiTietDongLaptop()
        {
            /*List<myChiTietDongLaptopDTO> danhsachChiTietDongLapTop = new List<myChiTietDongLaptopDTO>();

            foreach (CHITIETDONGLAPTOP chitietdonglaptop_DAO in m_eStoreDataContext.CHITIETDONGLAPTOPs)
            {

                    myChiTietDongLaptopDTO chitietdonglaptop_DTO = new myChiTietDongLaptopDTO() ;
                    chitietdonglaptop_DTO = new myChiTietDongLaptopDTO();
                    chitietdonglaptop_DTO.BFingerprintReader = BitConverter.GetBytes(chitietdonglaptop_DAO.FingerprintReader.Value)[0];
                    chitietdonglaptop_DTO.BHDMI = BitConverter.GetBytes(chitietdonglaptop_DAO.HDMI.Value)[0];
                    myChiTietDongCardDoHoaDAO chitietDongCardDoHoa_DAO = new myChiTietDongCardDoHoaDAO();
                    chitietdonglaptop_DTO.ChiTietDongCacDoHoa = chitietDongCardDoHoa_DAO.LayChiTietDongCardDoHoa(chitietdonglaptop_DAO.MaDongCardDoHoa.Value);
                    myChiTietDongCardMangDAO chitietDongCardMang_DAO = new myChiTietDongCardMangDAO();
                    chitietdonglaptop_DTO.ChiTietDongCardMang = chitietDongCardMang_DAO.LayChiTietDongCardMang(chitietdonglaptop_DAO.MaDongCardMang.Value);
                    myChiTietDongCardReaderDAO chitietDongCardReader_DAO = new myChiTietDongCardReaderDAO();
                    chitietdonglaptop_DTO.ChiTietDongCardReader = chitietDongCardReader_DAO.LayChiTietDongCardReader(chitietdonglaptop_DAO.MaDongCardReader.Value);
                    myChiTietDongCPUDAO chitietDongCPU_DAO = new myChiTietDongCPUDAO();
                    chitietdonglaptop_DTO.ChiTietDongCPU = chitietDongCPU_DAO.LayChiTietDongCPU(chitietdonglaptop_DAO.MaDongCPU.Value);
                    myChiTietDongLoaDAO chitietDongLoa_DAO = new myChiTietDongLoaDAO();
                    chitietdonglaptop_DTO.ChiTietDongLoa = chitietDongLoa_DAO.LayChiTietDongLoa(chitietdonglaptop_DAO.MaDongLoa.Value);
                    myChiTietDongManHinhDAO chitietDongManHinh_DAO = new myChiTietDongManHinhDAO();
                    chitietdonglaptop_DTO.ChiTietDongManHinh = chitietDongManHinh_DAO.LayChiTietDongManHinh(chitietdonglaptop_DAO.MaDongManHinh.Value);
                    myChiTietDongOCungDAO chitietDongOCung_DAO = new myChiTietDongOCungDAO();
                    chitietdonglaptop_DTO.ChiTietDongOCung = chitietDongOCung_DAO.LayChiTietDongOCung(chitietdonglaptop_DAO.MaDongOCung.Value);
                    myChiTietDongODiaQuangDAO chitietDongODiaQuang_DAO = new myChiTietDongODiaQuangDAO();
                    chitietdonglaptop_DTO.ChiTietDongODiaQuang = chitietDongODiaQuang_DAO.LayChiTietDongODiaQuang(chitietdonglaptop_DAO.MaDongODiaQuang.Value);
                    myChiTietDongPinDAO chitietDongPin_DAO = new myChiTietDongPinDAO();
                    chitietdonglaptop_DTO.ChiTietDongPin = chitietDongPin_DAO.LayChiTietDongPin(chitietdonglaptop_DAO.MaDongPin.Value);
                    myChiTietDongWebcamDAO chitietDongWebCam_DAO = new myChiTietDongWebcamDAO();
                    chitietdonglaptop_DTO.ChiTietDongWebCam = chitietDongWebCam_DAO.LayChiTietDongWebcam(chitietdonglaptop_DAO.MaDongWebCam.Value);
                    myChiTietHeDieuHanhDAO chitietHeDieuHanh_DAO = new myChiTietHeDieuHanhDAO();
                    chitietdonglaptop_DTO.ChiTietHeDieuHanh = chitietHeDieuHanh_DAO.LayChiTietHeDieuHanh(chitietdonglaptop_DAO.MaHeDieuHanh.Value);
                    myDanhGiaDAO danhgia_DAO = new myDanhGiaDAO();
                    chitietdonglaptop_DTO.DanhGia = danhgia_DAO.LayDanhGia(chitietdonglaptop_DAO.DANHGIA.MaDanhGia);
                    chitietdonglaptop_DTO.FGiaBanHienHanh = (float)chitietdonglaptop_DAO.GiaBanHienHanh.Value;
                    chitietdonglaptop_DTO.ISoLuongCongUSB = chitietdonglaptop_DAO.SoLuongCongUSB.Value;
                    chitietdonglaptop_DTO.ISoLuongNhap = chitietdonglaptop_DAO.SoLuongNhap.Value;
                    chitietdonglaptop_DTO.IThoiGianBaoHanh = chitietdonglaptop_DAO.ThoiGianBaoHanh.Value;
                    myNhaSanXuatDAO nhaSanXuat_DAO = new myNhaSanXuatDAO();
                    chitietdonglaptop_DTO.NhaSanXuat = nhaSanXuat_DAO.LayNhaSanXuat(chitietdonglaptop_DAO.MaNhaSanXuat.Value);
                    chitietdonglaptop_DTO.SHinhAnh = chitietdonglaptop_DAO.HinhAnh;
                    chitietdonglaptop_DTO.SMauSac = chitietdonglaptop_DAO.MauSac;
                    chitietdonglaptop_DTO.SMoTaThem = chitietdonglaptop_DAO.MoTaThem;
                    chitietdonglaptop_DTO.STenChiTietDongLapTop = chitietdonglaptop_DAO.TenChiTietDongLapTop;
                    danhsachChiTietDongLapTop.Add(chitietdonglaptop_DTO);

            }
            return danhsachChiTietDongLapTop;*/
            return null;
        }
    }
}
