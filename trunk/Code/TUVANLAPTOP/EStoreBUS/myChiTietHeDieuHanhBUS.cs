//-----------------------------------------------------------------------
// <copyright file="MyChiTietHeDieuHanhBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiệt hệ điều hành BUS
    /// </summary>
    public class MyChiTietHeDieuHanhBUS
    {
        /// <summary>
        /// Lấy danh sách hệ điều hành
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các hệ điều hành hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietHeDieuHanhDTO> LayDSHeDieuHanh()
        {
            try
            {
                return myChiTietHeDieuHanhDAO.LayDSHeDieuHanh();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm hệ điều hành mới
        /// </summary>
        /// <param name="maHDH">Mã hệ điều hành</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemMoiHDH(myChiTietHeDieuHanhDTO maHDH)
        {
            try
            {
                return myChiTietHeDieuHanhDAO.ThemHDH(maHDH);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lấy thông tin tất cả các hệ điều hành
        /// </summary>
        /// <returns>Danh sách tất cả các HDH</returns>
        public List<myChiTietHeDieuHanhDTO> LayChiTietHeDieuHanh()
        {
            myChiTietHeDieuHanhDAO chiTietHDHDAO = new myChiTietHeDieuHanhDAO();
            try
            {
                return chiTietHDHDAO.LayChiTietHeDieuHanh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy mã hệ điều hành dựa vào tên hệ điều hành
        /// </summary>
        /// <param name="tenHDH">Tên hệ điều hành</param>
        /// <returns>trả về mã dòng hệ điều hành</returns>
        public int LayChiTietHeDieuHanh(string tenHDH)
        {
            try
            {
                return myChiTietHeDieuHanhDAO.LayMaDongHeDieuHanh(tenHDH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
