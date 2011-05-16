using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietTrongLuongDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// lay thong tin trong luong dua vao ma chi tiet trong luong
        /// </summary>
        /// <param name="_iMaChiTietTrongLuong"></param>
        /// <returns></returns>
        public static myChiTietTrongLuongDTO LayChiTietTrongLuong(int _iMaChiTietTrongLuong)
        {
            try
            {
                myChiTietTrongLuongDTO chiTietTrongLuong = null;

                var query = m_eStoreDataContext.CHITIETTRONGLUONGs.Single(trongluong => trongluong.MaChiTietTrongLuong == _iMaChiTietTrongLuong);
                if (query != null)
                {
                    chiTietTrongLuong = new myChiTietTrongLuongDTO();
                    chiTietTrongLuong.FGiaTriTrongLuong = (float)query.GiaTriTrongLuong;

                    myChiTietLoaiTrongLuongDTO chiTietLoaiTL = new myChiTietLoaiTrongLuongDTO();
                    chiTietLoaiTL.STenLoaiTrongLuong = query.CHITIETLOAITRONGLUONG.TenLoaiTrongLuong;
                    chiTietLoaiTL.IGiaTriTrongLuong = query.CHITIETLOAITRONGLUONG.GiaTriTrongLuong.Value;
                    chiTietLoaiTL.FHeSo = (float)query.CHITIETLOAITRONGLUONG.HeSo;

                    chiTietTrongLuong.ChiTietLoaiTrongLuong = chiTietLoaiTL;
                }

                return chiTietTrongLuong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lay tat cac thong tin trong luong trong csdl
        /// </summary>
        /// <returns></returns>
        public List<myChiTietTrongLuongDTO> LayChiTietTrongLuong()
        {
            List<myChiTietTrongLuongDTO> dsTL = new List<myChiTietTrongLuongDTO>();
            DataClasses1DataContext m_Estote = new DataClasses1DataContext();
            try
            {
                var query = from p in m_eStoreDataContext.CHITIETTRONGLUONGs select p;
                if (query == null)
                    return null;
                foreach (CHITIETTRONGLUONG tl in query)
                {
                    myChiTietTrongLuongDTO chiTietTrongLuong = new myChiTietTrongLuongDTO();
                    chiTietTrongLuong.FGiaTriTrongLuong = (float)tl.GiaTriTrongLuong;
                    chiTietTrongLuong.IMaCHiTietTrongLuong = tl.MaChiTietTrongLuong;
                    myChiTietLoaiTrongLuongDTO chiTietLoaiTL = new myChiTietLoaiTrongLuongDTO();
                    chiTietLoaiTL.STenLoaiTrongLuong = tl.CHITIETLOAITRONGLUONG.TenLoaiTrongLuong;
                    chiTietLoaiTL.IGiaTriTrongLuong = tl.CHITIETLOAITRONGLUONG.GiaTriTrongLuong.Value;
                    chiTietLoaiTL.FHeSo = (float)tl.CHITIETLOAITRONGLUONG.HeSo;

                    chiTietTrongLuong.ChiTietLoaiTrongLuong = chiTietLoaiTL;
                    dsTL.Add(chiTietTrongLuong);
                }
                return dsTL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma trong luong dua vao gia tri trong luong
        /// </summary>
        /// <param name="giatritrongLuong"></param>
        /// <returns></returns>
        public static int LayMaChiTietTrongLuong(float _sGiaTriTrongLuong)
        {
            try
            {
                int maTrongLuong = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETTRONGLUONGs where p.GiaTriTrongLuong == _sGiaTriTrongLuong select p;
                if (query == null)
                    return maTrongLuong;
                foreach (CHITIETTRONGLUONG laptop in query)
                {
                    maTrongLuong = laptop.MaChiTietTrongLuong;
                    break;
                }
                return maTrongLuong;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
