using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace EStoreDAO
{
    public class myChiTietDongCardDoHoaDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        public static myChiTietDongCardDoHoaDTO LayChiTietDongCardDoHoa(int _iMaChiTietDongCardDoHoa)
        {
            myChiTietDongCardDoHoaDTO chitietDongCardDoHoa = null;

            var query = m_eStoreDataContext.CHITIETDONGCARDDOHOAs.Single(cardDoHoa => cardDoHoa.MaDongCardDoHoa == _iMaChiTietDongCardDoHoa);
            if (query != null)
            {
                chitietDongCardDoHoa = new myChiTietDongCardDoHoaDTO();
                chitietDongCardDoHoa.STenDongCardDoHoa = query.TenDongCardDoHoa;
                chitietDongCardDoHoa.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietBoNhoCardDoHoaDTO chiTietBoNhoCardDoHoa = new myChiTietBoNhoCardDoHoaDTO();
                chiTietBoNhoCardDoHoa.STenChiTietCardDoHoa = query.CHITIETBONHOCARDDOHOA.TenChiTietBoNhoCardDoHoa;
                chiTietBoNhoCardDoHoa.FHeSo = (float)query.CHITIETBONHOCARDDOHOA.HeSo;

                chitietDongCardDoHoa.ChiTietBoNhoCardDoHoa = chiTietBoNhoCardDoHoa;
            }

            return chitietDongCardDoHoa;
        }

        public List<myChiTietDongCardDoHoaDTO> LayChiTietDongCardDoHoa()
        {
            return null;
        }
    }
}
