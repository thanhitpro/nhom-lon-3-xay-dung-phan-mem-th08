

namespace EStoreBUS
{
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp giao dịch BUS
    /// </summary>
    public class MyGiaoDichBUS
    {
        /// <summary>
        /// Thêm giao dịch
        /// </summary>
        /// <param name="giaoDich">Đối tượng giao dịch cần thêm</param>
        /// <returns>True nếu thêm thành công, ngược lại trả về false</returns>
        public static bool ThemGiaoDich(GIAODICH giaoDich)
        {
            return myGiaoDichDAO.themGiaoDich(giaoDich);
        }

        /// <summary>
        /// Lấy giao dịch
        /// </summary>
        /// <param name="maGiaoDich">mã giao dịch</param>
        /// <returns>trẩ về giá trị null</returns>
        public myGiaoDichDTO LayGiaoDich(int maGiaoDich)
        {
            return null;
        }

        /// <summary>
        /// Lấy danh sách giao dịch
        /// </summary>
        /// <returns>trả về giá trị null</returns>
        public List<myGiaoDichDTO> LayGiaoDich()
        {
            return null;
        }
    }
}
