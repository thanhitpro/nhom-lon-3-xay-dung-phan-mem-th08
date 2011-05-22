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

        /// <summary>
        /// Lấy thông tin độ tuổi theo mã
        /// </summary>
        /// <param name="_iMaDoTuoi">Thông tin mã độ tuổi muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tượng DOTUOI
        ///     Thất bại: trả về null
        /// </returns>
        public static DOTUOI LayDoTuoi(int _iMaDoTuoi)
        {
            DOTUOI _DoTuoi = m_eStoreDataContext.DOTUOIs.Single(temp => temp.MaDoTuoi == _iMaDoTuoi);

            return _DoTuoi;
        }


        /// <summary>
        /// Lấy danh sách tất cả dộ tuổi có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách tất cả độ tuổi có trong CSDL
        ///     Thất bại: trả về NULL
        /// </returns>
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
