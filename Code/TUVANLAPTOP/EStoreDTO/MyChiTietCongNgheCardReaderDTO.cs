using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietCongNgheCardReaderDTO
    {
        string m_sTenCongNgheCardReader;

        public string STenCongNgheCardReader
        {
            get { return this.m_sTenCongNgheCardReader; }
            set { this.m_sTenCongNgheCardReader = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
