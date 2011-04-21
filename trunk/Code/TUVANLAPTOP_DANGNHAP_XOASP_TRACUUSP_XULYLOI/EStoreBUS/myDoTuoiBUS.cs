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
        public myDoTuoiDTO LayDoTuoi(int _iMaDoTuoi)
        { return null; }

        public List<DOTUOI> LayDoTuoi()
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
