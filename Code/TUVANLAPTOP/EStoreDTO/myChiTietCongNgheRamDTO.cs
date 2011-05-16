using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietCongNgheRamDTO
    {
        string m_sTenCongNgheRam;

        public string STenCongNgheRam
        {
            get { return m_sTenCongNgheRam; }
            set { m_sTenCongNgheRam = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
