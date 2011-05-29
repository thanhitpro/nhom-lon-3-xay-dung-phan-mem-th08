using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myTinhThanhDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy thông tin tỉnh thành theo mã
        /// </summary>
        /// <param name="_iMaTinhThanh">Thông tin mã tĩnh thành muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tượng TINHTHANH
        ///     Thất bại: trả về null
        /// </returns>
        public static TINHTHANH LayTinhThanh(int _iMaTinhThanh)
        {
            try
            {
                TINHTHANH _TinhThanh = m_eStoreDataContext.TINHTHANHs.Single(temp => temp.MaTinhThanh == _iMaTinhThanh);
                return _TinhThanh;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách toàn bộ tỉnh thành có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về 1 danh sách các tỉnh thành có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public static List<TINHTHANH> LayTinhThanh()
        {
            try
            {
                var Query = from _TinhThanh in m_eStoreDataContext.TINHTHANHs select _TinhThanh;
                List<TINHTHANH> dsTinhThanh = new List<TINHTHANH>();
                foreach (TINHTHANH _tinhthanh in Query)
                    dsTinhThanh.Add(_tinhthanh);
                return dsTinhThanh;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
