using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongCPUDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lay thong tin cua CPU tu ma CPU
        /// </summary>
        /// <param name="_iMaChiTietDongCPU"></param>
        /// <returns></returns>
        public static myChiTietDongCPUDTO LayChiTietDongCPU(int _iMaChiTietDongCPU)
        {
            myChiTietDongCPUDTO chiTietCPU = null;

            var query = m_eStoreDataContext.CHITIETDONGCPUs.Single(cpu => cpu.MaDongCPU == _iMaChiTietDongCPU);
            if (query != null)
            {
                chiTietCPU = new myChiTietDongCPUDTO();
                chiTietCPU.STenDongCPU = query.TenDongCPU;
                chiTietCPU.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietCongNgheCPUDTO chiTietCNCPU = new myChiTietCongNgheCPUDTO();
                chiTietCNCPU.STenChiTietCongNgheCPU = query.CHITIETCONGNGHECPU.TenChiTietCongNgheCPU;
                chiTietCNCPU.FHeSo = (float)query.CHITIETCONGNGHECPU.HeSo;
                chiTietCPU.ChiTietCongNgheCPU = chiTietCNCPU;
            }

            return chiTietCPU;
        }
        /// <summary>
        /// Lay danh sach tat ca cac dong CPU
        /// </summary>
        /// <returns>Danh sách dòng CPU</returns>
        public List<myChiTietDongCPUDTO> LayChiTietDongCPU()
        {
            List<myChiTietDongCPUDTO> dsDongCPU = new List<myChiTietDongCPUDTO>();
            DataClasses1DataContext m_eStoreContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_eStoreContext.CHITIETDONGCPUs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGCPU cpu in query)
                {
                    myChiTietDongCPUDTO chiTietCPU = new myChiTietDongCPUDTO();
                    chiTietCPU.STenDongCPU = cpu.TenDongCPU;
                    chiTietCPU.NhaSanXuat = new myNhaSanXuatDTO(cpu.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCongNgheCPUDTO chiTietCNCPU = new myChiTietCongNgheCPUDTO();
                    chiTietCNCPU.STenChiTietCongNgheCPU = cpu.CHITIETCONGNGHECPU.TenChiTietCongNgheCPU;
                    chiTietCNCPU.FHeSo = (float)cpu.CHITIETCONGNGHECPU.HeSo;
                    chiTietCPU.ChiTietCongNgheCPU = chiTietCNCPU;
                    dsDongCPU.Add(chiTietCPU);
                }
                return dsDongCPU;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma dong CPU tu ten CPU
        /// </summary>
        /// <param name="TenCPU"> Ten CPU</param>
        /// <returns></returns>
        public static int LayMaDongCPU(string TenCPU)
        {
            int maDong = -1;
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            var query = from p in m_EStore.CHITIETDONGCPUs where p.TenDongCPU == TenCPU select p;
            if (query == null)
                return maDong;
            foreach (CHITIETDONGCPU laptop in query)
            {
                maDong = laptop.MaDongCPU;
                break;
            }
            return maDong;

        }
    }
}
