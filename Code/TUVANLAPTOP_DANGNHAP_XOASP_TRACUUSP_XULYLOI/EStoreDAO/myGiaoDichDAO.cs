using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using EStoreDTO;

namespace EStoreDAO
{
    public class myGiaoDichDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static GIAODICH LayGiaoDich(int _iMaGiaoDich)
        {
            GIAODICH _GiaoDich = m_eStoreDataContext.GIAODICHes.Single(Temp => Temp.MaGiaoDich == _iMaGiaoDich);
            return _GiaoDich;
           /* myGiaoDichDTO giaodich_DTO = null;
            foreach (GIAODICH giaodich_DAO in m_eStoreDataContext.GIAODICHes)
            {
                if (_iMaGiaoDich == giaodich_DAO.MaGiaoDich)
                {
                    giaodich_DTO = new myGiaoDichDTO();
                    myChiTietDongLaptopDAO chitietdonglaptop_DAO = new myChiTietDongLaptopDAO();
                    giaodich_DTO.ChiTietDongLapTop = chitietdonglaptop_DAO.LayChiTietDongLaptop(giaodich_DAO.CHITIETDONGLAPTOP.MaDongLapTop);
                    giaodich_DTO.DNgayMua = giaodich_DAO.NgayMua;
                    myKhachHangDAO khachhang_DAO = new myKhachHangDAO();
                    giaodich_DTO.KhachHang = khachhang_DAO.LayKhachHang(giaodich_DAO.MaKhachHang);
                }

            }
            return giaodich_DTO;*/
        }

        public static List<GIAODICH> LayGiaoDich()
        {
            var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
            List<GIAODICH> DSGiaoDich = new List<GIAODICH>();
            foreach (GIAODICH giaodich in Query)
                DSGiaoDich.Add(giaodich);
            return DSGiaoDich;
           /* List<myGiaoDichDTO> danhSachGiaoDich = new List<myGiaoDichDTO>();
            foreach (GIAODICH giaodich_DAO in m_eStoreDataContext.GIAODICHes)
            {
                myGiaoDichDTO giaodich_DTO = new myGiaoDichDTO();
                myChiTietDongLaptopDAO chitietdonglaptop_DAO = new myChiTietDongLaptopDAO();
                giaodich_DTO.ChiTietDongLapTop = chitietdonglaptop_DAO.LayChiTietDongLaptop(giaodich_DAO.CHITIETDONGLAPTOP.MaDongLapTop);
                giaodich_DTO.DNgayMua = giaodich_DAO.NgayMua;
                myKhachHangDAO khachhang_DAO = new myKhachHangDAO();
                giaodich_DTO.KhachHang = khachhang_DAO.LayKhachHang(giaodich_DAO.MaKhachHang);
                danhSachGiaoDich.Add(giaodich_DTO);
                
            }
            return danhSachGiaoDich ;*/
        }
        public static List<GIAODICH> LayDanhSachGiaoDichTheoMaDongLapTop(int _iMaDongLapTop)
        {
            var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
            List<GIAODICH> DSGiaoDich=new List<GIAODICH> ();
            foreach (GIAODICH _giaodich in Query)
            {
                if (_giaodich.MaDongLaptop == _iMaDongLapTop)
                    DSGiaoDich.Add(_giaodich);
            }
            return DSGiaoDich;
           /* List<myGiaoDichDTO> danhSachGiaoDich = new List<myGiaoDichDTO>();
            foreach (GIAODICH giaodich_DAO in m_eStoreDataContext.GIAODICHes)
            {
                if(giaodich_DAO.MaDongLaptop == _iMaDongLapTop)
                {
                    myGiaoDichDTO giaodich_DTO = new myGiaoDichDTO();
                    myChiTietDongLaptopDAO chitietdonglaptop_DAO = new myChiTietDongLaptopDAO();
                    giaodich_DTO.ChiTietDongLapTop = chitietdonglaptop_DAO.LayChiTietDongLaptop(giaodich_DAO.CHITIETDONGLAPTOP.MaDongLapTop);
                    giaodich_DTO.DNgayMua = giaodich_DAO.NgayMua;
                    myKhachHangDAO khachhang_DAO = new myKhachHangDAO();
                    giaodich_DTO.KhachHang = khachhang_DAO.LayKhachHang(giaodich_DAO.MaKhachHang);
                    danhSachGiaoDich.Add(giaodich_DTO);
                }

            }
            return danhSachGiaoDich;*/
        }

        public static List<GIAODICH> LayDanhSachGiaoDichTheoNhaSanXuat(int _iMaNhaSanXuat)
        {
            var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
            List<GIAODICH> DSGiaoDich = new List<GIAODICH>();
            foreach (GIAODICH _giaodich in Query)
            {
                if (_giaodich.CHITIETDONGLAPTOP.MaNhaSanXuat == _iMaNhaSanXuat)
                    DSGiaoDich.Add(_giaodich);
            }
            return DSGiaoDich;
        }

        public static bool themGiaoDich(GIAODICH _gGiaoDich)
        {
            try
            {
                m_eStoreDataContext.GIAODICHes.InsertOnSubmit(_gGiaoDich);
                m_eStoreDataContext.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                string temp = ex.Message;
                return false;
            }            
        }
    }
}
