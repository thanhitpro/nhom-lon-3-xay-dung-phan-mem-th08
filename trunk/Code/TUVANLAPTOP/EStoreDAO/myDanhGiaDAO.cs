using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EStoreDTO;

namespace EStoreDAO
{
    public class myDanhGiaDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myDanhGiaDTO LayDanhGia(int _iMaDanhGia)
        {
            try
            {
                myDanhGiaDTO danhGia = null;
                var query = m_eStoreDataContext.DANHGIAs.Single(dg => dg.MaDanhGia == _iMaDanhGia);
                if (query != null)
                {
                    danhGia = new myDanhGiaDTO();
                    danhGia.ITongDiem = query.TongDiem;
                    danhGia.ISoNguoiDanhGia = query.SoNguoiDanhGia;
                }
                return danhGia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
