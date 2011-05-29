//-----------------------------------------------------------------------
// <copyright file="MyMucDichSuDungBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;

    /// <summary>
    /// Lớp mục đích sử dụng BUS
    /// </summary>
    public class MyMucDichSuDungBUS
    {
        /*public myMucDichSuDungDTO LayMucDichSuDung(int _iMaMucDichSuDung)
        { return null; }*/

        /// <summary>
        /// Lấy danh sách tất cả mục địch sử dụng có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về 1 danh sách tất cả mục đích sử dụng có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public List<MUCDICHSUDUNG> LayMucDichSuDung()
        {
            try
            {
                return myMucDichSuDungDAO.LayMucDichSuDung();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
