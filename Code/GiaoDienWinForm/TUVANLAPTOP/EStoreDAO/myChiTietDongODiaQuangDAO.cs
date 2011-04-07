using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongODiaQuangDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongODiaQuangDTO LayChiTietDongODiaQuang(int _iMaChiTietDongODiaQuang)
        {
            myChiTietDongODiaQuangDTO chiTietOQuang = new myChiTietDongODiaQuangDTO();
            var query = m_eStoreDataContext.CHITIETDONGODIAQUANGs.Single(oquang => oquang.MaDongODiaQuang == _iMaChiTietDongODiaQuang);
            if (query != null)
            {
                chiTietOQuang = new myChiTietDongODiaQuangDTO();
                chiTietOQuang.STenDongODiaQuang = query.TenDongODiaQuang;
                chiTietOQuang.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietCacKhaNangODiaQuangDTO khaNangOQuang = new myChiTietCacKhaNangODiaQuangDTO();
                khaNangOQuang.STenChiTietCacKhaNangODiaQuang = query.CHITIETCACKHANANGODIAQUANG.TenChiTietCacKhaNangODiaQuang;
                khaNangOQuang.FHeSo = (float)query.CHITIETCACKHANANGODIAQUANG.HeSo;

                chiTietOQuang.ChiTietCacKhaNangODiaQuang = khaNangOQuang;
            }

            return chiTietOQuang;
        }

        public List<myChiTietDongODiaQuangDTO> LayChiTietDongODiaQuang()
        {
            return null;
        }
    }
}
