using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongLoaDTO
    {
        Byte m_bCoMicro;

        public Byte BCoMicro
        {
            get { return this.m_bCoMicro; }
            set { this.m_bCoMicro = value; }
        }

        string m_sTenDongLoa;

        public string STenDongLoa
        {
            get { return this.m_sTenDongLoa; }
            set { this.m_sTenDongLoa = value; }
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

        int m_iMaDongLoa;

        public int IMaDongLoa
        {
            get { return this.m_iMaDongLoa; }
            set { this.m_iMaDongLoa = value; }
        }
    }
}
