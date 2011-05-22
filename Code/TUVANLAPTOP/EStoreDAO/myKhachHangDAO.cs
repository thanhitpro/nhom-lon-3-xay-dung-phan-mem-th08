using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
namespace EStoreDAO
{
    public class myKhachHangDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy Thông tinh Khách hàng dựa vào mã khách hàng
        /// </summary>
        /// <param name="_iMaKhachHang">mã khách hàng muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tương KHACHHANG
        ///     Thất bại: trả về null
        /// </returns>
        public static KHACHHANG LayKhachHang(int _iMaKhachHang)
        {
            try
            {
                KHACHHANG _KhachHang = m_eStoreDataContext.KHACHHANGs.Single(temp => temp.MaKhachHang == _iMaKhachHang);
                return _KhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách toàn bộ Khách hàng
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách toàn bộ khách hàng có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public static List<KHACHHANG> LayKhachHang()
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs select _KhachHang;
                List<KHACHHANG> dsKhachHang = new List<KHACHHANG>();
                foreach (KHACHHANG _KH in Query)
                    dsKhachHang.Add(_KH);
                return dsKhachHang;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Nghề Nghiệp
        /// </summary>
        /// <param name="_iMaNgheNghiep">mã Nghề Nghiệp</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo Mã Nghề Nghiệp
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoNgheNghiep(int _iMaNgheNghiep)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.MaNgheNghiep== _iMaNgheNghiep
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Mục Đích Sử Dụng
        /// </summary>
        /// <param name="_iMaMucDichSuDung">mã mục đích sử dụng</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo mục đích sử dụng
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoMucDich(int _iMaMucDichSuDung)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs
                            where _KhachHang.MaMucDichSuDung== _iMaMucDichSuDung
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Độ Tuổi
        /// </summary>
        /// <param name="_iMaDoTuoi">mã độ tuổi</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo Độ Tuổi
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoDoTuoi(int _iMaDoTuoi)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.MaDoTuoi== _iMaDoTuoi
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Tỉnh Thành
        /// </summary>
        /// <param name="_iMaTinhThanh">mã tỉnh thành</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo Tỉnh Thành
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoTinhThanh(int _iMaTinhThanh)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.MaTinhThanh == _iMaTinhThanh
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo giới Tính
        /// </summary>
        /// <param name="isNam">giới tình là nam = true hoặc nữ= false</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo giới tính
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoGioiTinh(bool isNam)
        {
            try
            {
                var Query = from _KhachHang in m_eStoreDataContext.KHACHHANGs 
                            where _KhachHang.GioiTinhNam==isNam
                            select _KhachHang;
                int Result = 0;
                foreach (KHACHHANG _KH in Query)
                 //  if (_KH.GioiTinhNam == isNam)
                        Result++;
                return Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// Thêm mới Khách hàng
        /// </summary>
        /// <param name="_kKhachHang">Thông tin khách hàng muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: trả về false
        /// </returns>
        public static bool themKhachHang(KHACHHANG _kKhachHang)
        {
            try
            {
                m_eStoreDataContext.KHACHHANGs.InsertOnSubmit(_kKhachHang);
                m_eStoreDataContext.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }            
        }
    }
}
