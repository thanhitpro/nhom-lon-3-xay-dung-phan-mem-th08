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
        public static MUCDICHSUDUNG LayMucDichSuDung(int _iMaMucDichSuDung)
        {
            MUCDICHSUDUNG _MucDichSuDung = m_eStoreDataContext.MUCDICHSUDUNGs.Single(temp => temp.MaMucDichSuDung == _iMaMucDichSuDung);
            return _MucDichSuDung;
        }

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
