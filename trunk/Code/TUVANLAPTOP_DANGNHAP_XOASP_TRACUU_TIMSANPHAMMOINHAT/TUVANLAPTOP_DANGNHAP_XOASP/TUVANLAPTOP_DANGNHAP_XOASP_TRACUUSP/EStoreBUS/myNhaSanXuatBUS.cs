using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myNhaSanXuatBUS
    {
        /// <summary>
        /// Lay thong tin nha sx tu ma nha sx
        /// </summary>
        /// <param name="_iMaNhaSanXuat"></param>
        /// <returns></returns>
        public myNhaSanXuatDTO LayNhaSanXuat(int _iMaNhaSanXuat)
        { 
            return null;
        }
        /// <summary>
        /// Lay danh sach nha sx tu DAO
        /// </summary>
        /// <returns></returns>
        public List<myNhaSanXuatDTO> LayNhaSanXuat()
        {
            myNhaSanXuatDAO nhaSX = new myNhaSanXuatDAO();
            return nhaSX.LayDSNhaSX();
        }
    }
}
