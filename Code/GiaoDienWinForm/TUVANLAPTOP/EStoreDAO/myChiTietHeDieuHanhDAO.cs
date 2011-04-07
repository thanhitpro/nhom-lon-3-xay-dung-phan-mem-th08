using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietHeDieuHanhDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietHeDieuHanhDTO LayChiTietHDH(int _iMaDanhGia)
        {
            myChiTietHeDieuHanhDTO chiTietHDH = null;
            var query = m_eStoreDataContext.CHITIETHEDIEUHANHs.Single(hdh => hdh.MaChiTietHeDieuHanh == _iMaDanhGia);
            if (query != null)
            {
                chiTietHDH = new myChiTietHeDieuHanhDTO();
                chiTietHDH.STenHeDieuHanh = query.TenHeDieuHanh;
                chiTietHDH.FHeSo = (float) query.HeSo;
            }
            return chiTietHDH;
        }

        public List<myChiTietHeDieuHanhDTO> LayChiTietHeDieuHanh()
        {
            return null;
        }
    }
}
