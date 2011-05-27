//-----------------------------------------------------------------------
// <copyright file="MyNhaSanXuatBUS.cs" company="NHOM LON NHOM 3">
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
    /// class nhà sản xuất BUS
    /// </summary>
    public class MyNhaSanXuatBUS
    {
        /// <summary>
        /// lấy thông tin nhà sản xuất từ mã nhà sản xuất (Chưa sửa dụng)
        /// </summary>
        /// <param name="maNhaSanXuat"> mã nhà sản xuất</param>
        /// <returns>trả về giá trị null</returns>
        public myNhaSanXuatDTO LayNhaSanXuat(int maNhaSanXuat)
        {
            return null;
        }

        /// <summary>
        /// Lấy danh sách nhà SX
        /// </summary>
        /// <returns>Danh sách tất cả các nhà SX</returns>
        public List<myNhaSanXuatDTO> LayNhaSanXuat()
        {
            myNhaSanXuatDAO nhaSX = new myNhaSanXuatDAO();
            try
            {
                return nhaSX.LayDSNhaSX();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy mã nhà xuất dựa vào tên nhà sx
        /// </summary>
        /// <param name="tenNhaSX"> tên nhà sản xuất</param>
        /// <returns> trả về mã nhà sản xuất</returns>
        public int LayNhaSanXuat(string tenNhaSX)
        {
            try
            {
                return myNhaSanXuatDAO.LayMaNhaSanXuat(tenNhaSX);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
