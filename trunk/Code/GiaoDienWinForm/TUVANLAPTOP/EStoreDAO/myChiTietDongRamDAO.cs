using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    class myChiTietDongRamDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongRamDTO LayChiTietDongRam(int _iMaChiTietDongRam)
        {
            myChiTietDongRamDTO chiTietDongRam = null;

            var query = m_eStoreDataContext.CHITIETDONGRAMs.Single(ram => ram.MaDongRAM == _iMaChiTietDongRam);
            if (query != null)
            {
                chiTietDongRam = new myChiTietDongRamDTO();
                chiTietDongRam.STenDongRAM = query.TenDongRAM;
                chiTietDongRam.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietCongNgheRamDTO chiTietCNRam = new myChiTietCongNgheRamDTO();
                chiTietCNRam.STenCongNgheRam = query.CHITIETCONGNGHERAM.TenCongNgheRam;
                chiTietCNRam.FHeSo = (float)query.CHITIETCONGNGHERAM.HeSo;
                
                chiTietDongRam.ChiTietCongNgheRam = chiTietCNRam;

                myChiTietBoNhoRamDTO chiTietBoNhoRAM = new myChiTietBoNhoRamDTO();
                chiTietBoNhoRAM.STenChiTietBoNhoRam = query.CHITIETBONHORAM.TenChiTietBoNhoRAM;
                chiTietBoNhoRAM.FHeSo = (float)query.CHITIETBONHORAM.HeSo;

                chiTietDongRam.ChiTietBoNhoRam = chiTietBoNhoRAM;
            }

            return chiTietDongRam;
        }

        public List<myChiTietDongRamDTO> LayChiTietDongRam()
        {
            return null;
        }
    }
}
