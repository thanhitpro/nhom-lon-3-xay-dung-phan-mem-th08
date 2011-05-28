using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietCongNgheCPUDTO
    {
        private int m_iMaChiTietCN;
        public int IMaChiTietCN
        {
            get { return this.m_iMaChiTietCN; }
            set { this.m_iMaChiTietCN = value; }
        }

        string m_sTenChiTietCongNgheCPU;

        public string STenChiTietCongNgheCPU
        {
            get { return this.m_sTenChiTietCongNgheCPU; }
            set { this.m_sTenChiTietCongNgheCPU = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }

        public override string ToString()
        {
            return this.STenChiTietCongNgheCPU;
        }
    }
}
