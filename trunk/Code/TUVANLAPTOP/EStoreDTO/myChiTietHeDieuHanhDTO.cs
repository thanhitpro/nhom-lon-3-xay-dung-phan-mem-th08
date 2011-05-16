using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietHeDieuHanhDTO
    {
        string m_sTenHeDieuHanh;

        public string STenHeDieuHanh
        {
            get { return m_sTenHeDieuHanh; }
            set { m_sTenHeDieuHanh = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }

        int m_iMaHeDieuHanh;

        public int IMaHeDieuHanh
        {
            get { return m_iMaHeDieuHanh; }
            set { m_iMaHeDieuHanh = value; }
        }
    }
}
