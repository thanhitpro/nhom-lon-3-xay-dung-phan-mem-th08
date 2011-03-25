using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myNhaSXDAO
    {
        /// <summary>
        /// DataContext làm việc với LINQ
        /// </summary> 
        private EStoreDataContext m_eDB = new EStoreDataContext();

        /// <summary>
        /// Hàm lấy danh sách tất cả các dòng laptop
        /// </summary>
        public List<myNhaSX> LayDSNhaSX()
        {
            var query = from nhaSX in m_eDB.NHASANXUATs select nhaSX;
            List<myNhaSX> danhSachNhaSX = new List<myNhaSX>();
            foreach (NHASANXUAT nSX in query)
            {
                myNhaSX nhaSX = new myNhaSX(nSX.MaNhaSanXuat,nSX.TenNhaSanXuat);
                danhSachNhaSX.Add(nhaSX);
            }
            return danhSachNhaSX;
        }
    }
}
