using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongPinDTO
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

        MyChiTietThoiLuongPinDTO m_chiTietThoiLuongPin;

        public MyChiTietThoiLuongPinDTO ChiTietThoiLuongPin
        {
            get { return this.m_chiTietThoiLuongPin; }
            set { this.m_chiTietThoiLuongPin = value; }
        }

        string m_fTenDongPin;

        public string FTenDongPin
        {
            get { return this.m_fTenDongPin; }
            set { this.m_fTenDongPin = value; }
        }

        float m_fThoiGianSuDung;

        public float FThoiGianSuDung
        {
            get { return this.m_fThoiGianSuDung; }
            set { this.m_fThoiGianSuDung = value; }
        }

        int m_iMaDongPin;

        public int IMaDongPin
        {
            get { return this.m_iMaDongPin; }
            set { this.m_iMaDongPin = value; }
        }
    }
}
