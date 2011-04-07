using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongManHinhDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongManHinhDTO LayChiTietDongManHinh(int _iMaChiTietDongManHinh)
        {
            myChiTietDongManHinhDTO chiTietManHinh = null;

            var query = m_eStoreDataContext.CHITIETDONGMANHINHs.Single(manhinh => manhinh.MaDongManHinh == _iMaChiTietDongManHinh);
            if (query != null)
            {
                chiTietManHinh = new myChiTietDongManHinhDTO();
                chiTietManHinh.STenDongManHinh = query.TenDongManHinh;
                chiTietManHinh.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietKichThuocManHinhDTO chiTietKichThuoc = new myChiTietKichThuocManHinhDTO();
                chiTietKichThuoc.STenChiTietKichThuocManHinh = query.CHITIETKICHTHUOCMANHINH.TenChiTietKichThuocManHinh;
                chiTietKichThuoc.FHeSo = (float)query.CHITIETKICHTHUOCMANHINH.HeSo;

                chiTietManHinh.ChiTietKichThuocManHinh = chiTietKichThuoc;
            }

            return chiTietManHinh;
        }

        public List<myChiTietDongManHinhDTO> LayChiTietDongManHinh()
        {
            return null;
        }
    }
}
