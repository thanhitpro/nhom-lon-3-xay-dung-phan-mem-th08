using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myTinhThanhBUS
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
