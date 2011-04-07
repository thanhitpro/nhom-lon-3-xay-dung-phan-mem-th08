using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongCardReaderDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongCardReaderDTO LayChiTietDongCardReader(int _iMaChiTietDongCardReader)
        {
            myChiTietDongCardReaderDTO chiTietCardReader = null;

            var query = m_eStoreDataContext.CHITIETDONGCARDREADERs.Single(cardReader => cardReader.MaDongCardReader == _iMaChiTietDongCardReader);
            if (query != null)
            {
                chiTietCardReader = new myChiTietDongCardReaderDTO();
                chiTietCardReader.STenDongCardReader = query.TenDongCardReader;
                chiTietCardReader.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietCongNgheCardReaderDTO chiTietCNReader = new myChiTietCongNgheCardReaderDTO();
                chiTietCNReader.STenCongNgheCardReader = query.CHITIETCONGNGHECARDREADER.TenCongNgheCardReader;
                chiTietCNReader.FHeSo = (float)query.CHITIETCONGNGHECARDREADER.HeSo;

                chiTietCardReader.ChiTietCongNgheCardReader = chiTietCNReader;
            }

            return chiTietCardReader;
        }

        public List<myChiTietDongCardReaderDTO> LayChiTietDongCardReader()
        {
            return null;
        }
    }
}
