using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    class myChiTietBoNhoRamDTO
    {
        string m_sTenChiTietBoNhoRam;

        public string STenChiTietBoNhoRam
        {
            get { return m_sTenChiTietBoNhoRam; }
            set { m_sTenChiTietBoNhoRam = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
