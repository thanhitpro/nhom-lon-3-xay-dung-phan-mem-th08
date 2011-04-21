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
            var Query = from _DoTuoi in m_eStoreDataContext.DOTUOIs select _DoTuoi;
            List<DOTUOI> DSDoTuoi = new List<DOTUOI>();
            foreach (DOTUOI _DOTUOI in Query)
                DSDoTuoi.Add(_DOTUOI);
            return DSDoTuoi;
        }
    }
}
