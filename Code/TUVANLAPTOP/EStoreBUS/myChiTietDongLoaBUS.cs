//-----------------------------------------------------------------------
// <copyright file="MyChiTietDongLoaBUS.cs" company="NHOM LON NHOM 3">
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
    /// Lớp chi tiết dòng loa BUS
    /// </summary>
    public class MyChiTietDongLoaBUS
    {
        /// <summary>
        ///  Lấy thông tin dòng loa dựa vào mã dòng loa
        /// </summary>
        /// <param name="maChiTietDongLoa">Mã dòng loa</param>
        /// <returns>Dòng loa cần tra cứu</returns>
        public myChiTietDongLoaDTO LayChiTietDongLoa(int maChiTietDongLoa)
        { 
            return null; 
        }

        /// <summary>
        /// Lấy thông tin tất cả các dòng Loa
        /// </summary>
        /// <returns>Danh sách tất cả các dòng Loa</returns>
        public List<myChiTietDongLoaDTO> LayChiTietDongLoa()
        {
            myChiTietDongLoaDAO chiTietDongLoaDAO = new myChiTietDongLoaDAO();
            try
            {
                return chiTietDongLoaDAO.LayChiTietDongLoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// lấy mã dòng Loa dựa vào tên loa
        /// </summary>
        /// <param name="tenLoa">Tên của dòng loa</param>
        /// <returns>mã dòng loa</returns>
        public int LayChiTietDongLoa(string tenLoa)
        {
            try
            {
                return myChiTietDongLoaDAO.LayMaDongLoa(tenLoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
