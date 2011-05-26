

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng ổ đĩa quang BUS
    /// </summary>
    public class MyChiTietDongODiaQuangBUS
    {
        /// <summary>
        /// Lấy thông tin ổ đĩa quang dựa vào mã ỗ đĩa quang
        /// </summary>
        /// <param name="maChiTietDongODiaQuang">Mã ổ đĩa quang</param>
        /// <returns>trả về giá trị null</returns>
        public myChiTietDongODiaQuangDTO LayChiTietDongODiaQuang(int maChiTietDongODiaQuang)
        { 
            return null; 
        }

        /// <summary>
        /// Lấy thông tin tất cả các dòng ỗ đĩa quang
        /// </summary>
        /// <returns>danh sách tất cả các dòng ỗ đĩa quang</returns>
        public List<myChiTietDongODiaQuangDTO> LayChiTietDongODiaQuang()
        {
            myChiTietDongODiaQuangDAO chiTietDongDQ = new myChiTietDongODiaQuangDAO();
            try
            {
                return chiTietDongDQ.LayChiTietDongODiaQuang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin mã ổ đĩa quang dựa vào tên ỗ đĩa quang
        /// </summary>
        /// <param name="tenOQuang">Tên ổ đĩa quang</param>
        /// <returns>Mã dòng ổ đĩa quang</returns>
        public int LayChiTietDongODiaQuang(string tenOQuang)
        {
            try
            {
                return myChiTietDongODiaQuangDAO.LayMaDongODiaQuang(tenOQuang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
