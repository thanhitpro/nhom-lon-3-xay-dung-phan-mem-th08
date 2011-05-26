

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng pin BUS
    /// </summary>
    public class MyChiTietDongPinBUS
    {
        /// <summary>
        /// Lấy thông tin dòng phin dựa vào mã dòng PIN
        /// </summary>
        /// <param name="maChiTietDongPin">Mã chi tiết dòng pin</param>
        /// <returns>Chi tiết thông tin dòng pin</returns>
        public myChiTietDongPinDTO LayChiTietDongPin(int maChiTietDongPin)
        { 
            return null; 
        }

        /// <summary>
        /// Lấy thông tin tất cả các dòng PIN
        /// </summary>
        /// <returns>Danh sách tất cả các dòng PIN</returns>
        public List<myChiTietDongPinDTO> LayChiTietDongPin()
        {
            myChiTietDongPinDAO chiTietPin = new myChiTietDongPinDAO();
            try
            {
                return chiTietPin.LayChiTietDongPin();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy mã của pin dựa vào tên dòng Pin
        /// </summary>
        /// <param name="tenPin">Tên dòng pin</param>
        /// <returns>Mã dòng pin</returns>
        public int LayChiTietDongPin(string tenPin)
        {
            try
            {
                return myChiTietDongPinDAO.LayMaDongPin(tenPin);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
