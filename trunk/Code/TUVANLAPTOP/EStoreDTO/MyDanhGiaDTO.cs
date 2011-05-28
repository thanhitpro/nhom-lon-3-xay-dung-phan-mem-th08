using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyDanhGiaDTO
    {
        int m_iTongDiem;

        public int ITongDiem
        {
            get { return this.m_iTongDiem; }
            set { this.m_iTongDiem = value; }
        }

        int m_iSoNguoiDanhGia;

        public int ISoNguoiDanhGia
        {
            get { return this.m_iSoNguoiDanhGia; }
            set { this.m_iSoNguoiDanhGia = value; }
        }

        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }
    }
}
