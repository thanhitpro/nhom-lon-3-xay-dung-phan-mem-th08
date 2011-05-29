using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongPinDTO
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

        myChiTietThoiLuongPinDTO m_chiTietThoiLuongPin;

        public myChiTietThoiLuongPinDTO ChiTietThoiLuongPin
        {
            get { return m_chiTietThoiLuongPin; }
            set { m_chiTietThoiLuongPin = value; }
        }

        string m_fTenDongPin;

        public string FTenDongPin
        {
            get { return m_fTenDongPin; }
            set { m_fTenDongPin = value; }
        }

        float m_fThoiGianSuDung;

        public float FThoiGianSuDung
        {
            get { return m_fThoiGianSuDung; }
            set { m_fThoiGianSuDung = value; }
        }

        int m_iMaDongPin;

        public int IMaDongPin
        {
            get { return m_iMaDongPin; }
            set { m_iMaDongPin = value; }
        }
    }
}
