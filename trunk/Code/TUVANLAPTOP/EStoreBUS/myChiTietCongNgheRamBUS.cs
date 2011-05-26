

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết công nghệ RAM BUS
    /// </summary>
    public class MyChiTietCongNgheRamBUS
    {
        /// <summary>
        /// Lấy danh sách Công nghệ RAM
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các ChiTietCongNgheRAMDTO
        ///     Thất bại: throw một exeception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietCongNgheRamDTO> LayChiTietCongNgheRam()
        {
            try
            {
                return myChiTietCongNgheRamDAO.LayChiTietCongNgheRam();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm chi tiết công nghệ RAM
        /// </summary>
        /// <param name="maCNRAM">ChiTietCongNgheRAM muốn thêm mới</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exeception cho tầng trên xử lý
        /// </returns>
        public static bool ThemCongNgheRAM(myChiTietCongNgheRamDTO maCNRAM)
        {
            try
            {
                return myChiTietCongNgheRamDAO.ThemCongNgheRAM(maCNRAM);
            }
            catch
            {
                throw;
            }
        }
    }
}
