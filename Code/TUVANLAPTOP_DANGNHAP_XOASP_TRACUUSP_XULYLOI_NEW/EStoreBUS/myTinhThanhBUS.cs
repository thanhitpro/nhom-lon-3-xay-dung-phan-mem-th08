﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myTinhThanhBUS
    {
        public myTinhThanhDTO LayTinhThanh(int _iMaTinhThanh)
        { 
            return null; 
        }

        public List<TINHTHANH> LayTinhThanh()
        {
            try
            {
                return myTinhThanhDAO.LayTinhThanh();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                throw ex;
            }
        }
    }
}
