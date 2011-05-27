//-----------------------------------------------------------------------
// <copyright file="MyChiTietDongRamBUS.cs" company="NHOM LON NHOM 3">
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
    /// Lớp chi tiết dòng RAM BUS
    /// </summary>
    public class MyChiTietDongRamBUS
    {
        /// <summary>
        /// Lấy thông tin dòng RAM dựa vào Mã Dòng RAM
        /// </summary>
        /// <param name="maChiTietDongRam">Mã dòng RAM</param>
        /// <returns>Lớp đối tượng chứa chi tiết dòng RAM cần tra cứu</returns>
        public myChiTietDongRamDTO LayChiTietDongRam(int maChiTietDongRam)
        {
            return null;
        }

        /// <summary>
        /// Lấy thông tin chi tiết tất cả các dòng RAM trong CSDL
        /// </summary>
        /// <returns>Danh sách các dòng RAM</returns>
        public List<myChiTietDongRamDTO> LayChiTietDongRam()
        {
            myChiTietDongRamDAO chiTietDongRamDAO = new myChiTietDongRamDAO();
            List<myChiTietDongRamDTO> list = new List<myChiTietDongRamDTO>();
            try
            {
                list = chiTietDongRamDAO.LayChiTietDongRam();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return list;
        }

        /// <summary>
        /// Lấy mã dòng Ram dựa vào tên dòng Ram
        /// </summary>
        /// <param name="tenRam">tên dòng RAM</param>
        /// <returns>trả về mã dòng sản phẩm</returns>
        public int LayChiTietDongRam(string tenRam)
        {
            try
            {
                return myChiTietDongRamDAO.LayMaDongRam(tenRam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
