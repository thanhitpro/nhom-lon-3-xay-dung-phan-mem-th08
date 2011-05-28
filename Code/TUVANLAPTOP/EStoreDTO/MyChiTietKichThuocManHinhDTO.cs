using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietKichThuocManHinhDTO
    {
        string m_sTenChiTietKichThuocManHinh;

        public string STenChiTietKichThuocManHinh
        {
            get { return this.m_sTenChiTietKichThuocManHinh; }
            set { this.m_sTenChiTietKichThuocManHinh = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
