using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongCardMangDTO
    {
        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }

        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }

        myChiTietLoaiKetNoiCardMangDTO m_chiTietLoaiKetNoiMang;

        public myChiTietLoaiKetNoiCardMangDTO ChiTietLoaiKetNoiMang
        {
            get { return m_chiTietLoaiKetNoiMang; }
            set { m_chiTietLoaiKetNoiMang = value; }
        }

        string m_sTenDongCardMang;

        public string STenDongCardMang
        {
            get { return m_sTenDongCardMang; }
            set { m_sTenDongCardMang = value; }
        }

        int m_iMaDongCardMang;

        public int IMaDongCardMang
        {
            get { return m_iMaDongCardMang; }
            set { m_iMaDongCardMang = value; }
        }
    }
}
