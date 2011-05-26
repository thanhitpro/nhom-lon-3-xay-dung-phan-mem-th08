

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng card đồ họa BUS
    /// </summary>
    public class MyChiTietDongCardDoHoaBUS
    {
        /// <summary>
        /// Lấy thông tin card đồ họa từ mã card đồ họa
        /// </summary>
        /// <param name="maChiTietDongCardDoHoa">Mã card đồ họa</param>
        /// <returns>Thông tin chi tiết card đồ họa</returns>
        public myChiTietDongCardDoHoaDTO LayChiTietDongCardDoHoa(int maChiTietDongCardDoHoa)
        { 
            return null; 
        }

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
        /// <param name="tenCardDoHoa">Tên card đồ họa</param>
        /// <returns>trả về mã dòng card đồ họa</returns>
        public int LayChiTietDongCardDoHoa(string tenCardDoHoa)
        {
            try
            {
                return myChiTietDongCardDoHoaDAO.LayMaDongCardDoHoa(tenCardDoHoa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
