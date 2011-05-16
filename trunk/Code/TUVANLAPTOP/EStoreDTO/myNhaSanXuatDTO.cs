using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class myNhaSanXuatDTO
    {
        string m_sTenNhaSanXuat;

        public string STenNhaSanXuat
        {
            get { return m_sTenNhaSanXuat; }
            set { m_sTenNhaSanXuat = value; }
        }

        public myNhaSanXuatDTO(string _sNhaSX)
        {
            m_sTenNhaSanXuat = _sNhaSX;
        }

        int m_iMaNhaSanXuat;

        public int IMaNhaSanXuat
        {
            get { return m_iMaNhaSanXuat; }
            set { m_iMaNhaSanXuat = value; }
        }
    }
}
