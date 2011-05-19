using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCPUBUS
    {

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
        /// <returns></returns>
        public int LayChiTietDongCPU(string m_tenCPU)
        {
            try
            {
                return myChiTietDongCPUDAO.LayMaDongCPU(m_tenCPU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Them moi dong dong CPU:
        /// </summary>
        /// <param name="_mChiTietDongCPU"></param>
        /// <returns></returns>
        public static bool ThemDongCPU(myChiTietDongCPUDTO _mChiTietDongCPU)
        {
            try
            {
                return myChiTietDongCPUDAO.ThemDongCPU(_mChiTietDongCPU);
            }
            catch
            {
                throw;
            }
        }

        public static bool KiemTraTonTaiDongCPU(string _sName)
        {
            try
            {
                return myChiTietDongCPUDAO.KiemTraTonTaiDongCPU(_sName);
            }
            catch
            {
                throw;
            }
        }
    }
}
