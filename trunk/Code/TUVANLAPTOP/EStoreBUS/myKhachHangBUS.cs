using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myKhachHangBUS
    {
        public myKhachHangDTO LayKhachHang(int _iMaKhachHang)
        { return null; }

        public List<myKhachHangDTO> LayKhachHang()
        { return null; }

        public static bool themKhachHang(KHACHHANG _kKhachHang)
        {
            try
            {
                return myKhachHangDAO.themKhachHang(_kKhachHang);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
