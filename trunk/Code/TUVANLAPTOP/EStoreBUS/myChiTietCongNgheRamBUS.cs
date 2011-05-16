using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietCongNgheRamBUS
    {
        /// <summary>
        /// Lấy danh sách Công nghệ RAM:
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietCongNgheRamDTO> LayChiTietCongNgheRam()
        {
            try
            {
                return myChiTietCongNgheRamDAO.LayChiTietCongNgheRam();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm chi tiết công nghệ RAM:
        /// </summary>
        /// <param name="_mCTRAM"></param>
        /// <returns></returns>
        public static bool ThemCongNgheRAM(myChiTietCongNgheRamDTO _mCNRAM)
        {
            try
            {
                return myChiTietCongNgheRamDAO.ThemCongNgheRAM(_mCNRAM);
            }
            catch
            {
                throw;
            }
        }
    }
}
