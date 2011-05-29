using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietVongQuayOCungDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy danh sách vòng quay ổ cứng hiện có:
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách vòng quay ổ cứng hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietVongQuayOCungDTO> LayDSVongQuayOCung()
        {
            try
            {
                List<myChiTietVongQuayOCungDTO> dsVongQuay = new List<myChiTietVongQuayOCungDTO>();
                foreach (CHITIETVONGQUAYOCUNG vongQuay in m_eStoreDataContext.CHITIETVONGQUAYOCUNGs)
                {
                    myChiTietVongQuayOCungDTO ctVongQuay = new myChiTietVongQuayOCungDTO();
                    ctVongQuay.STenChiTietVongQuayOCung = vongQuay.TenChiTietVongQuayOCung;
                    ctVongQuay.FHeSo = (float)vongQuay.HeSo;

                    dsVongQuay.Add(ctVongQuay);
                }

                return dsVongQuay;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm vòng quay ổ cứng
        /// </summary>
        /// <param name="_mVongQuay">Vòng xoay ổ cứng mới cần thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemVongQuay(myChiTietVongQuayOCungDTO _mVongQuay)
        {
            try
            {
                CHITIETVONGQUAYOCUNG ctVongQuay = new CHITIETVONGQUAYOCUNG();
                ctVongQuay.TenChiTietVongQuayOCung = _mVongQuay.STenChiTietVongQuayOCung;
                ctVongQuay.HeSo = (float)_mVongQuay.FHeSo;

                m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.InsertOnSubmit(ctVongQuay);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm mới vòng quay ổ cứng thất bại !", ex);
            }
        }
    }
}
