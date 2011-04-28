using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardDoHoaBUS
    {
        /// <summary>
        /// Lấy thông tin card đồ họa từ mã card đồ họa
        /// </summary>
        /// <param name="_iMaChiTietDongCardDoHoa">mã card đồ họa</param>
        /// <returns>thông tin card đồ họa</returns>
        public myChiTietDongCardDoHoaDTO LayChiTietDongCardDoHoa(int _iMaChiTietDongCardDoHoa)
        { return null; }

        /// <summary>
        /// Lấy thông tin tất cả các dòng card đồ họa
        /// </summary>
        /// <returns>Danh sách tất cả các dòng card đồ họa</returns>
        public List<myChiTietDongCardDoHoaDTO> LayChiTietDongCardDoHoa()
        {
            myChiTietDongCardDoHoaDAO chiTietDongCardDoHoa = new myChiTietDongCardDoHoaDAO();
            try
            {
                return chiTietDongCardDoHoa.LayChiTietDongCardDoHoa();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy mã dòng card đồ họa dựa vào tên card đồ họa
        /// </summary>
        /// <returns></returns>
        public int LayChiTietDongCardDoHoa(string m_tenCardDoHoa)
        {
            try
            {
                return myChiTietDongCardDoHoaDAO.LayMaDongCardDoHoa(m_tenCardDoHoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
