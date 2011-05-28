using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietCacKhaNangODiaQuangDTO
    {
        string m_sTenChiTietCacKhaNangODiaQuang;

        public string STenChiTietCacKhaNangODiaQuang
        {
            get { return this.m_sTenChiTietCacKhaNangODiaQuang; }
            set { this.m_sTenChiTietCacKhaNangODiaQuang = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
