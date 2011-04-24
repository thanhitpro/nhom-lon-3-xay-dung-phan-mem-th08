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
        /// <summary>
        /// Lay thong tin dong card reader dua vao ma card reader
        /// </summary>
        /// <param name="_iMaChiTietDongCardReader"></param>
        /// <returns></returns>
        public static myChiTietDongCardReaderDTO LayChiTietDongCardReader(int _iMaChiTietDongCardReader)
        {
            try
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy thông tin tất cả các dòng card reader
        /// </summary>
        /// <returns>danh sách tất cả các dòng card reader</returns>
        public List<myChiTietDongCardReaderDTO> LayChiTietDongCardReader()
        {
            List<myChiTietDongCardReaderDTO> dsCardReader = new List<myChiTietDongCardReaderDTO>();
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStore.CHITIETDONGCARDREADERs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGCARDREADER cardreader in query)
                {
                    myChiTietDongCardReaderDTO chiTietCardReader = new myChiTietDongCardReaderDTO();
                    chiTietCardReader.STenDongCardReader = cardreader.TenDongCardReader;
                    chiTietCardReader.IMaDongCardReader = cardreader.MaDongCardReader;
                    chiTietCardReader.NhaSanXuat = new myNhaSanXuatDTO(cardreader.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCongNgheCardReaderDTO chiTietCNReader = new myChiTietCongNgheCardReaderDTO();
                    chiTietCNReader.STenCongNgheCardReader = cardreader.CHITIETCONGNGHECARDREADER.TenCongNgheCardReader;
                    chiTietCNReader.FHeSo = (float)cardreader.CHITIETCONGNGHECARDREADER.HeSo;

                    chiTietCardReader.ChiTietCongNgheCardReader = chiTietCNReader;
                    dsCardReader.Add(chiTietCardReader);
                }
                return dsCardReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// lay thong tin ma card reader dua vao ten card reader
        /// </summary>
        /// <param name="TenRam"></param>
        /// <returns></returns>
        public static int LayMaDongCardReader(string _sTenCardReader)
        {
            try
            {
                int maCardReader = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGCARDREADERs where p.TenDongCardReader == _sTenCardReader select p;
                if (query == null)
                    return maCardReader;
                foreach (CHITIETDONGCARDREADER laptop in query)
                {
                    maCardReader = laptop.MaDongCardReader;
                    break;
                }
                return maCardReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
