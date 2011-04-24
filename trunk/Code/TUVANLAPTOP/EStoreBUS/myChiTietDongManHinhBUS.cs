using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongManHinhBUS
    {
        /// <summary>
        /// Lấy thông tin chi tiết dòng màn hình dựa vào mã màn hình 
        /// </summary>
        /// <param name="_iMaChiTietDongManHinh">mã màn hình</param>
        /// <returns></returns>
        public myChiTietDongManHinhDTO LayChiTietDongManHinh(int _iMaChiTietDongManHinh)
        { return null; }

        /// <summary>
        /// Lấy thông tin chi tiết tất cả các dòng màn hình
        /// </summary>
        /// <returns></returns>
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
    }
}
