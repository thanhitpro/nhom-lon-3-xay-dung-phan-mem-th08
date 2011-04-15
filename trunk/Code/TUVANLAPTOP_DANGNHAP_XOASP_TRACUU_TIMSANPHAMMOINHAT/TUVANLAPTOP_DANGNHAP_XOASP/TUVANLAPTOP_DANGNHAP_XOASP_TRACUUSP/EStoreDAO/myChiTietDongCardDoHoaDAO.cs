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
        /// <summary>
        /// Lay thong tin card do hoa tu ma card do hoa
        /// </summary>
        /// <param name="_iMaChiTietDongCardDoHoa">ma card do hoa</param>
        /// <returns></returns>
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
        /// <summary>
        /// Lay thong tin tat ca cac dong card do hoa
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongCardDoHoaDTO> LayChiTietDongCardDoHoa()
        {
            DataClasses1DataContext m_EStoreContext = new DataClasses1DataContext();
            List<myChiTietDongCardDoHoaDTO> dsCardDoHoa = new List<myChiTietDongCardDoHoaDTO>();
            var query = from p in m_EStoreContext.CHITIETDONGCARDDOHOAs select p;
            if (query == null)
                return null;
            foreach (CHITIETDONGCARDDOHOA carddohoa in query)
            {
                myChiTietDongCardDoHoaDTO chitietDongCardDoHoa = new myChiTietDongCardDoHoaDTO();
                chitietDongCardDoHoa.STenDongCardDoHoa = carddohoa.TenDongCardDoHoa;
                chitietDongCardDoHoa.NhaSanXuat = new myNhaSanXuatDTO(carddohoa.NHASANXUAT.TenNhaSanXuat);

                myChiTietBoNhoCardDoHoaDTO chiTietBoNhoCardDoHoa = new myChiTietBoNhoCardDoHoaDTO();
                chiTietBoNhoCardDoHoa.STenChiTietCardDoHoa = carddohoa.CHITIETBONHOCARDDOHOA.TenChiTietBoNhoCardDoHoa;
                chiTietBoNhoCardDoHoa.FHeSo = (float)carddohoa.CHITIETBONHOCARDDOHOA.HeSo;

                chitietDongCardDoHoa.ChiTietBoNhoCardDoHoa = chiTietBoNhoCardDoHoa;

                dsCardDoHoa.Add(chitietDongCardDoHoa);
            }
            return dsCardDoHoa;
        }
        public static int LayMaDongCardDoHoa(string _sTenCardDoaHoa)
        {
            int maCardDiaHoa = -1;
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            var query = from p in m_EStore.CHITIETDONGCARDDOHOAs where p.TenDongCardDoHoa == _sTenCardDoaHoa select p;
            if (query == null)
                return maCardDiaHoa;
            foreach (CHITIETDONGCARDDOHOA laptop in query)
            {
                maCardDiaHoa = laptop.MaDongCardDoHoa;
                break;
            }
            return maCardDiaHoa;

        }
    }
}
