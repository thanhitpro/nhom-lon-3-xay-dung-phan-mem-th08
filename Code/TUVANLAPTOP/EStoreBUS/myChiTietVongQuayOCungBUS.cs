using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietVongQuayOCungBUS
    {
        /// <summary>
        /// Lấy danh sách Vong Quay:
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietVongQuayOCungDTO> LayChiTietVongQuayOCung()
        {
            try
            {
                return myChiTietVongQuayOCungDAO.LayDSVongQuayOCung();
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm vòng quay ổ cứng
        /// </summary>
        /// <param name="_mVongQuay"></param>
        /// <returns></returns>
        public static bool ThemVongQuayOCung(myChiTietVongQuayOCungDTO _mVongQuay)
        {
            try
            {
                return myChiTietVongQuayOCungDAO.ThemVongQuay(_mVongQuay);
            }
            catch
            {
                throw;
            }
        }
    }
}
