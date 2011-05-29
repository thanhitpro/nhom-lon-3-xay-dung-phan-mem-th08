using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongOCungDTO
    {
        myChiTietVongQuayOCungDTO m_chiTietVongQuayOCung;

        public myChiTietVongQuayOCungDTO ChiTietVongQuayOCung
        {
            get { return m_chiTietVongQuayOCung; }
            set { m_chiTietVongQuayOCung = value; }
        }

        myChiTietDungLuongOCungDTO m_chiTietDungLuongOCung;

        public myChiTietDungLuongOCungDTO ChiTietDungLuongOCung
        {
            get { return m_chiTietDungLuongOCung; }
            set { m_chiTietDungLuongOCung = value; }
        }

        string m_sTenDongOCung;

        public string STenDongOCung
        {
            get { return m_sTenDongOCung; }
            set { m_sTenDongOCung = value; }
        }

        myBangDiemKhoangTangDTO m_bangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_bangDiemKhoangTang; }
            set { m_bangDiemKhoangTang = value; }
        }

        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }

        int m_iMaDongOCung;

        public int IMaDongOCung
        {
            get { return m_iMaDongOCung; }
            set { m_iMaDongOCung = value; }
        }
    }
}
