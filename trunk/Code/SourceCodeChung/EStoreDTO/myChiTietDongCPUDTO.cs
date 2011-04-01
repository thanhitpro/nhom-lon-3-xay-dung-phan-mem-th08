using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongCPUDTO
    {
        myChiTietCongNgheCPUDTO m_chiTietCongNgheCPU;

        public myChiTietCongNgheCPUDTO ChiTietCongNgheCPU
        {
            get { return m_chiTietCongNgheCPU; }
            set { m_chiTietCongNgheCPU = value; }
        }

        string m_sTenDongCPU;

        public string STenDongCPU
        {
            get { return m_sTenDongCPU; }
            set { m_sTenDongCPU = value; }
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
