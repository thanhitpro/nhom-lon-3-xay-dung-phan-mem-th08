using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDungLuongOCungDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy danh sách dung lượng
        /// </summary>
        /// <returns></returns>
        public static List<myChiTietDungLuongOCungDTO> LayDSDungLuongOCung()
        {
            try
            {
                List<myChiTietDungLuongOCungDTO> dsDungLuong = new List<myChiTietDungLuongOCungDTO>();
                foreach (CHITIETDUNGLUONGOCUNG dungLuong in m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs)
                {
                    myChiTietDungLuongOCungDTO ctDungLuong = new myChiTietDungLuongOCungDTO();
                    ctDungLuong.STenChiTietDungLuongOCung = dungLuong.TenChiTietDungLuongOCung;
                    ctDungLuong.FHeSo = (float)dungLuong.HeSo;

                    dsDungLuong.Add(ctDungLuong);
                }

                return dsDungLuong;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Thêm dung lượng Dung Lượng Ổ Cứng:
        /// </summary>
        /// <param name="_mDungLuong"></param>
        /// <returns></returns>
        public static bool ThemDungLuongOCung(myChiTietDungLuongOCungDTO _mDungLuong)
        {
            try
            {
                CHITIETDUNGLUONGOCUNG ctDungLuong = new CHITIETDUNGLUONGOCUNG();
                ctDungLuong.TenChiTietDungLuongOCung = _mDungLuong.STenChiTietDungLuongOCung;
                ctDungLuong.HeSo = (float)_mDungLuong.FHeSo;

                m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.InsertOnSubmit(ctDungLuong);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm mới dung lượng ổ cứng thất bại !", ex);
            }
        }
    }
}
