using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongODiaQuangDTO
    {
        myChiTietCacKhaNangODiaQuangDTO m_chiTietCacKhaNangODiaQuang;

        public myChiTietCacKhaNangODiaQuangDTO ChiTietCacKhaNangODiaQuang
        {
            get { return m_chiTietCacKhaNangODiaQuang; }
            set { m_chiTietCacKhaNangODiaQuang = value; }
        }

        string m_sTenDongODiaQuang;

        public string STenDongODiaQuang
        {
            get { return m_sTenDongODiaQuang; }
            set { m_sTenDongODiaQuang = value; }
        }

        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }

        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }

        int m_iMaDongODiaQuang;

        public int IMaDongODiaQuang
        {
            get { return m_iMaDongODiaQuang; }
            set { m_iMaDongODiaQuang = value; }
        }

    }
}
