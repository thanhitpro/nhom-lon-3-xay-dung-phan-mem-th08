using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myHeDieuHanhDTO
    {
        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }

        myChiTietHeDieuHanhDTO m_chiTietHeDieuHanh;

        public myChiTietHeDieuHanhDTO ChiTietHeDieuHanh
        {
            get { return m_chiTietHeDieuHanh; }
            set { m_chiTietHeDieuHanh = value; }
        }

        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }
    }
}
