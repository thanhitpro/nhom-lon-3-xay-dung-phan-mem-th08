using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongOCungDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongOCungDTO LayChiTietDongOCung(int _iMaChiTietDongOCung)
        {
            myChiTietDongOCungDTO chiTietOCung = null;

            var query = m_eStoreDataContext.CHITIETDONGOCUNGs.Single(ocung => ocung.MaDongOCung == _iMaChiTietDongOCung);

            if (query != null)
            {
                chiTietOCung = new myChiTietDongOCungDTO();
                chiTietOCung.STenDongOCung = query.TenDongOCung;
                chiTietOCung.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietVongQuayOCungDTO chiTietVongQuay = new myChiTietVongQuayOCungDTO();
                chiTietVongQuay.STenChiTietVongQuayOCung = query.CHITIETVONGQUAYOCUNG.TenChiTietVongQuayOCung;
                chiTietVongQuay.FHeSo = (float)query.CHITIETVONGQUAYOCUNG.HeSo;
                chiTietOCung.ChiTietVongQuayOCung = chiTietVongQuay;

                myChiTietDungLuongOCungDTO chiTietDungLuong = new myChiTietDungLuongOCungDTO();
                chiTietDungLuong.STenChiTietDungLuongOCung = query.CHITIETDUNGLUONGOCUNG.TenChiTietDungLuongOCung;
                chiTietDungLuong.FHeSo = (float)query.CHITIETDUNGLUONGOCUNG.HeSo;
                chiTietOCung.ChiTietDungLuongOCung = chiTietDungLuong;
            }

            return chiTietOCung;
        }

        public List<myChiTietDongOCungDTO> LayChiTietDongOCung()
        {
            return null;
        }
    }
}
