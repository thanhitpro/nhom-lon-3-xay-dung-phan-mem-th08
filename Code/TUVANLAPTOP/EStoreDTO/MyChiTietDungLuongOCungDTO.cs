using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDungLuongOCungDTO
    {
        string m_sTenChiTietDungLuongOCung;

        public string STenChiTietDungLuongOCung
        {
            get { return this.m_sTenChiTietDungLuongOCung; }
            set { this.m_sTenChiTietDungLuongOCung = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return this.m_fHeSo; }
            set { this.m_fHeSo = value; }
        }
    }
}
