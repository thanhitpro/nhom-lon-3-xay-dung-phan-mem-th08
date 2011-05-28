using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongCardReaderDTO
    {
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

        MyChiTietCongNgheCardReaderDTO m_chiTietCongNgheCardReader;

        public MyChiTietCongNgheCardReaderDTO ChiTietCongNgheCardReader
        {
            get { return this.m_chiTietCongNgheCardReader; }
            set { this.m_chiTietCongNgheCardReader = value; }
        }

        string m_sTenDongCardReader;

        public string STenDongCardReader
        {
            get { return this.m_sTenDongCardReader; }
            set { this.m_sTenDongCardReader = value; }
        }

        int m_iMaDongCardReader;

        public int IMaDongCardReader
        {
            get { return this.m_iMaDongCardReader; }
            set { this.m_iMaDongCardReader = value; }
        }
    }
}
