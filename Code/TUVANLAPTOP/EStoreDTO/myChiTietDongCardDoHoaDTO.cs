using System;
using System.Collections.Generic;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongCardDoHoaDTO
    {
        string m_sTenDongCardDoHoa;

        public string STenDongCardDoHoa
        {
            get { return m_sTenDongCardDoHoa; }
            set { m_sTenDongCardDoHoa = value; }
        }

        myChiTietBoNhoCardDoHoaDTO m_chiTietBoNhoCardDoHoa;

        public myChiTietBoNhoCardDoHoaDTO ChiTietBoNhoCardDoHoa
        {
            get { return m_chiTietBoNhoCardDoHoa; }
            set { m_chiTietBoNhoCardDoHoa = value; }
        }

        myNhaSanXuatDTO m_nhaSanXuat;

        public myNhaSanXuatDTO NhaSanXuat
        {
            get { return m_nhaSanXuat; }
            set { m_nhaSanXuat = value; }
        }

        myBangDiemKhoangTangDTO m_BangDiemKhoangTang;

        internal myBangDiemKhoangTangDTO BangDiemKhoangTang
        {
            get { return m_BangDiemKhoangTang; }
            set { m_BangDiemKhoangTang = value; }
        }

        int m_iMaDongCardDoHoa;

        public int IMaDongCardDoHoa
        {
            get { return m_iMaDongCardDoHoa; }
            set { m_iMaDongCardDoHoa = value; }
        }
    }
}
