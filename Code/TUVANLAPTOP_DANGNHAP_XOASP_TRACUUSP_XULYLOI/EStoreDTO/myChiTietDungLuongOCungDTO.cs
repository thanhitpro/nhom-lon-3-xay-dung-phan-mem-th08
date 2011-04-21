using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDungLuongOCungDTO
    {
        string m_sTenChiTietDungLuongOCung;

        public string STenChiTietDungLuongOCung
        {
            get { return m_sTenChiTietDungLuongOCung; }
            set { m_sTenChiTietDungLuongOCung = value; }
        }

        float m_fHeSo;

        public float FHeSo
        {
            get { return m_fHeSo; }
            set { m_fHeSo = value; }
        }
    }
}
