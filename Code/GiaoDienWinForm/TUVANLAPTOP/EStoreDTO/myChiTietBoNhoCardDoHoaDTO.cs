using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietBoNhoCardDoHoaDTO
    {
        string m_sTenChiTietCardDoHoa;

        public string STenChiTietCardDoHoa
        {
            get { return m_sTenChiTietCardDoHoa; }
            set { m_sTenChiTietCardDoHoa = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
