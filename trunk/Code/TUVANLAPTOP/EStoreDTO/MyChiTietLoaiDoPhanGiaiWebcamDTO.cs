using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietLoaiDoPhanGiaiWebcamDTO
    {
        string m_sTenChiTietLoaiDoPhanGiaiWebcam;

        public string STenChiTietLoaiDoPhanGiaiWebcam
        {
            get { return this.m_sTenChiTietLoaiDoPhanGiaiWebcam; }
            set { this.m_sTenChiTietLoaiDoPhanGiaiWebcam = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
