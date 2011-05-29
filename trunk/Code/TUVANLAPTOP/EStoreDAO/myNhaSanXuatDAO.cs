using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;


namespace EStoreDAO
{
    public class myNhaSanXuatDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lấy thông tin nhà sản xuất dựa vào mã
        /// </summary>
        /// <param name="_iMaNhaSanXuat">Mã nhà sản xuất</param>
        /// <returns>
        ///     Thành công: Chi tiết thông tin nhà sản xuất
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static NHASANXUAT LayNhaSanXuat(int _iMaNhaSanXuat)
        {
            try
            {
                NHASANXUAT _NhaSanXuat = m_eStoreDataContext.NHASANXUATs.Single(nsx => nsx.MaNhaSanXuat == _iMaNhaSanXuat);
                return _NhaSanXuat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay danh sach nha sx tu csdl ( phuong thuc static )
        /// </summary>
        /// <returns></returns>
        public static List<NHASANXUAT> LayNhaSanXuat()
        {
            try
            {
                var query = from NhaSanXuat in m_eStoreDataContext.NHASANXUATs select NhaSanXuat;
                List<NHASANXUAT> _DSNhaSanXuat = new List<NHASANXUAT>();
                foreach (NHASANXUAT _NhaSX in query)
                {
                    _DSNhaSanXuat.Add(_NhaSX);
                }
                return _DSNhaSanXuat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay danh sach nha sx tu csdl ( phuong thuc binh thuong )
        /// </summary>
        /// <returns></returns>
        public List<myNhaSanXuatDTO> LayDSNhaSX()
        {
            try
            {
                var query = from p in m_eStoreDataContext.NHASANXUATs select p;
                List<myNhaSanXuatDTO> dsNhaSanXuat = new List<myNhaSanXuatDTO>();
                if (query == null)
                    return null;
                foreach (NHASANXUAT nhasx in query)
                {
                    myNhaSanXuatDTO nsx = new myNhaSanXuatDTO(nhasx.TenNhaSanXuat);
                    nsx.IMaNhaSanXuat = nhasx.MaNhaSanXuat;
                    dsNhaSanXuat.Add(nsx);
                }
                return dsNhaSanXuat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma nha sx dua vao ten nha sx
        /// </summary>
        /// <param name="_sTenNhaSX"></param>
        /// <returns></returns>
        public static int LayMaNhaSanXuat(string _sTenNhaSX)
        {
            int maNhaSanXuat = -1;
            try
            {
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.NHASANXUATs where p.TenNhaSanXuat == _sTenNhaSX select p;
                if (query == null)
                    return maNhaSanXuat;
                foreach (NHASANXUAT laptop in query)
                {
                    maNhaSanXuat = laptop.MaNhaSanXuat;
                    break;
                }
                return maNhaSanXuat;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
