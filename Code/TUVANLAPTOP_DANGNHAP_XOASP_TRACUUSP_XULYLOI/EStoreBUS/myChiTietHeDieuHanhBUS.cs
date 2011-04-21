using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietHeDieuHanhBUS
    {
        public myChiTietHeDieuHanhDTO LayChiTietHeDieuHanh(int _iMaChiTietHeDieuHanh)
        { return null; }

        public List<myChiTietHeDieuHanhDTO> LayChiTietHeDieuHanh()
        {
            myChiTietHeDieuHanhDAO chiTietHDHDAO = new myChiTietHeDieuHanhDAO();
            return chiTietHDHDAO.LayChiTietHeDieuHanh();
        }
    }
}
