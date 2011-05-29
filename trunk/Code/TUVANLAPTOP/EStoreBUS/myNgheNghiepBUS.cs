//-----------------------------------------------------------------------
// <copyright file="MyNgheNghiepBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    /// <summary>
    /// Class MyNgheNghiepBUS sử dụng giao tiếp với MyNgheNghiepDAO
    /// </summary>

    public class MyNgheNghiepBUS
    {
        /// <summary>
        /// Lấy danh sách tất cả các nghề nghiệp
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách tất cả Nghề nghiệp có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public List<NGHENGHIEP> LayNgheNghiep()
        {
            try
            {
                return myNgheNghiepDAO.LayNgheNghiep();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
