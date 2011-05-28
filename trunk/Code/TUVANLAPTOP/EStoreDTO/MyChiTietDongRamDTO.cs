using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongRamDTO
    {
        private MyChiTietBoNhoRamDTO m_chiTietBoNhoRam;

        public MyChiTietBoNhoRamDTO ChiTietBoNhoRam
        {
            get { return this.m_chiTietBoNhoRam; }
            set { this.m_chiTietBoNhoRam = value; }
        }

        MyChiTietCongNgheRamDTO m_chiTietCongNgheRam;

        public MyChiTietCongNgheRamDTO ChiTietCongNgheRam
        {
            get { return this.m_chiTietCongNgheRam; }
            set { this.m_chiTietCongNgheRam = value; }
        }

        string m_sTenDongRAM;

        public string STenDongRAM
        {
            get { return this.m_sTenDongRAM; }
            set { this.m_sTenDongRAM = value; }
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

        int m_iMaDongRam;
        public int IMaDongRam
        {
            get { return this.m_iMaDongRam; }
            set { this.m_iMaDongRam = value; }
        }
    }
}
