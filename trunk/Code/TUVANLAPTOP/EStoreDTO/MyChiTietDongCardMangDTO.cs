using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongCardMangDTO
    {
        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }

        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }

        MyChiTietLoaiKetNoiCardMangDTO m_chiTietLoaiKetNoiMang;

        public MyChiTietLoaiKetNoiCardMangDTO ChiTietLoaiKetNoiMang
        {
            get { return this.m_chiTietLoaiKetNoiMang; }
            set { this.m_chiTietLoaiKetNoiMang = value; }
        }

        string m_sTenDongCardMang;

        public string STenDongCardMang
        {
            get { return this.m_sTenDongCardMang; }
            set { this.m_sTenDongCardMang = value; }
        }

        int m_iMaDongCardMang;

        public int IMaDongCardMang
        {
            get { return this.m_iMaDongCardMang; }
            set { this.m_iMaDongCardMang = value; }
        }
    }
}
