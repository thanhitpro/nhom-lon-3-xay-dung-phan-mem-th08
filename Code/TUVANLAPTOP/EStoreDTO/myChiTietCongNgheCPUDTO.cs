using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietCongNgheCPUDTO
    {
        private int m_iMaChiTietCN;
        public int IMaChiTietCN
        {
            get { return m_iMaChiTietCN; }
            set { m_iMaChiTietCN = value; }
        }

        string m_sTenChiTietCongNgheCPU;

        public string STenChiTietCongNgheCPU
        {
            get { return m_sTenChiTietCongNgheCPU; }
            set { m_sTenChiTietCongNgheCPU = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }

        public override string ToString()
        {
            return STenChiTietCongNgheCPU;
        }
    }
}
