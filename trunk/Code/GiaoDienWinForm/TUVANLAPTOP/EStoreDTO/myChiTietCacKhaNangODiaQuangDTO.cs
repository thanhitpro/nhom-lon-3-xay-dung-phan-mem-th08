using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietCacKhaNangODiaQuangDTO
    {
        string m_sTenChiTietCacKhaNangODiaQuang;

        public string STenChiTietCacKhaNangODiaQuang
        {
            get { return m_sTenChiTietCacKhaNangODiaQuang; }
            set { m_sTenChiTietCacKhaNangODiaQuang = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
