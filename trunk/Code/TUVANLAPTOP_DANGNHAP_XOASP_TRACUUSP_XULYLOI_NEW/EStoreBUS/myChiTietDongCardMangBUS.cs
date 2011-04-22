using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardMangBUS
    {
        public myChiTietDongCardMangDTO LayChiTietDongCardMang(int _iMaChiTietDongCardMang)
        { return null; }
        /// <summary>
        /// Lấy thông tin tất cả các dòng card mạng
        /// </summary>
        /// <returns>danh sách các dòng card mạng</returns>
        public List<myChiTietDongCardMangDTO> LayChiTietDongCardMang()
        {
            myChiTietDongCardMangDAO chiTietCardMang = new myChiTietDongCardMangDAO();
            try
            {
                return chiTietCardMang.LayChiTietDongCardMang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
