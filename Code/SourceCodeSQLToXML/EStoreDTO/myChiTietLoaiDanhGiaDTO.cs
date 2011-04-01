using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietLoaiDanhGiaDTO
    {
        string m_sTenLoaiDanhGia;

        public string STenLoaiDanhGia
        {
            get { return m_sTenLoaiDanhGia; }
            set { m_sTenLoaiDanhGia = value; }
        }

        int m_iGiaTri;

        public int IGiaTri
        {
            get { return m_iGiaTri; }
            set { m_iGiaTri = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
