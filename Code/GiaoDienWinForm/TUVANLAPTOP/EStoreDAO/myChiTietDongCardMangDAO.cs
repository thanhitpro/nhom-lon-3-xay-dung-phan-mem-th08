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

        public List<myChiTietDongCardMangDTO> LayChiTietDongCardMang()
        {
            return null;
        }
    }
}
