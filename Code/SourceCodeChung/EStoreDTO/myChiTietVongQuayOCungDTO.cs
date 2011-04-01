using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietVongQuayOCungDTO
    {
        string m_sTenChiTietVongQuayOCung;

        public string STenChiTietVongQuayOCung
        {
            get { return m_sTenChiTietVongQuayOCung; }
            set { m_sTenChiTietVongQuayOCung = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
