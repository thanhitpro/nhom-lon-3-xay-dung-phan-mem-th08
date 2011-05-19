using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietCongNgheCPUBUS
    {
        /// <summary>
        /// Thêm công nghệ CPU
        /// </summary>
        /// <param name="_mCongNgheCPU">Đối tượng ChiTietCongNgheCPUDTO muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static int ThemCongNgheCPU(myChiTietCongNgheCPUDTO _mCongNgheCPU)
        {
            try
            {
                return myChiTietCongNgheCPUDAO.ThemCongNgheCPU(_mCongNgheCPU);
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
