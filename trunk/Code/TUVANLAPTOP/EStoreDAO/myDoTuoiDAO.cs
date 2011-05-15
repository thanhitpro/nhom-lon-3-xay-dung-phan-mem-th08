using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myDoTuoiDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static DOTUOI LayDoTuoi(int _iMaDoTuoi)
        {
            DOTUOI _DoTuoi = m_eStoreDataContext.DOTUOIs.Single(temp => temp.MaDoTuoi == _iMaDoTuoi);

            return _DoTuoi;
        }

        public static List<DOTUOI> LayDoTuoi()
        {
            try
            {
                var Query = from _DoTuoi in m_eStoreDataContext.DOTUOIs select _DoTuoi;
                List<DOTUOI> dsDoTuoi = new List<DOTUOI>();
                foreach (DOTUOI _DOTUOI in Query)
                    dsDoTuoi.Add(_DOTUOI);
                return dsDoTuoi;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
