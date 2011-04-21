using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class myChiTietDongRamDTO
    {
        private myChiTietBoNhoRamDTO m_chiTietBoNhoRam;

        public myChiTietBoNhoRamDTO ChiTietBoNhoRam
        {
            get { return m_chiTietBoNhoRam; }
            set { m_chiTietBoNhoRam = value; }
        }

        myChiTietCongNgheRamDTO m_chiTietCongNgheRam;

        public myChiTietCongNgheRamDTO ChiTietCongNgheRam
        {
            get { return m_chiTietCongNgheRam; }
            set { m_chiTietCongNgheRam = value; }
        }

        string m_sTenDongRAM;

        public string STenDongRAM
        {
            get { return m_sTenDongRAM; }
            set { m_sTenDongRAM = value; }
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
