using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietBoNhoRamBUS
    {
        /// <summary>
        /// Lấy danh sách bộ nhớ RAM:
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietBoNhoRamDTO> LayChiTietBoNhoRam()
        {
            try
            {
                return myChiTietBoNhoRamDAO.LayChiTietBoNhoRam();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm chi tiết bộ nhớ RAM:
        /// </summary>
        /// <param name="_mCTRAM"></param>
        /// <returns></returns>
        public static bool ThemBoNhoRAM(myChiTietBoNhoRamDTO _mCTRAM)
        {
            try
            {
                return myChiTietBoNhoRamDAO.ThemBoNhoRAM(_mCTRAM);
            }
            catch
            {
                throw;
            }
        }
    }
}
