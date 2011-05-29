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
        /// Lấy danh sách công nghệ RAM
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách công nghệ RAM hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietCongNgheRamDTO> LayChiTietCongNgheRam()
        {
            try
            {
                List<myChiTietCongNgheRamDTO> dsCongNgheRam = new List<myChiTietCongNgheRamDTO>();
                foreach (CHITIETCONGNGHERAM boNho in m_eStoreDataContext.CHITIETCONGNGHERAMs)
                {
                    myChiTietCongNgheRamDTO ctCongNgheRam = new myChiTietCongNgheRamDTO();
                    ctCongNgheRam.STenCongNgheRam = boNho.TenCongNgheRam;
                    ctCongNgheRam.FHeSo = (float)boNho.HeSo;

                    dsCongNgheRam.Add(ctCongNgheRam);
                }
                return dsCongNgheRam;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm mới Công nghệ RAM
        /// </summary>
        /// <param name="_mCongNgheRAM">Thông tin công nghệ RAM muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemCongNgheRAM(myChiTietCongNgheRamDTO _mCongNgheRAM)
        {
            try
            {
                CHITIETCONGNGHERAM ctCongNgheRam = new CHITIETCONGNGHERAM();
                ctCongNgheRam.TenCongNgheRam = _mCongNgheRAM.STenCongNgheRam;
                ctCongNgheRam.HeSo = (float)_mCongNgheRAM.FHeSo;

                m_eStoreDataContext.CHITIETCONGNGHERAMs.InsertOnSubmit(ctCongNgheRam);
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
