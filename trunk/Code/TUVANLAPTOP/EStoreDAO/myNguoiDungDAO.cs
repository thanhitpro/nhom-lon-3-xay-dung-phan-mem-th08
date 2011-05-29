using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myNguoiDungDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        public static bool KiemTraNguoiDungTonTai(string _sTenDangNhap,string _sMatKhau)
        {
            try
            {
                int count = m_eStoreDataContext.NGUOIDUNGs.Count(p => p.TenDangNhap == _sTenDangNhap);
                if (count <= 0)
                    return false;
                else
                {
                    NGUOIDUNG user = m_eStoreDataContext.NGUOIDUNGs.Single(p => p.TenDangNhap == _sTenDangNhap);
                    if (user.MatKhau == _sMatKhau)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
