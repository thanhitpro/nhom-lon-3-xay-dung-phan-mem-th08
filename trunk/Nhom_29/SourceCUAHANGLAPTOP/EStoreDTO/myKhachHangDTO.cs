using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class myKhachHangDTO
    {
        myNgheNghiepDTO m_ngheNghiep;

        public myNgheNghiepDTO NgheNghiep
        {
            get { return m_ngheNghiep; }
            set { m_ngheNghiep = value; }
        }

        myMucDichSuDungDTO m_mucDichSuDung;

        public myMucDichSuDungDTO MucDichSuDung
        {
            get { return m_mucDichSuDung; }
            set { m_mucDichSuDung = value; }
        }

        myDoTuoiDTO m_doTuoi;

        public myDoTuoiDTO DoTuoi
        {
            get { return m_doTuoi; }
            set { m_doTuoi = value; }
        }

        Byte m_bGioiTinhNam;

        public Byte BGioiTinhNam
        {
            get { return m_bGioiTinhNam; }
            set { m_bGioiTinhNam = value; }
        }

        myTinhThanhDTO m_tinhThanh;

        public myTinhThanhDTO TinhThanh
        {
            get { return m_tinhThanh; }
            set { m_tinhThanh = value; }
        }
    }
}
