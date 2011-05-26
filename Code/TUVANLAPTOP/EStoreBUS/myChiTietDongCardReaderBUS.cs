

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng card Reader BUS
    /// </summary>
    public class MyChiTietDongCardReaderBUS
    {
        /// <summary>
        /// Lấy danh sách thông tin tất cả các dòng card reader
        /// </summary>
        /// <returns>
        ///     Thành công: Danh sách dòng card reader
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public List<myChiTietDongCardReaderDTO> LayChiTietDongCardReader()
        {
            myChiTietDongCardReaderDAO chiTietCardReader = new myChiTietDongCardReaderDAO();
            try
            {
                return chiTietCardReader.LayChiTietDongCardReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy mã cardreader
        /// </summary>
        /// <param name="tenCardReader">tên card reader</param>
        /// <returns>mã dòng card reader</returns>
        public int LayChiTietDongCardReader(string tenCardReader)
        {
            try
            {
                return myChiTietDongCardReaderDAO.LayMaDongCardReader(tenCardReader);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
