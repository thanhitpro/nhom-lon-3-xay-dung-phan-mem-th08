using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietHeDieuHanhBUS
    {
        /// <summary>
        /// Lấy thông tin tất cả các hệ điều hành
        /// </summary>
        /// <returns>Danh sách tất cả các HDH</returns>
        public List<myChiTietHeDieuHanhDTO> LayChiTietHeDieuHanh()
        {
            myChiTietHeDieuHanhDAO chiTietHDHDAO = new myChiTietHeDieuHanhDAO();
            try
            {
                return chiTietHDHDAO.LayChiTietHeDieuHanh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy mã hệ điều hành dựa vào tên hệ điều hành
        /// </summary>
        /// <returns></returns>
        public int LayChiTietHeDieuHanh(string m_tenHDH)
        {
            try
            {
                return myChiTietHeDieuHanhDAO.LayMaDongHeDieuHanh(m_tenHDH);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách hệ điều hành
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách các hệ điều hành hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietHeDieuHanhDTO> LayDSHeDieuHanh()
        {
            try
            {
                return myChiTietHeDieuHanhDAO.LayDSHeDieuHanh();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm hệ điều hành mới
        /// </summary>
        /// <param name="_mHDH"></param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemMoiHDH(myChiTietHeDieuHanhDTO _mHDH)
        {
            try
            {
                return myChiTietHeDieuHanhDAO.ThemHDH(_mHDH);
            }
            catch
            {
                throw;
            }
        }
    }
}
