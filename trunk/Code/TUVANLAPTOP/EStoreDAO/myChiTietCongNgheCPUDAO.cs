using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietCongNgheCPUDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Thêm Công Nghệ CPU
        /// </summary>
        /// <param name="_mCongNgheCPU">Thông tin công nghệ CPU muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về mã Công nghệ mới được thêm mới
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static int ThemCongNgheCPU(myChiTietCongNgheCPUDTO _mCongNgheCPU)
        {
            try
            {
                CHITIETCONGNGHECPU congNgheCPU = new CHITIETCONGNGHECPU();
                congNgheCPU.TenChiTietCongNgheCPU = _mCongNgheCPU.STenChiTietCongNgheCPU;
                congNgheCPU.HeSo = _mCongNgheCPU.FHeSo;

                m_eStoreDataContext.CHITIETCONGNGHECPUs.InsertOnSubmit(congNgheCPU);
                m_eStoreDataContext.SubmitChanges();

                return congNgheCPU.MaChiTietCongNgheCPU;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lấy danh sách công nghệ CPU
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách công nghệ CPU hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietCongNgheCPUDTO> LayDSCongNgheCPU()
        {
            List<myChiTietCongNgheCPUDTO> dsCongNgheCPU = new List<myChiTietCongNgheCPUDTO>();
            try
            {
                foreach (CHITIETCONGNGHECPU ctCN in m_eStoreDataContext.CHITIETCONGNGHECPUs)
                {
                    myChiTietCongNgheCPUDTO congNghe = new myChiTietCongNgheCPUDTO();
                    congNghe.STenChiTietCongNgheCPU = ctCN.TenChiTietCongNgheCPU;
                    congNghe.FHeSo = (float)ctCN.HeSo;
                    congNghe.IMaChiTietCN = ctCN.MaChiTietCongNgheCPU;

                    dsCongNgheCPU.Add(congNghe);
                }

                return dsCongNgheCPU;
            }
            catch
            {
                return dsCongNgheCPU;
            }
        }
    }
}
