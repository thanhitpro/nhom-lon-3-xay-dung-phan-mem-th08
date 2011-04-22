using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongCardMangDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lay thong tin cua card mang dua vao ma card mang
        /// </summary>
        /// <param name="_iMaChiTietDongCardMang">ma dong card mang</param>
        /// <returns></returns>
        public static myChiTietDongCardMangDTO LayChiTietDongCardMang(int _iMaChiTietDongCardMang)
        {
            myChiTietDongCardMangDTO chiTietDongCardMang = null;

            var query = m_eStoreDataContext.CHITIETDONGCARDMANGs.Single(cardmang => cardmang.MaDongCardMang == _iMaChiTietDongCardMang);
            if (query != null)
            {
                chiTietDongCardMang = new myChiTietDongCardMangDTO();
                chiTietDongCardMang.STenDongCardMang = query.TenDongCardMang;
                chiTietDongCardMang.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietLoaiKetNoiCardMangDTO chiTietKetNoi = new myChiTietLoaiKetNoiCardMangDTO();
                chiTietKetNoi.STenLoaiKetNoiCardMang = query.CHITIETLOAIKETNOICARDMANG.TenLoaiKetNoiCardMang;
                chiTietKetNoi.FHeSo = (float)query.CHITIETLOAIKETNOICARDMANG.HeSo;

                chiTietDongCardMang.ChiTietLoaiKetNoiMang = chiTietKetNoi;
            }

            return chiTietDongCardMang;
        }
        /// <summary>
        /// Lay thong tin tat ca cac dong card mang
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongCardMangDTO> LayChiTietDongCardMang()
        {
            List<myChiTietDongCardMangDTO> dsCardMang = new List<myChiTietDongCardMangDTO>();
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStore.CHITIETDONGCARDMANGs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGCARDMANG cardmang in query)
                {
                    myChiTietDongCardMangDTO chiTietDongCardMang = new myChiTietDongCardMangDTO();
                    chiTietDongCardMang.STenDongCardMang = cardmang.TenDongCardMang;
                    chiTietDongCardMang.NhaSanXuat = new myNhaSanXuatDTO(cardmang.NHASANXUAT.TenNhaSanXuat);

                    myChiTietLoaiKetNoiCardMangDTO chiTietKetNoi = new myChiTietLoaiKetNoiCardMangDTO();
                    chiTietKetNoi.STenLoaiKetNoiCardMang = cardmang.CHITIETLOAIKETNOICARDMANG.TenLoaiKetNoiCardMang;
                    chiTietKetNoi.FHeSo = (float)cardmang.CHITIETLOAIKETNOICARDMANG.HeSo;

                    chiTietDongCardMang.ChiTietLoaiKetNoiMang = chiTietKetNoi;
                    dsCardMang.Add(chiTietDongCardMang);
                }
                return dsCardMang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy thông tin mã card mạng dựa vào tên card mạng
        /// </summary>
        /// <param name="_sTenCardMang">tên card mạng</param>
        /// <returns></returns>
        public static int LayMaDongCardMang(string _sTenCardMang)
        {
            int maCardMang = -1;
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            var query = from p in m_EStore.CHITIETDONGCARDMANGs where p.TenDongCardMang == _sTenCardMang select p;
            if (query == null)
                return maCardMang;
            foreach (CHITIETDONGCARDMANG laptop in query)
            {
                maCardMang = laptop.MaDongCardMang;
                break;
            }
            return maCardMang;

        }
    }
}
