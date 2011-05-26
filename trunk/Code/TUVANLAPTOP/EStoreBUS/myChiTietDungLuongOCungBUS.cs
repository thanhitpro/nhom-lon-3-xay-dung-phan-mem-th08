

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dung lượng ổ cứng BUS
    /// </summary>
    public class MyChiTietDungLuongOCungBUS
    {
        /// <summary>
        /// Lấy danh sách các dung lượng ổ cứng hiện có
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các loại dung lượng ổ cứng hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietDungLuongOCungDTO> LayChiTietDungLuongOCung()
        {
            try
            {
                return myChiTietDungLuongOCungDAO.LayDSDungLuongOCung();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm dung lượng Ổ cứng mới:
        /// </summary>
        /// <param name="maDungLuong">Mã Dung lượng ổ cứng</param>
        /// <returns>True khi thêm dung lượng ổ cứng thành công, ngược lại false</returns>
        public static bool ThemDungLuongOCung(myChiTietDungLuongOCungDTO maDungLuong)
        {
            try
            {
                return myChiTietDungLuongOCungDAO.ThemDungLuongOCung(maDungLuong);
            }
            catch
            {
                throw;
            }
        }
    }
}
