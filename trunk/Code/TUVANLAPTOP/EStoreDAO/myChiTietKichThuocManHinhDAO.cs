using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using System.Data.SqlClient;

namespace EStoreDAO
{
    public class myChiTietKichThuocManHinhDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy danh sách Kích thước màn hình
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách kích thước màn hình hiện có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietKichThuocManHinhDTO> LayDSKichThuocManHinh()
        {
            try
            {
                List<myChiTietKichThuocManHinhDTO> dsKichThuocManHinh = new List<myChiTietKichThuocManHinhDTO>();

                foreach (CHITIETKICHTHUOCMANHINH kt in m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs)
                {
                    myChiTietKichThuocManHinhDTO ctKichThuoc = new myChiTietKichThuocManHinhDTO();
                    ctKichThuoc.STenChiTietKichThuocManHinh = kt.TenChiTietKichThuocManHinh;
                    ctKichThuoc.FHeSo = (float)kt.HeSo.Value;

                    dsKichThuocManHinh.Add(ctKichThuoc);
                }

                return dsKichThuocManHinh;
            }
            catch (SqlException sqlex)
            {
                throw new Exception("Lỗi lấy thông tin dòng Laptop : không thể kết nối với CSDL. Xem lại kết nối và thử lại !", sqlex);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Thêm kích thước màn hình
        /// </summary>
        /// <param name="_mKichThuoc">Thông tin kích thước màn hình hiện có</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemKichThuocManHinh(myChiTietKichThuocManHinhDTO _mKichThuoc)
        {
            try
            {
                CHITIETKICHTHUOCMANHINH chiTietKT = new CHITIETKICHTHUOCMANHINH();
                chiTietKT.TenChiTietKichThuocManHinh = _mKichThuoc.STenChiTietKichThuocManHinh;
                chiTietKT.HeSo = (float)_mKichThuoc.FHeSo;

                m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.InsertOnSubmit(chiTietKT);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("Thêm mới kích thước màn hình thất bại !",ex);
            }
        }
    }
}
