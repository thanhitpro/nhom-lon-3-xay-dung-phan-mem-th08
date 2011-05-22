using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myMucDichSuDungDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy Thông tin mục đích sử dụng dựa vào mã mục đích sử dung
        /// </summary>
        /// <param name="_iMaMucDichSuDung">Thông tin mã mục đích muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tượng MUCDICHSUDUNG
        ///     Thất bại: trả về null
        /// </returns>
        /// 
        public static MUCDICHSUDUNG LayMucDichSuDung(int _iMaMucDichSuDung)
        {
            try
            {
                MUCDICHSUDUNG _MucDichSuDung = m_eStoreDataContext.MUCDICHSUDUNGs.Single(temp => temp.MaMucDichSuDung == _iMaMucDichSuDung);
                return _MucDichSuDung;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách tất cả mục địch sử dụng có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về 1 danh sách tất cả mục đích sử dụng có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public static List<MUCDICHSUDUNG> LayMucDichSuDung()
        {
            try
            {
                var Query = from MucDich in m_eStoreDataContext.MUCDICHSUDUNGs select MucDich;
                List<MUCDICHSUDUNG> DSMucDichSuDung = new List<MUCDICHSUDUNG>();
                foreach (MUCDICHSUDUNG _MucDichSD in Query)
                    DSMucDichSuDung.Add(_MucDichSD);
                return DSMucDichSuDung;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
