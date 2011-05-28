using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietLoaiDanhGiaDTO
    {
        string m_sTenLoaiDanhGia;

        public string STenLoaiDanhGia
        {
            get { return this.m_sTenLoaiDanhGia; }
            set { this.m_sTenLoaiDanhGia = value; }
        }

        int m_iGiaTri;

        public int IGiaTri
        {
            get { return this.m_iGiaTri; }
            set { this.m_iGiaTri = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
