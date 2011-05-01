﻿using System;
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
            try
            {
                KHACHHANG _KhachHang = m_eStoreDataContext.KHACHHANGs.Single(temp => temp.MaKhachHang == _iMaKhachHang);
                return _KhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<KHACHHANG> LayKhachHang()
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
                List<KHACHHANG> DSKhachHang = new List<KHACHHANG>();
                foreach (KHACHHANG _KH in Query)
                    DSKhachHang.Add(_KH);
                return DSKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static int SLKhachHangTheoNgheNghiep(int _iMaNgheNghiep)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.MaNgheNghiep== _iMaNgheNghiep
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int SLKhachHangTheoMucDich(int _iMaMucDichSuDung)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs
                            where _KhachHang.MaMucDichSuDung== _iMaMucDichSuDung
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int SLKhachHangTheoDoTuoi(int _iMaDoTuoi)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.MaDoTuoi== _iMaDoTuoi
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int SLKhachHangTheoTinhThanh(int _iMaTinhThanh)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.MaTinhThanh == _iMaTinhThanh
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int SLKhachHangTheoGioiTinh(bool isNam)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.GioiTinhNam==isNam
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                 //  if (_KH.GioiTinhNam == isNam)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
