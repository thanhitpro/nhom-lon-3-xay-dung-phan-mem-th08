using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietLoaiDoPhanGiaiWebcamDTO
    {
        string m_sTenChiTietLoaiDoPhanGiaiWebcam;

        public string STenChiTietLoaiDoPhanGiaiWebcam
        {
            get { return m_sTenChiTietLoaiDoPhanGiaiWebcam; }
            set { m_sTenChiTietLoaiDoPhanGiaiWebcam = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
