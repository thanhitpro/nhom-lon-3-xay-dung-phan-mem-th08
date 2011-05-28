using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EStoreDTO
{
    public class MyKhachHangDTO
    {
        MyNgheNghiepDTO m_ngheNghiep;

        public MyNgheNghiepDTO NgheNghiep
        {
            get { return this.m_ngheNghiep; }
            set { this.m_ngheNghiep = value; }
        }

        MyMucDichSuDungDTO m_mucDichSuDung;

        public MyMucDichSuDungDTO MucDichSuDung
        {
            get { return this.m_mucDichSuDung; }
            set { this.m_mucDichSuDung = value; }
        }

        MyDoTuoiDTO m_doTuoi;

        public MyDoTuoiDTO DoTuoi
        {
            get { return this.m_doTuoi; }
            set { this.m_doTuoi = value; }
        }

        Byte m_bGioiTinhNam;

        public Byte BGioiTinhNam
        {
            get { return this.m_bGioiTinhNam; }
            set { this.m_bGioiTinhNam = value; }
        }

        MyTinhThanhDTO m_tinhThanh;

        public MyTinhThanhDTO TinhThanh
        {
            get { return this.m_tinhThanh; }
            set { this.m_tinhThanh = value; }
        }
    }
}
