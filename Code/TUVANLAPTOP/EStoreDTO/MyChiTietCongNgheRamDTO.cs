using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietCongNgheRamDTO
    {
        string m_sTenCongNgheRam;

        public string STenCongNgheRam
        {
            get { return this.m_sTenCongNgheRam; }
            set { this.m_sTenCongNgheRam = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
