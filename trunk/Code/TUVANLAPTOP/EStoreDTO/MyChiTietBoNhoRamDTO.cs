using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietBoNhoRamDTO
    {
        string m_sTenChiTietBoNhoRam;

        public string STenChiTietBoNhoRam
        {
            get { return this.m_sTenChiTietBoNhoRam; }
            set { this.m_sTenChiTietBoNhoRam = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
