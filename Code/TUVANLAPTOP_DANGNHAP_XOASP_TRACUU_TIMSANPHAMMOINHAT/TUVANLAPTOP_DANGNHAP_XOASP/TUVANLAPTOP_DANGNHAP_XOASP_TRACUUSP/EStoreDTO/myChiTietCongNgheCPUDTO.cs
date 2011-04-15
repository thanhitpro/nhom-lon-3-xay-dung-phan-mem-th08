using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietCongNgheCPUDTO
    {
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
    }
}
