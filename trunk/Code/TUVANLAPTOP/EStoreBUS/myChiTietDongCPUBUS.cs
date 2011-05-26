

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng CPU
    /// </summary>
    public class MyChiTietDongCPUBUS
    {
        /// <summary>
        /// Them moi dong dong CPU:
        /// </summary>
        /// <param name="maChiTietDongCPU">Mã chi tiết dòng CPU</param>
        /// <returns>true nếu thêm dòng CPU thành công, ngược lại là false</returns>
        public static bool ThemDongCPU(myChiTietDongCPUDTO maChiTietDongCPU)
        {
            try
            {
                return myChiTietDongCPUDAO.ThemDongCPU(maChiTietDongCPU);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Kiểm tra tồn tại dòng CPU
        /// </summary>
        /// <param name="name">tên của dòng CPU</param>
        /// <returns>nếu tồn tại trả về true ngược lại trả về false</returns>
        public static bool KiemTraTonTaiDongCPU(string name)
        {
            try
            {
                return myChiTietDongCPUDAO.KiemTraTonTaiDongCPU(name);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lấy thông tin tất cả dòng CPU
        /// </summary>
        /// <returns>
        ///     Thành công: Danh sách dòng CPU
        ///     Thất bại: Throw một exception cho tầng trên xử lý
        /// </returns>
        public List<myChiTietDongCPUDTO> LayChiTietDongCPU()
        {
            myChiTietDongCPUDAO dsDongCPU = new myChiTietDongCPUDAO();
            try
            {
                return dsDongCPU.LayChiTietDongCPU();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy mã dòng CPU dựa vào tên dòng CPU
        /// </summary>
        /// <param name="tenCPU">tên của dòng CPU</param>
        /// <returns>mã dòng CPU</returns>
        public int LayChiTietDongCPU(string tenCPU)
        {
            try
            {
                return myChiTietDongCPUDAO.LayMaDongCPU(tenCPU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
