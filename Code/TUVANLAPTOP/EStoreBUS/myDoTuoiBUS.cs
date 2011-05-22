using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myDoTuoiBUS
    {
        /// <summary>
        /// Lấy thông tin độ tuổi theo mã
        /// </summary>
        /// <param name="_iMaDoTuoi">Thông tin mã độ tuổi muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tượng DOTUOI
        ///     Thất bại: trả về null
        /// </returns>
        /// 
        public static DOTUOI LayDoTuoi(int _iMaDoTuoi)
        { return null; }

        /// <summary>
        /// Lấy danh sách tất cả dộ tuổi có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách tất cả độ tuổi có trong CSDL
        ///     Thất bại: trả về NULL
        /// </returns>
        public  List<DOTUOI> LayDoTuoi()
        {
            try
            {
                return myDoTuoiDAO.LayDoTuoi();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
