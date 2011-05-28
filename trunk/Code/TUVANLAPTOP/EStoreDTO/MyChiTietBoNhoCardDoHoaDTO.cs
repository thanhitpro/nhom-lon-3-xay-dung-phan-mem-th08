using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietBoNhoCardDoHoaDTO
    {
        string m_sTenChiTietCardDoHoa;

        public string STenChiTietCardDoHoa
        {
            get { return this.m_sTenChiTietCardDoHoa; }
            set { this.m_sTenChiTietCardDoHoa = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
