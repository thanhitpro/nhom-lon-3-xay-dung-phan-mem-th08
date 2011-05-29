using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using EStoreDTO;

namespace EStoreDAO
{
    public class myGiaoDichDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy thông tin Giao Dịch theo mã
        /// </summary>
        /// <param name="_iMaGiaoDich">Thông tin mã Giao Dich muốn lấy</param>
        /// <returns>
        ///     Thành công: trả về 1 đối tượng GIAODICH
        ///     Thất bại: trả về null
        /// </returns>
        public static GIAODICH LayGiaoDich(int _iMaGiaoDich)
        {
            try
            {
                GIAODICH _GiaoDich = m_eStoreDataContext.GIAODICHes.Single(Temp => Temp.MaGiaoDich == _iMaGiaoDich);
                return _GiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách toàn bộ Giao Dịch có trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về 1 danh sách tất cả Giao Dịch có trong CSDL
        ///     Thất bại: trả về null
        /// </returns>
        public static List<GIAODICH> LayGiaoDich()
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
                List<GIAODICH> dsGiaoDich = new List<GIAODICH>();
                foreach (GIAODICH giaodich in Query)
                    dsGiaoDich.Add(giaodich);
                return dsGiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy danh sách Giao Dịch Theo mã dòng Laptop
        /// </summary>
        /// <param name="_iMaDongLapTop">Thông tin mã dòng laptop</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách các giao dịch theo mã dòng laptop
        ///     Thất bại: trả về null
        /// </returns>
        public static List<GIAODICH> LayDanhSachGiaoDichTheoMaDongLapTop(int _iMaDongLapTop)
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes
                            where _GiaoDich.MaDongLaptop == _iMaDongLapTop
                            select _GiaoDich;
                List<GIAODICH> DSGiaoDich = new List<GIAODICH>();
                foreach (GIAODICH _giaodich in Query)
                {
                        DSGiaoDich.Add(_giaodich);
                }
                return DSGiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
          
        }

        /// <summary>
        /// Lấy danh sách Giao Dịch Theo mã nhà sản xuất
        /// </summary>
        /// <param name="_iMaDongLapTop">Thông tin mã nhà sản xuất</param>
        /// <returns>
        ///     Thành công: trả về 1 danh sách các giao dịch theo mã nhà sản xuất
        ///     Thất bại: trả về null
        /// </returns>
        public static List<GIAODICH> LayDanhSachGiaoDichTheoNhaSanXuat(int _iMaNhaSanXuat)
        {
            try
            {
                var Query = from _GiaoDich in m_eStoreDataContext.GIAODICHes select _GiaoDich;
                List<GIAODICH> dsGiaoDich = new List<GIAODICH>();
                foreach (GIAODICH _giaodich in Query)
                {
                    if (_giaodich.CHITIETDONGLAPTOP.MaNhaSanXuat == _iMaNhaSanXuat)
                        dsGiaoDich.Add(_giaodich);
                }
                return dsGiaoDich;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Thêm mới giao dịch
        /// </summary>
        /// <param name="_gGiaoDich">Thông tin giao dịch mới cần thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: trả về true
        /// </returns>
        public static bool themGiaoDich(GIAODICH _gGiaoDich)
        {
            try
            {
                m_eStoreDataContext.GIAODICHes.InsertOnSubmit(_gGiaoDich);
                m_eStoreDataContext.SubmitChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
            }            
        }

        /// <summary>
        /// Lấy số lượng toàn bộ Giao Dịch cso trong CSDL
        /// </summary>
        /// <returns>
        ///     Thành công: trả về số lượng tất cả giao dịch trong CSDL
        ///     Thất bại: 0
        /// </returns>
        public static int LaySoLuongGiaoDich()
        {
            try
            {
                int SoLuong = m_eStoreDataContext.GIAODICHes.Count();             
                return SoLuong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
    }
}
