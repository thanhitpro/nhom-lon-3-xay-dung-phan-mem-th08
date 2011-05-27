//-----------------------------------------------------------------------
// <copyright file="MyChiTietTrongLuongBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết trọng lượng BUS
    /// </summary>
    public class MyChiTietTrongLuongBUS
    {
        /// <summary>
        /// Lấy thông tinc của Trọng lượng của Laptop dựa vào mã trọng lượng
        /// </summary>
        /// <param name="maChiTietTrongLuong">Mã trọng lượng</param>
        /// <returns>trả về giá trị null</returns>
        public myChiTietTrongLuongDTO LayChiTietTrongLuong(int maChiTietTrongLuong)
        { 
            return null; 
        }

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
        /// <param name="giaTriTL">Giá trị trọng lượng</param>
        /// <returns>Mã chi tiết giá trị trọng lượng</returns>
        public int LayChiTietTrongLuong(string giaTriTL)
        {
            try
            {
                return myChiTietTrongLuongDAO.LayMaChiTietTrongLuong(float.Parse(giaTriTL));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
