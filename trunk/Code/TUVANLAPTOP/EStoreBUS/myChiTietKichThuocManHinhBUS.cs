//-----------------------------------------------------------------------
// <copyright file="MyChiTietKichThuocManHinhBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết kích thước màn hình BUS
    /// </summary>
    public class MyChiTietKichThuocManHinhBUS
    {
        /// <summary>
        /// Lấy danh sách kích thước màn hình
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách kích thước màn hình hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietKichThuocManHinhDTO> LayDSKichThuocManHinh()
        {
            try
            {
                return myChiTietKichThuocManHinhDAO.LayDSKichThuocManHinh();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm mới kích thước màn hình
        /// </summary>
        /// <param name="maKichThuoc">Đối tượng ChiTietKichThuocManHinhDTO muốn thêm mới</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemMoiKichThuocMH(myChiTietKichThuocManHinhDTO maKichThuoc)
        {
            try
            {
                return myChiTietKichThuocManHinhDAO.ThemKichThuocManHinh(maKichThuoc);
            }
            catch
            {
                throw;
            }
        }
    }
}
