using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietLoaiTrongLuongDTO
    {
        string m_sTenLoaiTrongLuong;

        public string STenLoaiTrongLuong
        {
            get { return m_sTenLoaiTrongLuong; }
            set { m_sTenLoaiTrongLuong = value; }
        }

        int m_iGiaTriTrongLuong;

        public int IGiaTriTrongLuong
        {
            get { return m_iGiaTriTrongLuong; }
            set { m_iGiaTriTrongLuong = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
