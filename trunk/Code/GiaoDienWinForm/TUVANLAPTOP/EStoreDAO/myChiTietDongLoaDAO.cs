using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongLoaDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongLoaDTO LayChiTietDongLoa(int _iMaChiTietDongLoa)
        {
            myChiTietDongLoaDTO chiTietDongLoa = null;

            var query = m_eStoreDataContext.CHITIETDONGLOAs.Single(loa => loa.MaDongLoa == _iMaChiTietDongLoa);
            if (query != null)
            {
                chiTietDongLoa = new myChiTietDongLoaDTO();
                chiTietDongLoa.STenDongLoa = query.TenDongDongLoa;
                chiTietDongLoa.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);
                chiTietDongLoa.BCoMicro = BitConverter.GetBytes(query.CoMicro)[0];
            }

            return chiTietDongLoa;
        }

        public List<myChiTietDongLoaDTO> LayChiTietDongLoa()
        {
            return null;
        }
    }
}
