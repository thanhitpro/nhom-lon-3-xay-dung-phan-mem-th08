using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietBoNhoRamDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lay DS Bo Nho RAM:
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietBoNhoRamDTO> LayChiTietBoNhoRam()
        {
            try
            {
                List<myChiTietBoNhoRamDTO> dsBoNhoRam = new List<myChiTietBoNhoRamDTO>();
                foreach (CHITIETBONHORAM boNho in m_eStoreDataContext.CHITIETBONHORAMs)
                {
                    myChiTietBoNhoRamDTO ctBoNhoRAM = new myChiTietBoNhoRamDTO();
                    ctBoNhoRAM.STenChiTietBoNhoRam = boNho.TenChiTietBoNhoRAM;
                    ctBoNhoRAM.FHeSo = (float)boNho.HeSo;

                    dsBoNhoRam.Add(ctBoNhoRAM);
                }

                return dsBoNhoRam;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Them bo nho RAM:
        /// </summary>
        /// <param name="_mBoNho"></param>
        /// <returns></returns>
        public static bool ThemBoNhoRAM(myChiTietBoNhoRamDTO _mBoNho)
        {
            try
            {
                CHITIETBONHORAM ctBoNhoRAM = new CHITIETBONHORAM();
                ctBoNhoRAM.TenChiTietBoNhoRAM = _mBoNho.STenChiTietBoNhoRam;
                ctBoNhoRAM.HeSo = (float)_mBoNho.FHeSo;

                m_eStoreDataContext.CHITIETBONHORAMs.InsertOnSubmit(ctBoNhoRAM);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Thêm mới bộ nhớ RAM thất bại !", ex);
            }
        }
    }
}
