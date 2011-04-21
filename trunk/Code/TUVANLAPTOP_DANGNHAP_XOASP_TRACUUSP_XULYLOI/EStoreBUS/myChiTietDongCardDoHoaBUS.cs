using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongCardDoHoaBUS
    {
        public myChiTietDongCardDoHoaDTO LayChiTietDongCardDoHoa(int _iMaChiTietDongCardDoHoa)
        { return null; }

        public List<myChiTietDongCardDoHoaDTO> LayChiTietDongCardDoHoa()
        {
            myChiTietDongCardDoHoaDAO chiTietDongCardDoHoa = new myChiTietDongCardDoHoaDAO();
            return chiTietDongCardDoHoa.LayChiTietDongCardDoHoa();
        }
    }
}
