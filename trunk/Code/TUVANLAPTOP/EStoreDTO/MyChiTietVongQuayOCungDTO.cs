using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietVongQuayOCungDTO
    {
        string m_sTenChiTietVongQuayOCung;

        public string STenChiTietVongQuayOCung
        {
            get { return this.m_sTenChiTietVongQuayOCung; }
            set { this.m_sTenChiTietVongQuayOCung = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
