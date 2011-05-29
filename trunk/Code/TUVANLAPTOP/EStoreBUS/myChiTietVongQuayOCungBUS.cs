//-----------------------------------------------------------------------
// <copyright file="MyChiTietVongQuayOCungBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết vòng quay ổ cứng BUS
    /// </summary>
    public class MyChiTietVongQuayOCungBUS
    {
        /// <summary>
        /// Lấy danh sách Vong Quay:
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách chi tiết vòng xoay ổ cứng hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietVongQuayOCungDTO> LayDanhSachChiTietVongQuayOCung()
        {
            try
            {
                return myChiTietVongQuayOCungDAO.LayDSVongQuayOCung();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm vòng quay ổ cứng
        /// </summary>
        /// <param name="vongQuay">Đối tượng ChiTietVongXoayOCungDTO</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemVongQuayOCung(myChiTietVongQuayOCungDTO vongQuay)
        {
            try
            {
                return myChiTietVongQuayOCungDAO.ThemVongQuay(vongQuay);
            }
            catch
            {
                throw;
            }
        }
    }
}
