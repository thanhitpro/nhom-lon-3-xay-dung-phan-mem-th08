using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardReaderBUS
    {
        public myChiTietDongCardReaderDTO LayChiTietDongCardReader(int _iMaChiTietDongCardReader)
        { return null; }

        public List<myChiTietDongCardReaderDTO> LayChiTietDongCardReader()
        {
            myChiTietDongCardReaderDAO chiTietCardReader = new myChiTietDongCardReaderDAO();
            return chiTietCardReader.LayChiTietDongCardReader();
        }
    }
}
