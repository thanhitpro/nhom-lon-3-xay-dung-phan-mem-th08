using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myDanhGiaDTO
    {
        int m_iTongDiem;

        public int ITongDiem
        {
            get { return m_iTongDiem; }
            set { m_iTongDiem = value; }
        }

        int m_iSoNguoiDanhGia;

        public int ISoNguoiDanhGia
        {
            get { return m_iSoNguoiDanhGia; }
            set { m_iSoNguoiDanhGia = value; }
        }

        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }
    }
}
