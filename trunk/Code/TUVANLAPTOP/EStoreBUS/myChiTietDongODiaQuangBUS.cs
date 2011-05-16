using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongODiaQuangBUS
    {
        /// <summary>
        /// Lấy thông tin ổ đĩa quang dựa vào mã ỗ đĩa quang
        /// </summary>
        /// <param name="_iMaChiTietDongODiaQuang">Mã ổ đĩa quang</param>
        /// <returns></returns>
        public myChiTietDongODiaQuangDTO LayChiTietDongODiaQuang(int _iMaChiTietDongODiaQuang)
        { return null; }

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
        /// <returns></returns>
        public int LayChiTietDongODiaQuang(string m_tenOQuang)
        {
            try
            {
                return myChiTietDongODiaQuangDAO.LayMaDongODiaQuang(m_tenOQuang);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
