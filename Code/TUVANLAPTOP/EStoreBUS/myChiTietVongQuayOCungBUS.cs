using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietVongQuayOCungBUS
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
        /// <param name="_mVongQuay">Đối tượng ChiTietVongXoayOCungDTO</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemVongQuayOCung(myChiTietVongQuayOCungDTO _mVongQuay)
        {
            try
            {
                return myChiTietVongQuayOCungDAO.ThemVongQuay(_mVongQuay);
            }
            catch
            {
                throw;
            }
        }
    }
}
