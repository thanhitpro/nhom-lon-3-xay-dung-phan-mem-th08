using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyNhaSanXuatDTO
    {
        string m_sTenNhaSanXuat;

        public string STenNhaSanXuat
        {
            get { return this.m_sTenNhaSanXuat; }
            set { this.m_sTenNhaSanXuat = value; }
        }

        int m_iMaNhaSanXuat;

        public int IMaNhaSanXuat
        {
            get { return this.m_iMaNhaSanXuat; }
            set { this.m_iMaNhaSanXuat = value; }
        }

        public MyNhaSanXuatDTO(string _sNhaSX)
        {
            this.m_sTenNhaSanXuat = _sNhaSX;
        }        
    }
}
