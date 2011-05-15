using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDAO;
using EStoreDTO;

namespace EStoreBUS
{
    public class myNguoiDungBUS
    {
        public static bool KiemTraNguoiDungTonTai(string _sTenDangNhap, string _sMatKhau)
        {
            try
            {
                return myNguoiDungDAO.KiemTraNguoiDungTonTai(_sTenDangNhap, _sMatKhau);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
