//-----------------------------------------------------------------------
// <copyright file="MyChiTietDongOCungBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng ổ cứng BUS
    /// </summary>
    public class MyChiTietDongOCungBUS
    {
        /// <summary>
        /// Lấy thông tin dòng ổ cứng dựa vào mã ổ cứng
        /// </summary>
        /// <param name="maChiTietDongOCung">mã dòng ổ cứng</param>
        /// <returns>trả về giá trị null</returns>
        public myChiTietDongOCungDTO LayChiTietDongOCung(int maChiTietDongOCung)
        { 
            return null; 
        }

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

        /// <summary>
        /// Lấy mã của một dòng ổ cứng dựa vào tên ổ cứng
        /// </summary>
        /// <param name="tenOCung">Tên ổ cứng</param>
        /// <returns>mã dòng ổ cứng</returns>
        public int LayChiTietDongOCung(string tenOCung)
        {
            try
            {
                return myChiTietDongOCungDAO.LayMaDongOCung(tenOCung);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
