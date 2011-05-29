//-----------------------------------------------------------------------
// <copyright file="MyChiTietCongNgheCPUBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết công nghệ CPU BUS
    /// </summary>
    public class MyChiTietCongNgheCPUBUS
    {
        /// <summary>
        /// Thêm công nghệ CPU
        /// </summary>
        /// <param name="maCongNgheCPU">Đối tượng ChiTietCongNgheCPUDTO muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static int ThemCongNgheCPU(myChiTietCongNgheCPUDTO maCongNgheCPU)
        {
            try
            {
                return myChiTietCongNgheCPUDAO.ThemCongNgheCPU(maCongNgheCPU);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lấy danh sách công nghệ CPU
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các ChiTietCongNgheCPUDTO
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietCongNgheCPUDTO> LayDSCongNgheCPU()
        {
            try
            {
                return myChiTietCongNgheCPUDAO.LayDSCongNgheCPU();
            }
            catch
            {
                throw;
            }
        }
    }
}
