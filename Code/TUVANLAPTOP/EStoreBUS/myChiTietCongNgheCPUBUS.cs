using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietCongNgheCPUBUS
    {
        /// <summary>
        /// Them Cong Nghe CPU:
        /// </summary>
        /// <param name="_mCongNgheCPU"></param>
        /// <returns></returns>
        public static int ThemCongNgheCPU(myChiTietCongNgheCPUDTO _mCongNgheCPU)
        {
            try
            {
                return myChiTietCongNgheCPUDAO.ThemCongNgheCPU(_mCongNgheCPU);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lay DS Cong Nghe:
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietCongNgheCPUDTO> LayDSCongNgheCPU()
        {
            try
            {
                return myChiTietCongNgheCPUDAO.LayDSCongNgheCPU();
            }
            catch
            {
                throw;
            }
        }
    }
}
