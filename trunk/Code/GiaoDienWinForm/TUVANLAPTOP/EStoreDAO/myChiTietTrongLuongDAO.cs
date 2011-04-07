using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietTrongLuongDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietTrongLuongDTO LayChiTietTrongLuong(int _iMaChiTietTrongLuong)
        {
            myChiTietTrongLuongDTO chiTietTrongLuong = null;

            var query = m_eStoreDataContext.CHITIETTRONGLUONGs.Single(trongluong => trongluong.MaChiTietTrongLuong == _iMaChiTietTrongLuong);
            if (query != null)
            {
                chiTietTrongLuong = new myChiTietTrongLuongDTO();
                chiTietTrongLuong.FGiaTriTrongLuong = (float)query.GiaTriTrongLuong;

                myChiTietLoaiTrongLuongDTO chiTietLoaiTL = new myChiTietLoaiTrongLuongDTO();
                chiTietLoaiTL.STenLoaiTrongLuong = query.CHITIETLOAITRONGLUONG.TenLoaiTrongLuong;
                chiTietLoaiTL.IGiaTriTrongLuong = query.CHITIETLOAITRONGLUONG.GiaTriTrongLuong.Value;
                chiTietLoaiTL.FHeSo = (float)query.CHITIETLOAITRONGLUONG.HeSo;

                chiTietTrongLuong.ChiTietLoaiTrongLuong = chiTietLoaiTL;
            }

            return chiTietTrongLuong;
        }

        public List<myChiTietTrongLuongDTO> LayChiTietTrongLuong()
        {
            return null;
        }
    }
}
