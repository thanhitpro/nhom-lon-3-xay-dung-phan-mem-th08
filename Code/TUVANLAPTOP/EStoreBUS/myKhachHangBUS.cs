using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myKhachHangBUS
    {
        /// <summary>
        /// Lấy Thông tinh Khách hàng dựa vào mã khách hàng
        /// </summary>
        /// <param name="_iMaKhachHang">mã khách hàng muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tương KHACHHANG
        ///     Thất bại: trả về null
        /// </returns>
        public KHACHHANG LayKhachHang(int _iMaKhachHang)
        {
            try
            {
                return myKhachHangDAO.LayKhachHang(_iMaKhachHang);
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
        public List<KHACHHANG> LayKhachHang()
        {
            try
            {
                return myKhachHangDAO.LayKhachHang();
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
                return myKhachHangDAO.SLKhachHangTheoNgheNghiep(_iMaNgheNghiep);
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
                return myKhachHangDAO.SLKhachHangTheoMucDich(_iMaMucDichSuDung);
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
                return myKhachHangDAO.SLKhachHangTheoDoTuoi(_iMaDoTuoi);
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
                return myKhachHangDAO.SLKhachHangTheoTinhThanh(_iMaTinhThanh);
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
                return myKhachHangDAO.SLKhachHangTheoGioiTinh(isNam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
        public static bool themKhachHang(KHACHHANG _kKhachHang)
        {
            try
            {
                return myKhachHangDAO.themKhachHang(_kKhachHang);
            }
            catch
            {
                throw;
            }
        }
    }
}
