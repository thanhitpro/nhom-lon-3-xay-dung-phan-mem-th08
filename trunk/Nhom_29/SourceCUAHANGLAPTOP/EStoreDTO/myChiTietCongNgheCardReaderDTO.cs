using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietCongNgheCardReaderDTO
    {
        string m_sTenCongNgheCardReader;

        public string STenCongNgheCardReader
        {
            get { return m_sTenCongNgheCardReader; }
            set { m_sTenCongNgheCardReader = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
