using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardMangBUS
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
        /// 
        /// </summary>
        /// <returns></returns>
        public int LayChiTietDongCardMang( string m_tencardmang)
        {
            
            try
            {
               return  myChiTietDongCardMangDAO.LayMaDongCardMang(m_tencardmang);    
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
