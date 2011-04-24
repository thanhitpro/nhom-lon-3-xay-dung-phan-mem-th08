using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietTrongLuongDTO
    {
        myChiTietLoaiTrongLuongDTO m_chiTietLoaiTrongLuong;

        public myChiTietLoaiTrongLuongDTO ChiTietLoaiTrongLuong
        {
            get { return m_chiTietLoaiTrongLuong; }
            set { m_chiTietLoaiTrongLuong = value; }
        }

        float m_fGiaTriTrongLuong;

        public float FGiaTriTrongLuong
        {
            get { return m_fGiaTriTrongLuong; }
            set { m_fGiaTriTrongLuong = value; }
        }

        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }

        int m_iMaCHiTietTrongLuong;

        public int IMaCHiTietTrongLuong
        {
            get { return m_iMaCHiTietTrongLuong; }
            set { m_iMaCHiTietTrongLuong = value; }
        }
    }
}
