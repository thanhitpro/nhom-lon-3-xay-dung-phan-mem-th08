using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietLoaiTrongLuongDTO
    {
        string m_sTenLoaiTrongLuong;

        public string STenLoaiTrongLuong
        {
            get { return this.m_sTenLoaiTrongLuong; }
            set { this.m_sTenLoaiTrongLuong = value; }
        }

        int m_iGiaTriTrongLuong;

        public int IGiaTriTrongLuong
        {
            get { return this.m_iGiaTriTrongLuong; }
            set { this.m_iGiaTriTrongLuong = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
