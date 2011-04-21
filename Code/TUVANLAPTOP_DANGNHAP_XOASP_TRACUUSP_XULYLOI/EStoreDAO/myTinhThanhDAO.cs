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
        public static TINHTHANH LayTinhThanh(int _iMaTinhThanh)
        {
            TINHTHANH _TinhThanh = m_eStoreDataContext.TINHTHANHs.Single(temp => temp.MaTinhThanh == _iMaTinhThanh);
            return _TinhThanh;
        }

        public static List<TINHTHANH> LayTinhThanh()
        {
            try
            {
                var Query = from _TinhThanh in m_eStoreDataContext.TINHTHANHs select _TinhThanh;
                List<TINHTHANH> DSTinhThanh = new List<TINHTHANH>();
                foreach (TINHTHANH _tinhthanh in Query)
                    DSTinhThanh.Add(_tinhthanh);
                return DSTinhThanh;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
