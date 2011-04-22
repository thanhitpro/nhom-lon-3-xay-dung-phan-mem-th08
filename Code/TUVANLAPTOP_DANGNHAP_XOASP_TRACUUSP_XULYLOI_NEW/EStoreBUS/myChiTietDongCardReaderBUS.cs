using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardReaderBUS
    {
        public myChiTietDongCardReaderDTO LayChiTietDongCardReader(int _iMaChiTietDongCardReader)
        { return null; }

        /// <summary>
        /// Lấy danh sách thông tin tất cả các dòng card reader
        /// </summary>
        /// <returns>danh sách dòng card reader</returns>
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
    }
}
