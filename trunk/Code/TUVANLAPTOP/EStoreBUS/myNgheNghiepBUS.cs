using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myNgheNghiepBUS
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
