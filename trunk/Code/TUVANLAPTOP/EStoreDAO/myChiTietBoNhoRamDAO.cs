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
        /// Lấy danh sách bộ nhớ RAM
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách bộ nhớ RAM hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
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
        /// Thêm mới bộ nhớ RAM
        /// </summary>
        /// <param name="_mBoNho">Thông tin đối tượng cần thêm mới</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
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
