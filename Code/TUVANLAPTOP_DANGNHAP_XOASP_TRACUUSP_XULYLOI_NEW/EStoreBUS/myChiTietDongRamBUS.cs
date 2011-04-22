using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongRamBUS
    {
        public myChiTietDongRamDTO LayChiTietDongRam(int _iMaChiTietDongRam)
        { return null; }

        public List<myChiTietDongRamDTO> LayChiTietDongRam()
        {
            myChiTietDongRamDAO chiTietDongRamDAO = new myChiTietDongRamDAO();
            List<myChiTietDongRamDTO> list = new List<myChiTietDongRamDTO>();
            list = chiTietDongRamDAO.LayChiTietDongRam();
            return list;
        }
    }
}
