using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongWebcamDTO
    {
        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }

        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }

        string m_sTenDongWebCam;

        public string STenDongWebCam
        {
            get { return this.m_sTenDongWebCam; }
            set { this.m_sTenDongWebCam = value; }
        }

        float m_fDoPhanGiai;

        public float FDoPhanGiai
        {
            get { return this.m_fDoPhanGiai; }
            set { this.m_fDoPhanGiai = value; }
        }

        int m_iMaDongWebcam;

        public int IMaDongWebcam
        {
            get { return this.m_iMaDongWebcam; }
            set { this.m_iMaDongWebcam = value; }
        }
    }
}
