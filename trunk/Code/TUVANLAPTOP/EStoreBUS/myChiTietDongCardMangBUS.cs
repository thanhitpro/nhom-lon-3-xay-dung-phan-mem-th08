
namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng card mạng BUS
    /// </summary>
    public class MyChiTietDongCardMangBUS
    {
        /// <summary>
        /// Lấy thông tin tất cả các dòng card mạng
        /// </summary>
        /// <returns>Danh sách các dòng card mạng</returns>
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
        
        /// <summary>
        /// Lấy chi tiết dùng card mạng
        /// </summary>
        /// <param name="tencardmang">Tên card mạng</param>
        /// <returns>Mã dòng card mạng</returns>
        public int LayChiTietDongCardMang(string tencardmang)
        {
            try
            {
                return myChiTietDongCardMangDAO.LayMaDongCardMang(tencardmang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
