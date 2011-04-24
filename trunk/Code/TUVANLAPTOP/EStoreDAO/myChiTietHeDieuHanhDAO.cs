using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietHeDieuHanhDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lay thong tin cua he dieu hanh dua vao ma he dieu hanh
        /// </summary>
        /// <param name="_iMaDanhGia"></param>
        /// <returns></returns>
        public static myChiTietHeDieuHanhDTO LayChiTietHDH(int _iMaDanhGia)
        {
            try
            {
                myChiTietHeDieuHanhDTO chiTietHDH = null;
                var query = m_eStoreDataContext.CHITIETHEDIEUHANHs.Single(hdh => hdh.MaChiTietHeDieuHanh == _iMaDanhGia);
                if (query != null)
                {
                    chiTietHDH = new myChiTietHeDieuHanhDTO();
                    chiTietHDH.STenHeDieuHanh = query.TenHeDieuHanh;
                    chiTietHDH.FHeSo = (float)query.HeSo;
                }
                return chiTietHDH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin tất cả các HDH trong CSDL
        /// </summary>
        /// <returns></returns>
        public List<myChiTietHeDieuHanhDTO> LayChiTietHeDieuHanh()
        {
            List<myChiTietHeDieuHanhDTO> dsHDH = new List<myChiTietHeDieuHanhDTO>();
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStore.CHITIETHEDIEUHANHs select p;
                if (query == null)
                    return null;
                foreach (CHITIETHEDIEUHANH hdh in query)
                {
                    myChiTietHeDieuHanhDTO chiTietHDH = new myChiTietHeDieuHanhDTO();
                    chiTietHDH.STenHeDieuHanh = hdh.TenHeDieuHanh;
                    chiTietHDH.IMaHeDieuHanh = hdh.MaChiTietHeDieuHanh;
                    chiTietHDH.FHeSo = (float)hdh.HeSo;
                    dsHDH.Add(chiTietHDH);
                }
                return dsHDH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma he dieu hanh dua vao ten hdh
        /// </summary>
        /// <param name="_sTenHDH"></param>
        /// <returns></returns>
        public static int LayMaDongHeDieuHanh(string _sTenHDH)
        {
            try
            {
                int maHDH = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETHEDIEUHANHs where p.TenHeDieuHanh == _sTenHDH select p;
                if (query == null)
                    return maHDH;
                foreach (CHITIETHEDIEUHANH laptop in query)
                {
                    maHDH = laptop.MaChiTietHeDieuHanh;
                    break;
                }
                return maHDH;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
