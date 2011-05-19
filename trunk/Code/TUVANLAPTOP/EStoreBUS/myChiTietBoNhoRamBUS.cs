using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietBoNhoRamBUS
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
        /// <param name="_mCTRAM">Đối tượng ChiTietBoNhoRamDTO</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw 1 exception cho tần trên xử lý
        /// </returns>
        public static bool ThemBoNhoRAM(myChiTietBoNhoRamDTO _mCTRAM)
        {
            try
            {
                return myChiTietBoNhoRamDAO.ThemBoNhoRAM(_mCTRAM);
            }
            catch
            {
                throw;
            }
        }
    }
}
