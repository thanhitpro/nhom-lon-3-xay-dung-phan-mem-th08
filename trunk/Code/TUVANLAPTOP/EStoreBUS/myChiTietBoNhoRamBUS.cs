

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết bộ nhớ RAM BUS
    /// </summary>
    public class MyChiTietBoNhoRamBUS
    {
        /// <summary>
        /// Lấy danh sách bộ nhớ RAM:
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách ChiTietBoNhoRAMDTO
        ///     Thất bại: throw 1 exception cho tần trên xử lý
        /// </returns>
        public static List<myChiTietBoNhoRamDTO> LayChiTietBoNhoRam()
        {
            try
            {
                return myChiTietBoNhoRamDAO.LayChiTietBoNhoRam();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm chi tiết bộ nhớ RAM:
        /// </summary>
        /// <param name="mCTRAM">Đối tượng ChiTietBoNhoRamDTO</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw 1 exception cho tần trên xử lý
        /// </returns>
        public static bool ThemBoNhoRAM(myChiTietBoNhoRamDTO mCTRAM)
        {
            try
            {
                return myChiTietBoNhoRamDAO.ThemBoNhoRAM(mCTRAM);
            }
            catch
            {
                throw;
            }
        }
    }
}
