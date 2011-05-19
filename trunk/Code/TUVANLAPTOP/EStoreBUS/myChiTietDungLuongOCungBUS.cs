using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDungLuongOCungBUS
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
        /// <param name="_mDungLuong"></param>
        /// <returns></returns>
        public static bool ThemDungLuongOCung(myChiTietDungLuongOCungDTO _mDungLuong)
        {
            try
            {
                return myChiTietDungLuongOCungDAO.ThemDungLuongOCung(_mDungLuong);
            }
            catch
            {
                throw;
            }
        }
    }
}
