using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongOCungBUS
    {
        /// <summary>
        /// Lấy thông tin dòng ổ cứng dựa vào mã ổ cứng
        /// </summary>
        /// <param name="_iMaChiTietDongOCung">mã ổ cứng</param>
        /// <returns></returns>
        public myChiTietDongOCungDTO LayChiTietDongOCung(int _iMaChiTietDongOCung)
        { return null; }

        /// <summary>
        /// Lất tất cả các dòng ổ cứng
        /// </summary>
        /// <returns>Danh sách dòng ổ cứng</returns>
        public List<myChiTietDongOCungDTO> LayChiTietDongOCung()
        {
            myChiTietDongOCungDAO chiTietDongOCung = new myChiTietDongOCungDAO();
            try
            {
                return chiTietDongOCung.LayChiTietDongOCung();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
