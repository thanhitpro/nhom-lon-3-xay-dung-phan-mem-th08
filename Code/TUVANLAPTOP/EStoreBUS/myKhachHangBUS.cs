//-----------------------------------------------------------------------
// <copyright file="MyKhachHangBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;

    /// <summary>
    /// Lớp Khách Hàng BUS
    /// </summary>
    public class MyKhachHangBUS
    {
        /// <summary>
        /// Tính số lượng Khách Hàng Theo Nghề Nghiệp
        /// </summary>
        /// <param name="maNgheNghiep">mã Nghề Nghiệp</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo Mã Nghề Nghiệp
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoNgheNghiep(int maNgheNghiep)
        {
            try
            {
                return myKhachHangDAO.SLKhachHangTheoNgheNghiep(maNgheNghiep);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Mục Đích Sử Dụng
        /// </summary>
        /// <param name="maMucDichSuDung">mã mục đích sử dụng</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo mục đích sử dụng
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoMucDich(int maMucDichSuDung)
        {
            try
            {
                return myKhachHangDAO.SLKhachHangTheoMucDich(maMucDichSuDung);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Độ Tuổi
        /// </summary>
        /// <param name="maDoTuoi">mã độ tuổi</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo Độ Tuổi
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoDoTuoi(int maDoTuoi)
        {
            try
            {
                return myKhachHangDAO.SLKhachHangTheoDoTuoi(maDoTuoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tính số lượng Khách Hàng Theo Tỉnh Thành
        /// </summary>
        /// <param name="maTinhThanh">mã tỉnh thành</param>
        /// <returns>
        ///     Thành công: số lượng Khách Hàng Theo Tỉnh Thành
        ///     Thất bại: trả về 0
        /// </returns>
        public static int SLKhachHangTheoTinhThanh(int maTinhThanh)
        {
            try
            {
                return myKhachHangDAO.SLKhachHangTheoTinhThanh(maTinhThanh);
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

        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        /// <param name="khachHang">khách hàng được thêm vào</param>
        /// <returns> true nếu thêm thành công ngược lại là false</returns>
        public static bool ThemKhachHang(KHACHHANG khachHang)
        {
            try
            {
                return myKhachHangDAO.ThemKhachHang(khachHang);
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Lấy Thông tinh Khách hàng dựa vào mã khách hàng
        /// </summary>
        /// <param name="maKhachHang">mã khách hàng muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tương KHACHHANG
        ///     Thất bại: trả về null
        /// </returns>
        public KHACHHANG LayKhachHang(int maKhachHang)
        {
            try
            {
                return myKhachHangDAO.LayKhachHang(maKhachHang);
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
    }
}
