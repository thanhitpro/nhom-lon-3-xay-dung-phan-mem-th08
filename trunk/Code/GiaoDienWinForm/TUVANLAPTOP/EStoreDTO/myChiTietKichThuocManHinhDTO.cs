using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietKichThuocManHinhDTO
    {
        string m_sTenChiTietKichThuocManHinh;

        public string STenChiTietKichThuocManHinh
        {
            get { return m_sTenChiTietKichThuocManHinh; }
            set { m_sTenChiTietKichThuocManHinh = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
