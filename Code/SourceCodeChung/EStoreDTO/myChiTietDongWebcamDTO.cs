using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongWebcamDTO
    {
        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }

        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }

        string m_sTenDongWebCam;

        public string STenDongWebCam
        {
            get { return m_sTenDongWebCam; }
            set { m_sTenDongWebCam = value; }
        }

        float m_fDoPhanGiai;

        public float FDoPhanGiai
        {
            get { return m_fDoPhanGiai; }
            set { m_fDoPhanGiai = value; }
        }
    }
}
