using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietKichThuocManHinhBUS
    {
        /// <summary>
        /// Lấy danh sách kích thước màn hình
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietKichThuocManHinhDTO> LayDSKichThuocManHinh()
        {
            try
            {
                return myChiTietKichThuocManHinhDAO.LayDSKichThuocManHinh();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm mới kích thước màn hình
        /// </summary>
        /// <param name="_mKichThuoc"></param>
        /// <returns></returns>
        public static bool ThemMoiKichThuocMH(myChiTietKichThuocManHinhDTO _mKichThuoc)
        {
            try
            {
                return myChiTietKichThuocManHinhDAO.ThemKichThuocManHinh(_mKichThuoc);
            }
            catch
            {
                throw;
            }
        }
    }
}
