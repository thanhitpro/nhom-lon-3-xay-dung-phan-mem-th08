using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongODiaQuangDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy thông tin chi tiết dòng Ổ quang dựa vào mã
        /// </summary>
        /// <param name="_iMaChiTietDongOQuang">Mã dòng ổ quang</param>
        /// <returns>
        ///     Thành công: trả về thông tin chi tiết dòng ổ quang có mã chỉ định
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongODiaQuangDTO LayChiTietDongODiaQuang(int _iMaChiTietDongODiaQuang)
        {
            try
            {
                myChiTietDongODiaQuangDTO chiTietOQuang = new myChiTietDongODiaQuangDTO();
                var query = m_eStoreDataContext.CHITIETDONGODIAQUANGs.Single(oquang => oquang.MaDongODiaQuang == _iMaChiTietDongODiaQuang);
                if (query != null)
                {
                    chiTietOQuang = new myChiTietDongODiaQuangDTO();
                    chiTietOQuang.STenDongODiaQuang = query.TenDongODiaQuang;
                    chiTietOQuang.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCacKhaNangODiaQuangDTO khaNangOQuang = new myChiTietCacKhaNangODiaQuangDTO();
                    khaNangOQuang.STenChiTietCacKhaNangODiaQuang = query.CHITIETCACKHANANGODIAQUANG.TenChiTietCacKhaNangODiaQuang;
                    khaNangOQuang.FHeSo = (float)query.CHITIETCACKHANANGODIAQUANG.HeSo;

                    chiTietOQuang.ChiTietCacKhaNangODiaQuang = khaNangOQuang;
                }

                return chiTietOQuang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy thông tin tất cả ỗ đĩa quang từ CSDL
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongODiaQuangDTO> LayChiTietDongODiaQuang()
        {
            List<myChiTietDongODiaQuangDTO> dsDiaQuang = new List<myChiTietDongODiaQuangDTO>();
            DataClasses1DataContext m_EstoreContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EstoreContext.CHITIETDONGODIAQUANGs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGODIAQUANG diaquang in query)
                {
                    myChiTietDongODiaQuangDTO chiTietOQuang = new myChiTietDongODiaQuangDTO();
                    chiTietOQuang.STenDongODiaQuang = diaquang.TenDongODiaQuang;
                    chiTietOQuang.IMaDongODiaQuang = diaquang.MaDongODiaQuang;
                    chiTietOQuang.NhaSanXuat = new myNhaSanXuatDTO(diaquang.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCacKhaNangODiaQuangDTO khaNangOQuang = new myChiTietCacKhaNangODiaQuangDTO();
                    khaNangOQuang.STenChiTietCacKhaNangODiaQuang = diaquang.CHITIETCACKHANANGODIAQUANG.TenChiTietCacKhaNangODiaQuang;
                    khaNangOQuang.FHeSo = (float)diaquang.CHITIETCACKHANANGODIAQUANG.HeSo;

                    chiTietOQuang.ChiTietCacKhaNangODiaQuang = khaNangOQuang;
                    dsDiaQuang.Add(chiTietOQuang);
                }
                return dsDiaQuang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma o dia quang dua vao ten o dia quang
        /// </summary>
        /// <param name="_sTenODiaQuang">ten o dia quang</param>
        /// <returns>ma o dia quang</returns>
        public static int LayMaDongODiaQuang(string _sTenODiaQuang)
        {
            try
            {
                int maODiaQuang = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGODIAQUANGs where p.TenDongODiaQuang == _sTenODiaQuang select p;
                if (query == null)
                    return maODiaQuang;
                foreach (CHITIETDONGODIAQUANG laptop in query)
                {
                    maODiaQuang = laptop.MaDongODiaQuang;
                    break;
                }
                return maODiaQuang;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
