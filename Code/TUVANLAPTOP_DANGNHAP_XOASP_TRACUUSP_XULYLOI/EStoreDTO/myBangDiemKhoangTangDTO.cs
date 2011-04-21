using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class myBangDiemKhoangTangDTO
    {
        int m_iDiem;

        public int IDiem
        {
            get { return m_iDiem; }
            set { m_iDiem = value; }
        }

        int m_iKhoangTang;

        public int IKhoangTang
        {
            get { return m_iKhoangTang; }
            set { m_iKhoangTang = value; }
        }
    }
}
