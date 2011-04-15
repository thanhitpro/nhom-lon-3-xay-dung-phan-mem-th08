using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardMangBUS
    {
        public myChiTietDongCardMangDTO LayChiTietDongCardMang(int _iMaChiTietDongCardMang)
        { return null; }

        public List<myChiTietDongCardMangDTO> LayChiTietDongCardMang()
        {
            myChiTietDongCardMangDAO chiTietCardMang = new myChiTietDongCardMangDAO();
            return chiTietCardMang.LayChiTietDongCardMang();
        }
    }
}
