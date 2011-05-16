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
        /// <summary>
        /// Lấy mã của một loại trọng lượng dựa vào giá trị trọng lượng đó
        /// </summary>
        /// <returns></returns>
        public int LayChiTietTrongLuong(string m_giaTriTL)
        {
            try
            {
                return myChiTietTrongLuongDAO.LayMaChiTietTrongLuong(float.Parse(m_giaTriTL));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
