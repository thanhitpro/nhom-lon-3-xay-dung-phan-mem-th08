using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongLoaDTO
    {
        Byte m_bCoMicro;

        public Byte BCoMicro
        {
            get { return m_bCoMicro; }
            set { m_bCoMicro = value; }
        }

        string m_sTenDongLoa;

        public string STenDongLoa
        {
            get { return m_sTenDongLoa; }
            set { m_sTenDongLoa = value; }
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
    }
}
