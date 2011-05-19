using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EStoreDTO;

namespace EStoreDAO
{
    public class myDanhGiaDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Hàm lấy danh sách các Đánh Giá hiện có dựa vào mã
        /// </summary>
        /// <param name="_iMaDanhGia">Mã đánh giá</param>
        /// <returns>
        ///     Thành công: danh sách mã đánh giá
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myDanhGiaDTO LayDanhGia(int _iMaDanhGia)
        {
            try
            {
                myDanhGiaDTO danhGia = null;
                var query = m_eStoreDataContext.DANHGIAs.Single(dg => dg.MaDanhGia == _iMaDanhGia);
                if (query != null)
                {
                    danhGia = new myDanhGiaDTO();
                    danhGia.ITongDiem = query.TongDiem;
                    danhGia.ISoNguoiDanhGia = query.SoNguoiDanhGia;
                }
                return danhGia;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
