﻿using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myGiaoDichBUS
    {
        public myGiaoDichDTO LayGiaoDich(int _iMaGiaoDich)
        { return null; }

        public List<myGiaoDichDTO> LayGiaoDich()
        { return null; }

        public static bool themGiaoDich(GIAODICH _gGiaoDich)
        {
            return myGiaoDichDAO.themGiaoDich(_gGiaoDich);
        }
    }
}
