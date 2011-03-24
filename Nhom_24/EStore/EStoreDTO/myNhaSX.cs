using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class myNhaSX
    {
        private int m_iMaNhaSX;

        public int IMaNhaSX
        {
            get { return m_iMaNhaSX; }
            set { m_iMaNhaSX = value; }
        }

        private string m_sTenNhaSX;

        public string STenNhaSX
        {
            get { return m_sTenNhaSX; }
            set { m_sTenNhaSX = value; }
        }

        public myNhaSX(int _iMaNhaSX, string _sTenNhaSX)
        {
            IMaNhaSX = _iMaNhaSX;
            STenNhaSX = _sTenNhaSX;
        }
    }
}
