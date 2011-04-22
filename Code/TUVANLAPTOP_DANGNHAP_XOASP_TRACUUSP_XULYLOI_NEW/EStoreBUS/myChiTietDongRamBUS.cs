using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongRamBUS
    {
        /// <summary>
        /// Lấy thông tin dòng RAM dựa vào Mã Dòng RAM
        /// </summary>
        /// <param name="_iMaChiTietDongRam">Mã dòng RAM</param>
        /// <returns>Lớp đối tượng chứa chi tiết dòng RAM cần tra cứu</returns>
        public myChiTietDongRamDTO LayChiTietDongRam(int _iMaChiTietDongRam)
        { return null; }
        /// <summary>
        /// Lấy thông tin chi tiết tất cả các dòng RAM trong CSDL
        /// </summary>
        /// <returns>Danh sách các dòng RAM</returns>
        public List<myChiTietDongRamDTO> LayChiTietDongRam()
        {
            myChiTietDongRamDAO chiTietDongRamDAO = new myChiTietDongRamDAO();
            List<myChiTietDongRamDTO> list = new List<myChiTietDongRamDTO>();
            try
            {
                list = chiTietDongRamDAO.LayChiTietDongRam();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }
    }
}
