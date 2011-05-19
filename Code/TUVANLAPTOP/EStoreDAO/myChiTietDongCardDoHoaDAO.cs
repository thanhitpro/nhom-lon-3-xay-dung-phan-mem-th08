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
        /// Lấy thông tin dòng Card đồ họa từ mã 
        /// </summary>
        /// <param name="_iMaChiTietDongCardDoHoa">Mã Card đồ họa</param>
        /// <returns>
        ///     Thành công: trả về thông tin chi tiết đối tượng ChiTietCardDoHoaDTO
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongCardDoHoaDTO LayChiTietDongCardDoHoa(int _iMaChiTietDongCardDoHoa)
        {
            try
            {
                myChiTietDongCardDoHoaDTO chiTietDongCardDoHoa = null;

                var query = m_eStoreDataContext.CHITIETDONGCARDDOHOAs.Single(cardDoHoa => cardDoHoa.MaDongCardDoHoa == _iMaChiTietDongCardDoHoa);
                if (query != null)
                {
                    chiTietDongCardDoHoa = new myChiTietDongCardDoHoaDTO();
                    chiTietDongCardDoHoa.STenDongCardDoHoa = query.TenDongCardDoHoa;
                    chiTietDongCardDoHoa.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                    myChiTietBoNhoCardDoHoaDTO chiTietBoNhoCardDoHoa = new myChiTietBoNhoCardDoHoaDTO();
                    chiTietBoNhoCardDoHoa.STenChiTietCardDoHoa = query.CHITIETBONHOCARDDOHOA.TenChiTietBoNhoCardDoHoa;
                    chiTietBoNhoCardDoHoa.FHeSo = (float)query.CHITIETBONHOCARDDOHOA.HeSo;

                    chiTietDongCardDoHoa.ChiTietBoNhoCardDoHoa = chiTietBoNhoCardDoHoa;
                }

                return chiTietDongCardDoHoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy thông tin tất cả các dòng card đồ họa
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách dòng Card đồ họa hiện có hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public List<myChiTietDongCardDoHoaDTO> LayChiTietDongCardDoHoa()
        {
            DataClasses1DataContext m_EStoreContext = new DataClasses1DataContext();
            List<myChiTietDongCardDoHoaDTO> dsCardDoHoa = new List<myChiTietDongCardDoHoaDTO>();
            try
            {
                var query = from p in m_EStoreContext.CHITIETDONGCARDDOHOAs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGCARDDOHOA cardDoHoa in query)
                {
                    myChiTietDongCardDoHoaDTO chiTietDongCardDoHoa = new myChiTietDongCardDoHoaDTO();
                    chiTietDongCardDoHoa.STenDongCardDoHoa = cardDoHoa.TenDongCardDoHoa;
                    chiTietDongCardDoHoa.IMaDongCardDoHoa = cardDoHoa.MaDongCardDoHoa;
                    chiTietDongCardDoHoa.NhaSanXuat = new myNhaSanXuatDTO(cardDoHoa.NHASANXUAT.TenNhaSanXuat);

                    myChiTietBoNhoCardDoHoaDTO chiTietBoNhoCardDoHoa = new myChiTietBoNhoCardDoHoaDTO();
                    chiTietBoNhoCardDoHoa.STenChiTietCardDoHoa = cardDoHoa.CHITIETBONHOCARDDOHOA.TenChiTietBoNhoCardDoHoa;
                    chiTietBoNhoCardDoHoa.FHeSo = (float)cardDoHoa.CHITIETBONHOCARDDOHOA.HeSo;

                    chiTietDongCardDoHoa.ChiTietBoNhoCardDoHoa = chiTietBoNhoCardDoHoa;

                    dsCardDoHoa.Add(chiTietDongCardDoHoa);
                }
                return dsCardDoHoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy thông tin mã card đồ họa từ tên card đồ họa
        /// </summary>
        /// <param name="_sTenCardDoaHoa">Tên card đồ họa</param>
        /// <returns>Mã card đồ họa cần tra cứu</returns>
        public static int LayMaDongCardDoHoa(string _sTenCardDoHoa)
        {
            try
            {
                int maCardDoHoa = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGCARDDOHOAs where p.TenDongCardDoHoa == _sTenCardDoHoa select p;
                if (query == null)
                    return maCardDoHoa;
                foreach (CHITIETDONGCARDDOHOA laptop in query)
                {
                    maCardDoHoa = laptop.MaDongCardDoHoa;
                    break;
                }
                return maCardDoHoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
