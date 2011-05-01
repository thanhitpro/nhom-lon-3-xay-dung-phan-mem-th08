using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietCongNgheRamDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy danh sách công nghệ RAM:
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietCongNgheRamDTO> LayChiTietCongNgheRam()
        {
            try
            {
                List<myChiTietCongNgheRamDTO> dsCongNgheRam = new List<myChiTietCongNgheRamDTO>();
                foreach (CHITIETCONGNGHERAM boNho in m_eStoreDataContext.CHITIETCONGNGHERAMs)
                {
                    myChiTietCongNgheRamDTO ctCNRAM = new myChiTietCongNgheRamDTO();
                    ctCNRAM.STenCongNgheRam = boNho.TenCongNgheRam;
                    ctCNRAM.FHeSo = (float)boNho.HeSo;

                    dsCongNgheRam.Add(ctCNRAM);
                }

                return dsCongNgheRam;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm mới Công nghệ RAM:
        /// </summary>
        /// <param name="_mBoNho"></param>
        /// <returns></returns>
        public static bool ThemCongNgheRAM(myChiTietCongNgheRamDTO _mCongNgheRAM)
        {
            try
            {
                CHITIETCONGNGHERAM ctCNRAM = new CHITIETCONGNGHERAM();
                ctCNRAM.TenCongNgheRam = _mCongNgheRAM.STenCongNgheRam;
                ctCNRAM.HeSo = (float)_mCongNgheRAM.FHeSo;

                m_eStoreDataContext.CHITIETCONGNGHERAMs.InsertOnSubmit(ctCNRAM);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm mới bộ nhớ RAM thất bại !", ex);
            }
        }
    }
}
