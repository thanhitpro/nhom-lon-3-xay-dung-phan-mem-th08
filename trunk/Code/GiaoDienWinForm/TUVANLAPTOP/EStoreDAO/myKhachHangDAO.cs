using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
namespace EStoreDAO
{
    public class myKhachHangDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        public static KHACHHANG LayKhachHang(int _iMaKhachHang)
        {
            KHACHHANG _KhachHang = m_eStoreDataContext.KHACHHANGs.Single(temp => temp.MaKhachHang == _iMaKhachHang);
            return _KhachHang;
            /*myKhachHangDTO khachHang = null;
            foreach (KHACHHANG khachHang_DAO in m_eStoreDataContext.KHACHHANGs)
            {
                if (khachHang_DAO.MaKhachHang == _iMaKhachHang)
                {
                    khachHang = new myKhachHangDTO();
                    khachHang.BGioiTinhNam = BitConverter.GetBytes(khachHang_DAO.GioiTinhNam)[0];
                    khachHang.DoTuoi.STenDoTuoi  = khachHang_DAO.DOTUOI.TenDoTuoi;
                    khachHang.MucDichSuDung.STenMucDichSuDung  = khachHang_DAO.MUCDICHSUDUNG.TenMucDichSuDung;
                    khachHang.NgheNghiep.STenNgheNghiep  = khachHang_DAO.NGHENGHIEP.TenNgheNghiep ;
                    khachHang.TinhThanh.STenTinhThanh  = khachHang_DAO.TINHTHANH.TenTinhThanh;
                    break;
                }
            }
            return null;*/
        }

        public static List<KHACHHANG> LayKhachHang()
        {
            var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
            List<KHACHHANG> DSKhachHang = new List<KHACHHANG>();
            foreach (KHACHHANG _KH in Query)
                DSKhachHang.Add(_KH);
            return DSKhachHang;
            /*List<myKhachHangDTO> danhSachKhachHang = new List<myKhachHangDTO>();

            foreach (KHACHHANG khachHang_DAO in m_eStoreDataContext.KHACHHANGs)
            {
                myKhachHangDTO khachHang_DTO = new myKhachHangDTO();
                khachHang_DTO.BGioiTinhNam = BitConverter.GetBytes(khachHang_DAO.GioiTinhNam)[0];
                khachHang_DTO.DoTuoi.STenDoTuoi = khachHang_DAO.DOTUOI.TenDoTuoi;
                khachHang_DTO.MucDichSuDung.STenMucDichSuDung = khachHang_DAO.MUCDICHSUDUNG.TenMucDichSuDung;
                khachHang_DTO.NgheNghiep.STenNgheNghiep = khachHang_DAO.NGHENGHIEP.TenNgheNghiep;
                khachHang_DTO.TinhThanh.STenTinhThanh = khachHang_DAO.TINHTHANH.TenTinhThanh;
                danhSachKhachHang.Add(khachHang_DTO);
            }
            return danhSachKhachHang;*/
        }
        public static int SLKhachHangTheoNgheNghiep(int _iMaNgheNghiep)
        {
            var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
            int Result = 0;
            foreach (KHACHHANG _KH in Query)
                if (_KH.MaNgheNghiep == _iMaNgheNghiep)
                    Result++;
            return Result;
        }

        public static int SLKhachHangTheoMucDich(int _iMaMucDichSuDung)
        {
            var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
            int Result = 0;
            foreach (KHACHHANG _KH in Query)
                if (_KH.MaMucDichSuDung == _iMaMucDichSuDung)
                    Result++;
            return Result;
        }

        public static int SLKhachHangTheoDoTuoi(int _iMaDoTuoi)
        {
            var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
            int Result = 0;
            foreach (KHACHHANG _KH in Query)
                if (_KH.MaDoTuoi == _iMaDoTuoi)
                    Result++;
            return Result;
        }

        public static int SLKhachHangTheoTinhThanh(int _iMaTinhThanh)
        {
            var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
            int Result = 0;
            foreach (KHACHHANG _KH in Query)
                if (_KH.MaTinhThanh == _iMaTinhThanh)
                    Result++;
            return Result;
        }

        public static int SLKhachHangTheoGioiTinh(bool isNam)
        {
            var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
            int Result = 0;
            foreach (KHACHHANG _KH in Query)
                if (_KH.GioiTinhNam==isNam)
                    Result++;
            return Result;
        }

        public static bool themKhachHang(KHACHHANG _kKhachHang)
        {
            try
            {
                m_eStoreDataContext.KHACHHANGs.InsertOnSubmit(_kKhachHang);
                m_eStoreDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }            
        }
    }
}
