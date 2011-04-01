using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongCardReaderDTO
    {
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

        myChiTietCongNgheCardReaderDTO m_chiTietCongNgheCardReader;

        public myChiTietCongNgheCardReaderDTO ChiTietCongNgheCardReader
        {
            get { return m_chiTietCongNgheCardReader; }
            set { m_chiTietCongNgheCardReader = value; }
        }

        string m_sTenDongCardReader;

        public string STenDongCardReader
        {
            get { return m_sTenDongCardReader; }
            set { m_sTenDongCardReader = value; }
        }
    }
}
