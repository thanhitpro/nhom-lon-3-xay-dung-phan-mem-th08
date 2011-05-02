using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietBoNhoCardDoHoaBUS
    {
        /// <summary>
        /// Lấy danh sách bộ nhớ Đồ họa
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietBoNhoCardDoHoaDTO> LayChiTietBoNhoCarMH()
        {
            try
            {
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
        /// <param name="_mBoNhoCardMH"></param>
        /// <returns></returns>
        public static bool ThemBoNhoCardMH(myChiTietBoNhoCardDoHoaDTO _mBoNhoCardMH)
        {
            try
            {
                return myChiTietBoNhoCardDoHoaDAO.ThemBoNhoCardMH(_mBoNhoCardMH);
            }
            catch
            {
                throw;
            }
        }
    }
}
