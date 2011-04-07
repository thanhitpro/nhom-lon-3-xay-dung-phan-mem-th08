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

        public List<myChiTietDongCPUDTO> LayChiTietDongCPU()
        {
            return null;
        }
    }
}
