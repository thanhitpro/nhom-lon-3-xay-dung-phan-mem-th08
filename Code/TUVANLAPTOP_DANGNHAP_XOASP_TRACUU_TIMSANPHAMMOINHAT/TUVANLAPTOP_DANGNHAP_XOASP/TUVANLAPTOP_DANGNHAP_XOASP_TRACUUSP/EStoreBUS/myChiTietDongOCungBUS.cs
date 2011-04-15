using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongOCungBUS
    {
        public myChiTietDongOCungDTO LayChiTietDongOCung(int _iMaChiTietDongOCung)
        { return null; }

        public List<myChiTietDongOCungDTO> LayChiTietDongOCung()
        {
            myChiTietDongOCungDAO chiTietDongOCung = new myChiTietDongOCungDAO();
            return chiTietDongOCung.LayChiTietDongOCung();
        }
    }
}
