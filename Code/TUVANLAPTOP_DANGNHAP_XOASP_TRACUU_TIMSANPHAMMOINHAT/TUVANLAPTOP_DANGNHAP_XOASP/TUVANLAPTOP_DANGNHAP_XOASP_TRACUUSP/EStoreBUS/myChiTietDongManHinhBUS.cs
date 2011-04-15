using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongManHinhBUS
    {
        public myChiTietDongManHinhDTO LayChiTietDongManHinh(int _iMaChiTietDongManHinh)
        { return null; }

        public List<myChiTietDongManHinhDTO> LayChiTietDongManHinh()
        {
            myChiTietDongManHinhDAO chiTietManHinhDAO = new myChiTietDongManHinhDAO();
            return chiTietManHinhDAO.LayChiTietDongManHinh();
        }
    }
}
