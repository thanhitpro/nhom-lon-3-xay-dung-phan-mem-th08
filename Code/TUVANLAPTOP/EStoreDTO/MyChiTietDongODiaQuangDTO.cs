using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongODiaQuangDTO
    {
        MyChiTietCacKhaNangODiaQuangDTO m_chiTietCacKhaNangODiaQuang;

        public MyChiTietCacKhaNangODiaQuangDTO ChiTietCacKhaNangODiaQuang
        {
            get { return this.m_chiTietCacKhaNangODiaQuang; }
            set { this.m_chiTietCacKhaNangODiaQuang = value; }
        }

        string m_sTenDongODiaQuang;

        public string STenDongODiaQuang
        {
            get { return this.m_sTenDongODiaQuang; }
            set { this.m_sTenDongODiaQuang = value; }
        }

        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }

        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }

        int m_iMaDongODiaQuang;

        public int IMaDongODiaQuang
        {
            get { return this.m_iMaDongODiaQuang; }
            set { this.m_iMaDongODiaQuang = value; }
        }
    }
}
