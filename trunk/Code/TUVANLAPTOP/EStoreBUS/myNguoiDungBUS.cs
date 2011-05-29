//-----------------------------------------------------------------------
// <copyright file="CMyNguoiDungBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System;
    using EStoreDAO;

    /// <summary>
    /// Người dùng BUS
    /// </summary>
    public class CMyNguoiDungBUS
    {
        /// <summary>
        /// Kiểm tra người dùng tồn tại
        /// </summary>
        /// <param name="tenDangNhap">tên đăng nhập </param>
        /// <param name="matKhau"> mật khẩu người dùng</param>
        /// <returns>True khi người dung tồn lại, ngược lại trả về false</returns>
        public static bool KiemTraNguoiDungTonTai(string tenDangNhap, string matKhau)
        {
            try
            {
                return myNguoiDungDAO.KiemTraNguoiDungTonTai(tenDangNhap, matKhau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
