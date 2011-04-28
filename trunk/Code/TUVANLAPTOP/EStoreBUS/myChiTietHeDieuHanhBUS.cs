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
        /// Lấy thông tin hệ điều hành dựa vào mã chi tiết HDH
        /// </summary>
        /// <param name="_iMaChiTietHeDieuHanh">mã chi tiết HDH</param>
        /// <returns>Thông tin HDH</returns>
        public myChiTietHeDieuHanhDTO LayChiTietHeDieuHanh(int _iMaChiTietHeDieuHanh)
        { return null; }

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
    }
}
