//-----------------------------------------------------------------------
// <copyright file="MyChiTietDongLaptopBUS.cs" company="NHOM LON NHOM 3">
//     Copyright MyCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng laptop BUS
    /// </summary>
    public class MyChiTietDongLaptopBUS
    {
        /// <summary>
        /// Lay chi tiet dong laptop
        /// </summary>
        /// <param name="maChiTietDongLaptop"> Ma Chi Tiet Dong Laptop</param>
        /// <returns> 
        ///     Thành công: trả về thông tin chi tiết dòng Laptop
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongLaptopDTO LayChiTietDongLaptop(int maChiTietDongLaptop)
        {
            try
            {
                return myChiTietDongLaptopDAO.LayChiTietDongLaptop(maChiTietDongLaptop);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy tất cả dòng laptop với thông tin chi tiết
        /// </summary>
        /// <returns> 
        ///     Thành công: trả về danh sách chi tiết dòng Laptop
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static List<myChiTietDongLaptopDTO> LayDanhSachChiTietDongLaptop()
        {
            try
            {
                return myChiTietDongLaptopDAO.LayDanhSachChiTietDongLaptop();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Kiểm tra sản phẩm tồn tại hay không ?
        /// </summary>
        /// <param name="maDongLaptop">Mã dòng Laptop cần kiểm tra</param>
        /// <returns>
        ///     Kiểm tra tồn tại: trả về true
        ///     KT không tồn tại: trả về false
        /// </returns>
        public static bool KiemTraSanPhamTonTai(int maDongLaptop)
        {
            try
            {
                myChiTietDongLaptopDTO chiTietDongLt = LayChiTietDongLaptop(maDongLaptop);
                if (chiTietDongLt.BDeleted)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return false;
        }

        /// <summary>
        /// Kiểm tra thông tin giá tiền hợp lệ
        /// </summary>
        /// <param name="maDongLaptop">Mã của dòng laptop</param>
        /// <param name="mucGia">Mức giá của dòng laptop</param>
        /// <returns>
        ///     Thành công: true
        ///     Thất bại:  false
        /// </returns>
        public static bool KiemTraGiaTienHopLe(int maDongLaptop, int mucGia)
        {
            try
            {
                myChiTietDongLaptopDTO chiTietDongLt = LayChiTietDongLaptop(maDongLaptop);
                if (chiTietDongLt != null)
                {
                    float giaLaptop = (float)chiTietDongLt.FGiaBanHienHanh;

                    switch (mucGia)
                    {
                        case 0:
                            {
                                return giaLaptop < 8000.0;
                            }

                        case 1:
                            {
                                return giaLaptop >= 8000.0 && giaLaptop < 10000.0;
                            }

                        case 2:
                            {
                                return giaLaptop >= 10000.0 && giaLaptop < 12000.0;
                            }

                        case 3:
                            {
                                return giaLaptop >= 12000.0 && giaLaptop < 14000.0;
                            }

                        case 4:
                            {
                                return giaLaptop >= 14000.0 && giaLaptop < 16000.0;
                            }

                        case 5:
                            {
                                return giaLaptop >= 16000.0 && giaLaptop < 22000.0;
                            }

                        case 6:
                            {
                                return giaLaptop >= 22000.0 && giaLaptop < 26000.0;
                            }

                        case 7:
                            {
                                return giaLaptop >= 26000.0;
                            }

                        default:
                            {
                                return false;
                            }
                    }
                }

                return false;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Xoa 1 dong laptop voi ma~ nam trong list
        /// </summary>
        /// <param name="listMaDongLaptops"> danh sach cac ma dong laptop xoa</param>
        /// <returns> Boolean: cap nhat thanh cong hay that bai</returns>
        public static bool CapNhatXoaChiTietDongLaptop(List<int> listMaDongLaptops)
        {
            try
            {
                return myChiTietDongLaptopDAO.CapNhatXoaChiTietDongLaptop(listMaDongLaptops);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy thông tin chi tiết laptop mới nhất từ tầng DAO
        /// </summary>
        /// <param name="dongLaptop">Thông tin Laptop so sánh</param>
        /// <returns>
        ///     Thành công: Danh sách các Laptop mới nhất
        ///     Thất bại: 
        /// </returns>
        public static List<myChiTietDongLaptopDTO> LayChiTietDongLaptopMoiNhat(myChiTietDongLaptopDTO dongLaptop)
        {
            return myChiTietDongLaptopDAO.LayChiTietDongLaptopMoiNhat(dongLaptop);
        }

        /// <summary>
        /// Thêm dòng Laptop mới
        /// </summary>
        /// <param name="dongLaptopMoi">Thông tin dòng Laptop mới</param>
        public static void ThemMoiChiTietDongLaptop(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            try
            {
                myChiTietDongLaptopDAO.ThemMoiChiTietDongLaptop(dongLaptopMoi);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cập nhật thông tin một dòng laptop
        /// </summary>
        /// <param name="dongLaptopMoi">Thông tin dòng Laptop cần cập nhật</param>
        /// <returns>true khi cập nhật thành công, ngược lại trả về false</returns>
        public static bool CapNhatChiTietDongLaptop(CHITIETDONGLAPTOP dongLaptopMoi)
        {
            try
            {
                return myChiTietDongLaptopDAO.CapNhatChiTietDongLaptop(dongLaptopMoi);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Tra cứu thông tin các laptop thao nhiều tiêu chí
        /// </summary>
        /// <param name="infoCombobox">thông tin tiêu chí cần tra cứu</param>
        /// <returns>danh sách các laptop kết quả </returns>
        public List<myChiTietDongLaptopDTO> TraCuu(InfoComboboxOfFormTraCuu infoCombobox)
        {
            myChiTietDongLaptopDAO chiTietlapTop = new myChiTietDongLaptopDAO();
            return chiTietlapTop.TraCuu(infoCombobox);
        }
    }
}
