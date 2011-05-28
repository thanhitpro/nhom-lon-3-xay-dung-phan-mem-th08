using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class MyChiTietDongCardDoHoaDTO
    {
        string m_sTenDongCardDoHoa;

        public string STenDongCardDoHoa
        {
            get { return this.m_sTenDongCardDoHoa; }
            set { this.m_sTenDongCardDoHoa = value; }
        }

        MyChiTietBoNhoCardDoHoaDTO m_chiTietBoNhoCardDoHoa;

        public MyChiTietBoNhoCardDoHoaDTO ChiTietBoNhoCardDoHoa
        {
            get { return this.m_chiTietBoNhoCardDoHoa; }
            set { this.m_chiTietBoNhoCardDoHoa = value; }
        }

        MyNhaSanXuatDTO m_nhaSanXuat;

        public MyNhaSanXuatDTO NhaSanXuat
        {
            get { return this.m_nhaSanXuat; }
            set { this.m_nhaSanXuat = value; }
        }

        MyBangDiemKhoangTangDTO m_BangDiemKhoangTang;

        internal MyBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return this.m_BangDiemKhoangTang; }
            set { this.m_BangDiemKhoangTang = value; }
        }

        int m_iMaDongCardDoHoa;

        public int IMaDongCardDoHoa
        {
            get { return this.m_iMaDongCardDoHoa; }
            set { this.m_iMaDongCardDoHoa = value; }
        }
    }
}
