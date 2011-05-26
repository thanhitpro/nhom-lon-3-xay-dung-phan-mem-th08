

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;

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
