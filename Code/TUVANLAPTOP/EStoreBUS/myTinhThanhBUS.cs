

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;

    /// <summary>
    /// Đối tượng tỉnh thành
    /// </summary>
    public class MyTinhThanhBUS
    {
        /// <summary>
        /// Lấy danh sách toàn bộ tỉnh thành có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về 1 danh sách các tỉnh thành có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public List<TINHTHANH> LayTinhThanh()
        {
            try
            {
                return myTinhThanhDAO.LayTinhThanh();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
