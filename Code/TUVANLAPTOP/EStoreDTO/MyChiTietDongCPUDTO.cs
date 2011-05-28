using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongCPUDTO
    {
        MyChiTietCongNgheCPUDTO m_chiTietCongNgheCPU;

        public MyChiTietCongNgheCPUDTO ChiTietCongNgheCPU
        {
            get { return this.m_chiTietCongNgheCPU; }
            set { this.m_chiTietCongNgheCPU = value; }
        }

        string m_sTenDongCPU;

        public string STenDongCPU
        {
            get { return this.m_sTenDongCPU; }
            set { this.m_sTenDongCPU = value; }
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

        int m_iMaDongCPU;

        public int IMaDongCPU
        {
            get { return this.m_iMaDongCPU; }
            set { this.m_iMaDongCPU = value; }
        }

    }
}
