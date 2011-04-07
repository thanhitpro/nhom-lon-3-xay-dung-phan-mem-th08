using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myNgheNghiepBUS
    {
        public myNgheNghiepDTO LayNgheNghiep(int _iMaNgheNghiep)
        { return null; }

        public List<NGHENGHIEP> LayNgheNghiep()
        { return myNgheNghiepDAO.LayNgheNghiep(); }
    }
}
