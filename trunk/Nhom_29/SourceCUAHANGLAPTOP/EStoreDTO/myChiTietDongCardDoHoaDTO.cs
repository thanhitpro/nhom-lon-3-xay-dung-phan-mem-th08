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

        myChiTietBoNhoCardDoHoaDTO m_chiTietCardDoHoa;

        public myChiTietBoNhoCardDoHoaDTO ChiTietCardDoHoa
        {
            get { return m_chiTietCardDoHoa; }
            set { m_chiTietCardDoHoa = value; }
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

    }
}
