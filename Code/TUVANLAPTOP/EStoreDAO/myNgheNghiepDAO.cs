using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myNgheNghiepDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy Thông tin nghề nghiệp dựa vào mã nghề nghiệp
        /// </summary>
        /// <param name="_iMaNgheNghiep">Thông tin mã nghề nghiệp muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tượng NGHENGHIEP
        ///     Thất bại: trả về null
        /// </returns>
        public static NGHENGHIEP LayNgheNghiep(int _iMaNgheNghiep)
        {
            try
            {
                NGHENGHIEP _NgheNghiep = m_eStoreDataContext.NGHENGHIEPs.Single(Nghe => Nghe.MaNgheNghiep == _iMaNgheNghiep);
                return _NgheNghiep;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
          
        }

        /// <summary>
        /// Lấy danh sách tất cả các nghề nghiệp
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách tất cả Nghề nghiệp có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public static List<NGHENGHIEP> LayNgheNghiep()
        {
            try
            {
                var Query = from NgheNghiep in m_eStoreDataContext.NGHENGHIEPs select NgheNghiep;
                List<NGHENGHIEP> dsNgheNghiep = new List<NGHENGHIEP>();
                foreach (NGHENGHIEP _NgheNghiep in Query)
                {
                    dsNgheNghiep.Add(_NgheNghiep);
                }
                return dsNgheNghiep;
               
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
