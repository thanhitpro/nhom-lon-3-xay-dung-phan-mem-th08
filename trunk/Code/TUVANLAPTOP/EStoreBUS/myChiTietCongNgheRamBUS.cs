using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietCongNgheRamBUS
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
        /// <param name="_mCTRAM">ChiTietCongNgheRAM muốn thêm mới</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exeception cho tầng trên xử lý
        /// </returns>
        public static bool ThemCongNgheRAM(myChiTietCongNgheRamDTO _mCNRAM)
        {
            try
            {
                return myChiTietCongNgheRamDAO.ThemCongNgheRAM(_mCNRAM);
            }
            catch
            {
                throw;
            }
        }
    }
}
