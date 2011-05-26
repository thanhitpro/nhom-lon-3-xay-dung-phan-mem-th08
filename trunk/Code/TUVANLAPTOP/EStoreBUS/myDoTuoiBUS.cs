

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;

    /// <summary>
    /// Lớp độ tuổi BUS
    /// </summary>
    public class MyDoTuoiBUS
    {
        /// <summary>
        /// Lấy thông tin độ tuổi theo mã
        /// </summary>
        /// <param name="maDoTuoi">Thông tin mã độ tuổi muốn lấy</param>
        /// <return>trả về giá trị null</return>
        public static DOTUOI LayDoTuoi(int maDoTuoi)
        { 
            return null; 
        }

        /// <summary>
        /// Lấy danh sách tất cả dộ tuổi có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách tất cả độ tuổi có trong CSDL
        ///     Thất bại: trả về NULL
        /// </returns>
        public List<DOTUOI> LayDoTuoi()
        {
            try
            {
                return myDoTuoiDAO.LayDoTuoi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
