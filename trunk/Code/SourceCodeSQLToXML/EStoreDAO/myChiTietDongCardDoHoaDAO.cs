using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.SqlClient;


namespace EStoreDAO
{
    public class myChiTietDongCardDoHoaDAO
    {
        private DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        public myChiTietDongCardDoHoaDTO LayChiTietDongCardDoHoa(int _iMaChiTietDongCardDoHoa)
        {

            myChiTietDongCardDoHoaDTO chitietDongCardDoHoa_DTO = null;
            foreach (CHITIETDONGCARDDOHOA chitietDongCardDoHoa_DAO in m_eStoreDataContext.CHITIETDONGCARDDOHOAs)
            {
                if (chitietDongCardDoHoa_DAO.MaDongCardDoHoa == _iMaChiTietDongCardDoHoa)
                {
                    chitietDongCardDoHoa_DTO = new myChiTietDongCardDoHoaDTO();
                    //chitietDongCardDoHoa_DTO.ChiTietCardDoHoa = 
                }
            }
            return chitietDongCardDoHoa_DTO;// đủ xài
        }

        public List<myChiTietDongCardDoHoaDTO> LayChiTietDongCardDoHoa()
        {
            return null;
        }
    }
}
