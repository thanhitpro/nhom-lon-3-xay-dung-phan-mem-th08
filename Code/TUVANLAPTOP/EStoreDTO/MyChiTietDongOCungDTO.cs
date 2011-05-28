using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongOCungDTO
    {
        MyChiTietVongQuayOCungDTO m_chiTietVongQuayOCung;

        public MyChiTietVongQuayOCungDTO ChiTietVongQuayOCung
        {
            get { return this.m_chiTietVongQuayOCung; }
            set { this.m_chiTietVongQuayOCung = value; }
        }

        MyChiTietDungLuongOCungDTO m_chiTietDungLuongOCung;

        public MyChiTietDungLuongOCungDTO ChiTietDungLuongOCung
        {
            get { return this.m_chiTietDungLuongOCung; }
            set { this.m_chiTietDungLuongOCung = value; }
        }

        string m_sTenDongOCung;

        public string STenDongOCung
        {
            get { return this.m_sTenDongOCung; }
            set { this.m_sTenDongOCung = value; }
        }

        MyBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_bangDiemKhoangTang; }
            set { this.m_bangDiemKhoangTang = value; }
        }

        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }

        int m_iMaDongOCung;

        public int IMaDongOCung
        {
            get { return this.m_iMaDongOCung; }
            set { this.m_iMaDongOCung = value; }
        }
    }
}
