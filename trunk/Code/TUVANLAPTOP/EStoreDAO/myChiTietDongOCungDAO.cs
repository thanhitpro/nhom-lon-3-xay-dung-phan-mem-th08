using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongOCungDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy thông tin chi tiết dòng Ổ cứng dựa vào mã dòng Ổ cứng
        /// </summary>
        /// <param name="_iMaChiTietDongOCung">Mã dòng ổ cứng</param>
        /// <returns>
        ///     Thành công: trả về thông tin chi tiết dòng ổ cứng có mã chỉ định
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongOCungDTO LayChiTietDongOCung(int _iMaChiTietDongOCung)
        {
            try
            {
                myChiTietDongOCungDTO chiTietOCung = null;

                var query = m_eStoreDataContext.CHITIETDONGOCUNGs.Single(ocung => ocung.MaDongOCung == _iMaChiTietDongOCung);

                if (query != null)
                {
                    chiTietOCung = new myChiTietDongOCungDTO();
                    chiTietOCung.STenDongOCung = query.TenDongOCung;
                    chiTietOCung.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                    myChiTietVongQuayOCungDTO chiTietVongQuay = new myChiTietVongQuayOCungDTO();
                    chiTietVongQuay.STenChiTietVongQuayOCung = query.CHITIETVONGQUAYOCUNG.TenChiTietVongQuayOCung;
                    chiTietVongQuay.FHeSo = (float)query.CHITIETVONGQUAYOCUNG.HeSo;
                    chiTietOCung.ChiTietVongQuayOCung = chiTietVongQuay;

                    myChiTietDungLuongOCungDTO chiTietDungLuong = new myChiTietDungLuongOCungDTO();
                    chiTietDungLuong.STenChiTietDungLuongOCung = query.CHITIETDUNGLUONGOCUNG.TenChiTietDungLuongOCung;
                    chiTietDungLuong.FHeSo = (float)query.CHITIETDUNGLUONGOCUNG.HeSo;
                    chiTietOCung.ChiTietDungLuongOCung = chiTietDungLuong;
                }

                return chiTietOCung;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay chi tiet tat cac thong tin dong O Cung
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongOCungDTO> LayChiTietDongOCung()
        {
            List<myChiTietDongOCungDTO> dsOCung = new List<myChiTietDongOCungDTO>();
            DataClasses1DataContext m_EStoreContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStoreContext.CHITIETDONGOCUNGs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGOCUNG ocung in query)
                {
                    myChiTietDongOCungDTO chiTietOCung = new myChiTietDongOCungDTO();
                    chiTietOCung.IMaDongOCung = ocung.MaDongOCung;
                    chiTietOCung.STenDongOCung = ocung.TenDongOCung;
                    chiTietOCung.NhaSanXuat = new myNhaSanXuatDTO(ocung.NHASANXUAT.TenNhaSanXuat);

                    myChiTietVongQuayOCungDTO chiTietVongQuay = new myChiTietVongQuayOCungDTO();
                    chiTietVongQuay.STenChiTietVongQuayOCung = ocung.CHITIETVONGQUAYOCUNG.TenChiTietVongQuayOCung;
                    chiTietVongQuay.FHeSo = (float)ocung.CHITIETVONGQUAYOCUNG.HeSo;
                    chiTietOCung.ChiTietVongQuayOCung = chiTietVongQuay;

                    myChiTietDungLuongOCungDTO chiTietDungLuong = new myChiTietDungLuongOCungDTO();
                    chiTietDungLuong.STenChiTietDungLuongOCung = ocung.CHITIETDUNGLUONGOCUNG.TenChiTietDungLuongOCung;
                    chiTietDungLuong.FHeSo = (float)ocung.CHITIETDUNGLUONGOCUNG.HeSo;
                    chiTietOCung.ChiTietDungLuongOCung = chiTietDungLuong;
                    dsOCung.Add(chiTietOCung);
                }
                return dsOCung;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma dong o cung dua vao ten o cung
        /// </summary>
        /// <param name="TenRam"></param>
        /// <returns></returns>
        public static int LayMaDongOCung(string TenoCung)
        {
            try
            {
                int maDongOCung = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGOCUNGs where p.TenDongOCung == TenoCung select p;
                if (query == null)
                    return maDongOCung;
                foreach (CHITIETDONGOCUNG laptop in query)
                {
                    maDongOCung = laptop.MaDongOCung;
                    break;
                }
                return maDongOCung;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
