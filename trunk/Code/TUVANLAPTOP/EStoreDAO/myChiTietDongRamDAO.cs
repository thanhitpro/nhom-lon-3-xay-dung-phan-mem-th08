using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongRamDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        
        /// <summary>
        /// Lấy thông tin của dòng RAM dựa vào mã dòng RAM
        /// </summary>
        /// <param name="_iMaChiTietDongRam"> Mã số dòng RAM</param>
        /// <returns>Lớp đối tượng chứa thông tin dòng RAM cần tra cứu</returns>
        public static myChiTietDongRamDTO LayChiTietDongRam(int _iMaChiTietDongRam)
        {
            try
            {
                myChiTietDongRamDTO chiTietDongRam = null;
                var query = m_eStoreDataContext.CHITIETDONGRAMs.Single(ram => ram.MaDongRAM == _iMaChiTietDongRam);
                if (query != null)
                {
                    chiTietDongRam = new myChiTietDongRamDTO();
                    chiTietDongRam.STenDongRAM = query.TenDongRAM;
                    chiTietDongRam.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCongNgheRamDTO chiTietCNRam = new myChiTietCongNgheRamDTO();
                    chiTietCNRam.STenCongNgheRam = query.CHITIETCONGNGHERAM.TenCongNgheRam;
                    chiTietCNRam.FHeSo = (float)query.CHITIETCONGNGHERAM.HeSo;

                    chiTietDongRam.ChiTietCongNgheRam = chiTietCNRam;

                    myChiTietBoNhoRamDTO chiTietBoNhoRAM = new myChiTietBoNhoRamDTO();
                    chiTietBoNhoRAM.STenChiTietBoNhoRam = query.CHITIETBONHORAM.TenChiTietBoNhoRAM;
                    chiTietBoNhoRAM.FHeSo = (float)query.CHITIETBONHORAM.HeSo;

                    chiTietDongRam.ChiTietBoNhoRam = chiTietBoNhoRAM;
                }

                return chiTietDongRam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy danh sách chi tiết tất cả các dòng RAM
        /// </summary>
        /// <returns>Danh sách chi tiết các dòng RAM</returns>
        public List<myChiTietDongRamDTO> LayChiTietDongRam()
        {
            List<myChiTietDongRamDTO> dsDongRam = new List<myChiTietDongRamDTO>();
            DataClasses1DataContext m_EStoreDataContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_eStoreDataContext.CHITIETDONGRAMs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGRAM ram in query)
                {
                    myChiTietDongRamDTO chiTietDongRam = new myChiTietDongRamDTO();
                    chiTietDongRam.STenDongRAM = ram.TenDongRAM;
                    chiTietDongRam.IMaDongRam = ram.MaDongRAM;
                    chiTietDongRam.NhaSanXuat = new myNhaSanXuatDTO(ram.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCongNgheRamDTO chiTietCNRam = new myChiTietCongNgheRamDTO();
                    chiTietCNRam.STenCongNgheRam = ram.CHITIETCONGNGHERAM.TenCongNgheRam;
                    chiTietCNRam.FHeSo = (float)ram.CHITIETCONGNGHERAM.HeSo;

                    chiTietDongRam.ChiTietCongNgheRam = chiTietCNRam;

                    myChiTietBoNhoRamDTO chiTietBoNhoRAM = new myChiTietBoNhoRamDTO();
                    chiTietBoNhoRAM.STenChiTietBoNhoRam = ram.CHITIETBONHORAM.TenChiTietBoNhoRAM;
                    chiTietBoNhoRAM.FHeSo = (float)ram.CHITIETBONHORAM.HeSo;

                    chiTietDongRam.ChiTietBoNhoRam = chiTietBoNhoRAM;
                    dsDongRam.Add(chiTietDongRam);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsDongRam;
        }
        /// <summary>
        /// Lấy thông tin mã của RAM từ tên RAM
        /// </summary>
        /// <param name="_sTenRam">Tên RAM</param>
        /// <returns>Mã dòng RAM</returns>
        public static int LayMaDongRam(string _sTenRam)
        {
            try
            {
                int maDongRam = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGRAMs where p.TenDongRAM == _sTenRam select p;
                if (query == null)
                    return maDongRam;
                foreach (CHITIETDONGRAM laptop in query)
                {
                    maDongRam = laptop.MaDongRAM;
                    break;
                }
                return maDongRam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
