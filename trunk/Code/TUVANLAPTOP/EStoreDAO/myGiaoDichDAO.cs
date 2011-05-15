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
            try
            {
                GIAODICH _GiaoDich = m_eStoreDataContext.GIAODICHes.Single(Temp => Temp.MaGiaoDich == _iMaGiaoDich);
                return _GiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<GIAODICH> LayGiaoDich()
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
                List<GIAODICH> dsGiaoDich = new List<GIAODICH>();
                foreach (GIAODICH giaodich in Query)
                    dsGiaoDich.Add(giaodich);
                return dsGiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<GIAODICH> LayDanhSachGiaoDichTheoMaDongLapTop(int _iMaDongLapTop)
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes
                            where _GiaoDich.MaDongLaptop == _iMaDongLapTop
                            select _GiaoDich;
                List<GIAODICH> DSGiaoDich = new List<GIAODICH>();
                foreach (GIAODICH _giaodich in Query)
                {
                        DSGiaoDich.Add(_giaodich);
                }
                return DSGiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        public static List<GIAODICH> LayDanhSachGiaoDichTheoNhaSanXuat(int _iMaNhaSanXuat)
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
                List<GIAODICH> dsGiaoDich = new List<GIAODICH>();
                foreach (GIAODICH _giaodich in Query)
                {
                    if (_giaodich.CHITIETDONGLAPTOP.MaNhaSanXuat == _iMaNhaSanXuat)
                        dsGiaoDich.Add(_giaodich);
                }
                return dsGiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        public static int LaySoLuongGiaoDich()
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
                int kq = 0;
                foreach (GIAODICH giaodich in Query)
                    kq++;
                return kq;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
