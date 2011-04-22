using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myGiaoDichDTO
    {
        myKhachHangDTO m_khachHang;

        public myKhachHangDTO KhachHang
        {
            get { return m_khachHang; }
            set { m_khachHang = value; }
        }

        myChiTietDongLaptopDTO m_chiTietDongLapTop;

        public myChiTietDongLaptopDTO ChiTietDongLapTop
        {
            get { return m_chiTietDongLapTop; }
            set { m_chiTietDongLapTop = value; }
        }

        DateTime m_dNgayMua;

        public DateTime DNgayMua
        {
            get { return m_dNgayMua; }
            set { m_dNgayMua = value; }
        }
    }
}
