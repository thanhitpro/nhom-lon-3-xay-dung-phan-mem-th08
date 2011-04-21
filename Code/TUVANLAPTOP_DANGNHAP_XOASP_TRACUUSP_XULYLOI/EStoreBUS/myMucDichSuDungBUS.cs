using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myMucDichSuDungBUS
    {
        public myMucDichSuDungDTO LayMucDichSuDung(int _iMaMucDichSuDung)
        { return null; }

        public List<MUCDICHSUDUNG> LayMucDichSuDung()
        {
            try
            {
                return myMucDichSuDungDAO.LayMucDichSuDung();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
