using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongLoaBUS
    {
        /// <summary>
        ///  Lấy thông tin dòng loa dựa vào mã dòng loa
        /// </summary>
        /// <param name="_iMaChiTietDongLoa">Mã dòng loa</param>
        /// <returns>Dòng loa cần tra cứu</returns>
        public myChiTietDongLoaDTO LayChiTietDongLoa(int _iMaChiTietDongLoa)
        { return null; }

        /// <summary>
        /// Lấy thông tin tất cả các dòng Loa
        /// </summary>
        /// <returns>Danh sách tất cả các dòng Loa</returns>
        public List<myChiTietDongLoaDTO> LayChiTietDongLoa()
        {
            myChiTietDongLoaDAO chiTietDongLoaDAO = new myChiTietDongLoaDAO();
            try
            {
                return chiTietDongLoaDAO.LayChiTietDongLoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// lấy mã dòng Loa dựa vào tên loa
        /// </summary>
        /// <returns></returns>
        public int LayChiTietDongLoa(string m_tenLoa)
        {
            try
            {
                return myChiTietDongLoaDAO.LayMaDongLoa(m_tenLoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
