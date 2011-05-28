using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietThoiLuongPinDTO
    {
        string m_sTenThoiLuongPin;

        public string STenThoiLuongPin
        {
            get { return this.m_sTenThoiLuongPin; }
            set { this.m_sTenThoiLuongPin = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
