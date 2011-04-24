using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietTrongLuongBUS
    {
        /// <summary>
        /// Lấy thông tinc của Trọng lượng của Laptop dựa vào mã trọng lượng
        /// </summary>
        /// <param name="_iMaChiTietTrongLuong">Mã trọng lượng</param>
        /// <returns></returns>
        public myChiTietTrongLuongDTO LayChiTietTrongLuong(int _iMaChiTietTrongLuong)
        { return null; }

        /// <summary>
        /// Lấy tất cả các loại trong lượng của laptop
        /// </summary>
        /// <returns>Danh sách tất cả các loại trọng lượng của Laptop</returns>
        public List<myChiTietTrongLuongDTO> LayChiTietTrongLuong()
        {
            myChiTietTrongLuongDAO chiTietTL = new myChiTietTrongLuongDAO();
            try
            {
                return chiTietTL.LayChiTietTrongLuong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
