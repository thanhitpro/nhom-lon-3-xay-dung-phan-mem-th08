using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyBangDiemKhoangTangDTO
    {
        int m_iDiem;

        public int IDiem
        {
            get { return this.m_iDiem; }
            set { this.m_iDiem = value; }
        }

        int m_iKhoangTang;

        public int IKhoangTang
        {
            get { return this.m_iKhoangTang; }
            set { this.m_iKhoangTang = value; }
        }
    }
}
