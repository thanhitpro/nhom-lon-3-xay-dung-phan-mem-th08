using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietHeDieuHanhDTO
    {
        string m_sTenHeDieuHanh;

        public string STenHeDieuHanh
        {
            get { return this.m_sTenHeDieuHanh; }
            set { this.m_sTenHeDieuHanh = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }

        int m_iMaHeDieuHanh;

        public int IMaHeDieuHanh
        {
            get { return this.m_iMaHeDieuHanh; }
            set { this.m_iMaHeDieuHanh = value; }
        }
    }
}
