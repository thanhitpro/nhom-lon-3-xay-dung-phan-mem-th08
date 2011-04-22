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

        public static List<NGHENGHIEP> LayNgheNghiep()
        {
            try
            {
                var Query = from NgheNghiep in m_eStoreDataContext.NGHENGHIEPs select NgheNghiep;
                List<NGHENGHIEP> DSNgheNghiep = new List<NGHENGHIEP>();
                foreach (NGHENGHIEP _NgheNghiep in Query)
                {
                    DSNgheNghiep.Add(_NgheNghiep);
                }
                return DSNgheNghiep;
               
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
