using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongPinBUS
    {
        /// <summary>
        /// Lấy thông tin dòng phin dựa vào mã dòng PIN
        /// </summary>
        /// <param name="_iMaChiTietDongPin"></param>
        /// <returns>Chi tiết thông tin dòng pin</returns>
        public myChiTietDongPinDTO LayChiTietDongPin(int _iMaChiTietDongPin)
        { return null; }
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
    }
}
