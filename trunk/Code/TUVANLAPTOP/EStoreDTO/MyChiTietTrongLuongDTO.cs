using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietTrongLuongDTO
    {
        MyChiTietLoaiTrongLuongDTO m_chiTietLoaiTrongLuong;

        public MyChiTietLoaiTrongLuongDTO ChiTietLoaiTrongLuong
        {
            get { return this.m_chiTietLoaiTrongLuong; }
            set { this.m_chiTietLoaiTrongLuong = value; }
        }

        float m_fGiaTriTrongLuong;

        public float FGiaTriTrongLuong
        {
            get { return this.m_fGiaTriTrongLuong; }
            set { this.m_fGiaTriTrongLuong = value; }
        }

        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }

        int m_iMaCHiTietTrongLuong;

        public int IMaCHiTietTrongLuong
        {
            get { return this.m_iMaCHiTietTrongLuong; }
            set { this.m_iMaCHiTietTrongLuong = value; }
        }
    }
}
