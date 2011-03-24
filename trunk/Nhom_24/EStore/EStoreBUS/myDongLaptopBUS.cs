using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDAO;
using EStoreDTO;

namespace EStoreBUS
{
    public class myDongLaptopBUS
    {
        /// <summary>
        /// Thuộc tính quản lý các công việc với CSDL
        /// </summary>
        private myDongLaptopDAO m_dDongLaptopDao = new myDongLaptopDAO();

        /// <summary>
        /// Hàm trả về danh sách các dòng laptop từ DAO
        /// </summary>
        public List<myDongLaptop> LayDSDongLaptop()
        {
            return m_dDongLaptopDao.LayDSDongLaptop();
        }

        /// <summary>
        /// Hàm trả về danh sách các dòng laptop thuộc 1 nhà sản xuất
        /// </summary>
        public List<myDongLaptop> LayDSDongLaptop(int _iMaNhaSX)
        {
            return m_dDongLaptopDao.LayDSDongLaptop(_iMaNhaSX);
        }
    }
}
