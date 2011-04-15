using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietTrongLuongBUS
    {
        public myChiTietTrongLuongDTO LayChiTietTrongLuong(int _iMaChiTietTrongLuong)
        { return null; }

        public List<myChiTietTrongLuongDTO> LayChiTietTrongLuong()
        {
            myChiTietTrongLuongDAO chiTietTL = new myChiTietTrongLuongDAO();
            return chiTietTL.LayChiTietTrongLuong();
        }
    }
}
