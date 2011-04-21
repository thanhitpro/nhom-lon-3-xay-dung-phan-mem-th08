using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongLoaBUS
    {
        public myChiTietDongLoaDTO LayChiTietDongLoa(int _iMaChiTietDongLoa)
        { return null; }

        public List<myChiTietDongLoaDTO> LayChiTietDongLoa()
        {
            myChiTietDongLoaDAO chiTietDongLoaDAO = new myChiTietDongLoaDAO();
            return chiTietDongLoaDAO.LayChiTietDongLoa();
        }
    }
}
