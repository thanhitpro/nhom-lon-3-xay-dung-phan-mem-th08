using System.Collections.Generic;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietBoNhoCardDoHoaBUS
    {
        /// <summary>
        /// Lấy danh sách bộ nhớ Đồ họa
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách ChiTietBoNhoCardDoHoaDTO
        ///     Thất bại: throw một exception để tầng trên xử lý
        /// </returns>
        public static List<myChiTietBoNhoCardDoHoaDTO> LayDanhSachChiTietBoNhoCardMH()
        {
            try
            {
                myChiTietBoNhoCardDoHoaDAO myChiTietBoNhoCardDoHoaDAO = new myChiTietBoNhoCardDoHoaDAO();
                return myChiTietBoNhoCardDoHoaDAO.LayDSBoNhoMH();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm mới bộ nhớ Card MH
        /// </summary>
        /// <param name="_mBoNhoCardMH">Đối tượng ChiTietBoNhoCardDoHoaDTO muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception
        /// </returns>
        public static bool ThemBoNhoCardMH(myChiTietBoNhoCardDoHoaDTO _mBoNhoCardMH)
        {
            try
            {
                myChiTietBoNhoCardDoHoaDAO myChiTietBoNhoCardDoHoaDAO = new myChiTietBoNhoCardDoHoaDAO();
                return myChiTietBoNhoCardDoHoaDAO.ThemBoNhoCardMH(_mBoNhoCardMH);
            }
            catch
            {
                throw;
            }
        }
    }
}
