using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyHeDieuHanhDTO
    {
        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }

        MyChiTietHeDieuHanhDTO m_chiTietHeDieuHanh;

        public MyChiTietHeDieuHanhDTO ChiTietHeDieuHanh
        {
            get { return this.m_chiTietHeDieuHanh; }
            set { this.m_chiTietHeDieuHanh = value; }
        }

        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }
    }
}
