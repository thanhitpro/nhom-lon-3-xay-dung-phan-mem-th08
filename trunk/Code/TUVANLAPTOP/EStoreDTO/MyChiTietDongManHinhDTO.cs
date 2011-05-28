using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongManHinhDTO
    {
        MyChiTietKichThuocManHinhDTO m_chiTietKichThuocManHinh;

        public MyChiTietKichThuocManHinhDTO ChiTietKichThuocManHinh
        {
            get { return this.m_chiTietKichThuocManHinh; }
            set { this.m_chiTietKichThuocManHinh = value; }
        }

        string m_sTenDongManHinh;

        public string STenDongManHinh
        {
            get { return this.m_sTenDongManHinh; }
            set { this.m_sTenDongManHinh = value; }
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

        int m_iMaDongManHinh;

        public int IMaDongManHinh
        {
            get { return this.m_iMaDongManHinh; }
            set { this.m_iMaDongManHinh = value; }
        }
    }
}
