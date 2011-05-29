using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongCPUDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lấy thông tin chi tiết dòng CPU dựa vào mã
        /// </summary>
        /// <param name="_iMaChiTietDongCPU">Mã dòng CPU cần lấy thông tin</param>
        /// <returns>
        ///     Thành công: trả về thông tin chi tiết dòng CPU có mã chỉ định
        ///     Thất bai: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongCPUDTO LayChiTietDongCPU(int _iMaChiTietDongCPU)
        {
            try
            {
                myChiTietDongCPUDTO chiTietCPU = null;

                var query = m_eStoreDataContext.CHITIETDONGCPUs.Single(cpu => cpu.MaDongCPU == _iMaChiTietDongCPU);
                if (query != null)
                {
                    chiTietCPU = new myChiTietDongCPUDTO();
                    chiTietCPU.STenDongCPU = query.TenDongCPU;
                    chiTietCPU.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCongNgheCPUDTO chiTietCongNgheCPU = new myChiTietCongNgheCPUDTO();
                    chiTietCongNgheCPU.STenChiTietCongNgheCPU = query.CHITIETCONGNGHECPU.TenChiTietCongNgheCPU;
                    chiTietCongNgheCPU.FHeSo = (float)query.CHITIETCONGNGHECPU.HeSo;
                    chiTietCPU.ChiTietCongNgheCPU = chiTietCongNgheCPU;
                }

                return chiTietCPU;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Thêm dòng CPU mới
        /// </summary>
        /// <param name="_mDongCPU">Thông tin dòng CPU muốn thêm</param>
        /// <returns>
        ///     Thành công: trả về true
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool ThemDongCPU(myChiTietDongCPUDTO _mDongCPU)
        {
            try
            {
                CHITIETDONGCPU dongCPU = new CHITIETDONGCPU();

                dongCPU.MaChiTietCongNgheCPU = _mDongCPU.ChiTietCongNgheCPU.IMaChiTietCN;
                dongCPU.TenDongCPU = _mDongCPU.STenDongCPU;
                dongCPU.MaNhaSanXuat = 32;
                dongCPU.MaBangDiem_KhoangTang = 1;
                
                m_eStoreDataContext.CHITIETDONGCPUs.InsertOnSubmit(dongCPU);
                m_eStoreDataContext.SubmitChanges();

                return true;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Kiểm tra một dòng CPU có tồn tại hay chưa
        /// </summary>
        /// <param name="_sName">Tên dòng CPU cần kiểm tra</param>
        /// <returns>
        ///     Tồn tại: trả về true
        ///     Không tồn tại: trả về false;
        ///     Xảy ra lỗi: throw một exception cho tầng trên xử lý
        /// </returns>
        public static bool KiemTraTonTaiDongCPU(string _sName)
        {
            try
            {
                return (m_eStoreDataContext.CHITIETDONGCPUs.ToList().Exists(dongCPU => dongCPU.TenDongCPU == _sName));
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy danh sách các dòng CPU
        /// </summary>
        /// <returns>
        ///     Thành công: trả về danh sách dòng CPU hiên có
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public List<myChiTietDongCPUDTO> LayChiTietDongCPU()
        {
            List<myChiTietDongCPUDTO> dsDongCPU = new List<myChiTietDongCPUDTO>();
            DataClasses1DataContext m_eStoreContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_eStoreContext.CHITIETDONGCPUs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGCPU cpu in query)
                {
                    myChiTietDongCPUDTO chiTietCPU = new myChiTietDongCPUDTO();
                    chiTietCPU.STenDongCPU = cpu.TenDongCPU;
                    chiTietCPU.IMaDongCPU = cpu.MaDongCPU;
                    chiTietCPU.NhaSanXuat = new myNhaSanXuatDTO(cpu.NHASANXUAT.TenNhaSanXuat);

                    myChiTietCongNgheCPUDTO chiTietCNCPU = new myChiTietCongNgheCPUDTO();
                    chiTietCNCPU.STenChiTietCongNgheCPU = cpu.CHITIETCONGNGHECPU.TenChiTietCongNgheCPU;
                    chiTietCNCPU.FHeSo = (float)cpu.CHITIETCONGNGHECPU.HeSo;
                    chiTietCPU.ChiTietCongNgheCPU = chiTietCNCPU;
                    dsDongCPU.Add(chiTietCPU);
                }
                return dsDongCPU;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma dong CPU tu ten CPU
        /// </summary>
        /// <param name="TenCPU"> Ten CPU</param>
        /// <returns></returns>
        public static int LayMaDongCPU(string TenCPU)
        {
            try
            {
                int maDong = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGCPUs where p.TenDongCPU == TenCPU select p;
                if (query == null)
                    return maDong;
                foreach (CHITIETDONGCPU laptop in query)
                {
                    maDong = laptop.MaDongCPU;
                    break;
                }
                return maDong;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
