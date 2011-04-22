using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongManHinhDTO
    {
        myChiTietKichThuocManHinhDTO m_chiTietKichThuocManHinh;

        public myChiTietKichThuocManHinhDTO ChiTietKichThuocManHinh
        {
            get { return m_chiTietKichThuocManHinh; }
            set { m_chiTietKichThuocManHinh = value; }
        }

        string m_sTenDongManHinh;

        public string STenDongManHinh
        {
            get { return m_sTenDongManHinh; }
            set { m_sTenDongManHinh = value; }
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
    }
}
