using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietBoNhoCardDoHoaDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy ds Bộ Nhớ Card MH
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietBoNhoCardDoHoaDTO> LayDSBoNhoMH()
        {
            try
            {
                List<myChiTietBoNhoCardDoHoaDTO> dsBoNhoCardMH = new List<myChiTietBoNhoCardDoHoaDTO>();
                foreach (CHITIETBONHOCARDDOHOA boNhoCardMH in m_eStoreDataContext.CHITIETBONHOCARDDOHOAs)
                {
                    myChiTietBoNhoCardDoHoaDTO ctBoNhoCardMH = new myChiTietBoNhoCardDoHoaDTO();
                    ctBoNhoCardMH.STenChiTietCardDoHoa = boNhoCardMH.TenChiTietBoNhoCardDoHoa;
                    ctBoNhoCardMH.FHeSo = (float)boNhoCardMH.HeSo;

                    dsBoNhoCardMH.Add(ctBoNhoCardMH);
                }

                return dsBoNhoCardMH;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm bộ nhớ Card MH:
        /// </summary>
        /// <param name="_mBoNhoCardMH"></param>
        /// <returns></returns>
        public static bool ThemBoNhoCardMH(myChiTietBoNhoCardDoHoaDTO _mBoNhoCardMH)
        {
            try
            {
                CHITIETBONHOCARDDOHOA ctBoNhoCardMH = new CHITIETBONHOCARDDOHOA();
                ctBoNhoCardMH.TenChiTietBoNhoCardDoHoa = _mBoNhoCardMH.STenChiTietCardDoHoa;
                ctBoNhoCardMH.HeSo = (float)_mBoNhoCardMH.FHeSo;

                m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.InsertOnSubmit(ctBoNhoCardMH);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm mới card màn hình thất bại !", ex);
            }
        }
    }
}
