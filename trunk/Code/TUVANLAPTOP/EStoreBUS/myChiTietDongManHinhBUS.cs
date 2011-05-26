

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng màn hình BUS
    /// </summary>
    public class MyChiTietDongManHinhBUS
    {
        /// <summary>
        /// Lấy thông tin chi tiết dòng màn hình dựa vào mã màn hình 
        /// </summary>
        /// <param name="maChiTietDongManHinh">mã màn hình</param>
        /// <returns>trả về giá trị null</returns>
        public myChiTietDongManHinhDTO LayChiTietDongManHinh(int maChiTietDongManHinh)
        { 
            return null; 
        }

        /// <summary>
        /// Lấy thông tin chi tiết tất cả các dòng màn hình
        /// </summary>
        /// <returns>danh sách chi tiết dòng màn hình</returns>
        public List<myChiTietDongManHinhDTO> LayChiTietDongManHinh()
        {
            myChiTietDongManHinhDAO chiTietManHinhDAO = new myChiTietDongManHinhDAO();
            try
            {
                return chiTietManHinhDAO.LayChiTietDongManHinh();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy mã dòng màn hình dựa vào tên dòng màn hình
        /// </summary>
        /// <param name="tenManHinh">Tên màn hình</param>
        /// <returns>mã dòng màn hình</returns>
        public int LayChiTietDongManHinh(string tenManHinh)
        {
            try
            {
                return myChiTietDongManHinhDAO.LayMaDongManHinh(tenManHinh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
