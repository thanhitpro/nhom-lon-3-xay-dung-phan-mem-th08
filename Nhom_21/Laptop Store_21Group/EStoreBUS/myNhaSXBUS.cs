using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDAO;
using EStoreDTO;

namespace EStoreBUS
{
    public class myNhaSXBUS
    {
        /// <summary>
        /// Thuộc tính quản lý các công việc với CSDL
        /// </summary>
        private myNhaSXDAO m_nSXDao = new myNhaSXDAO();

        /// <summary>
        /// Hàm trả về danh sách các dòng nha SX từ DAO
        /// </summary>
        public List<myNhaSX> LayDSNhaSX()
        {
            return m_nSXDao.LayDSNhaSX();
        }
    }
}
