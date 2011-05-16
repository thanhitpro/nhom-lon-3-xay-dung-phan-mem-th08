using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietThoiLuongPinDTO
    {
        string m_sTenThoiLuongPin;

        public string STenThoiLuongPin
        {
            get { return m_sTenThoiLuongPin; }
            set { m_sTenThoiLuongPin = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
