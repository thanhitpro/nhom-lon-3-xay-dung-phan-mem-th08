using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyGiaoDichDTO
    {
        MyKhachHangDTO m_khachHang;

        public MyKhachHangDTO KhachHang
        {
            get { return this.m_khachHang; }
            set { this.m_khachHang = value; }
        }

        MyChiTietDongLaptopDTO m_chiTietDongLapTop;

        public MyChiTietDongLaptopDTO ChiTietDongLapTop
        {
            get { return this.m_chiTietDongLapTop; }
            set { this.m_chiTietDongLapTop = value; }
        }

        DateTime m_dNgayMua;

        public DateTime DNgayMua
        {
            get { return this.m_dNgayMua; }
            set { this.m_dNgayMua = value; }
        }
    }
}
