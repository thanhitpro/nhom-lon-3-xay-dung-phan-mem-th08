using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongLoaDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lay thong tin dong loa dua vao ten dong loa
        /// </summary>
        /// <param name="_iMaChiTietDongLoa">ma dong loa</param>
        /// <returns></returns>
        public static myChiTietDongLoaDTO LayChiTietDongLoa(int _iMaChiTietDongLoa)
        {
            try
            {
                myChiTietDongLoaDTO chiTietDongLoa = null;

                var query = m_eStoreDataContext.CHITIETDONGLOAs.Single(loa => loa.MaDongLoa == _iMaChiTietDongLoa);
                if (query != null)
                {
                    chiTietDongLoa = new myChiTietDongLoaDTO();
                    chiTietDongLoa.STenDongLoa = query.TenDongDongLoa;
                    chiTietDongLoa.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);
                    chiTietDongLoa.BCoMicro = BitConverter.GetBytes(query.CoMicro)[0];
                }

                return chiTietDongLoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Lấy tất cả thông tin các dòng loa
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongLoaDTO> LayChiTietDongLoa()
        {
            List<myChiTietDongLoaDTO> dsLoa = new List<myChiTietDongLoaDTO>();
            DataClasses1DataContext m_EStoreContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStoreContext.CHITIETDONGLOAs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGLOA loa in query)
                {
                    myChiTietDongLoaDTO chiTietDongLoa = new myChiTietDongLoaDTO();
                    chiTietDongLoa.STenDongLoa = loa.TenDongDongLoa;
                    chiTietDongLoa.IMaDongLoa = loa.MaDongLoa;
                    chiTietDongLoa.NhaSanXuat = new myNhaSanXuatDTO(loa.NHASANXUAT.TenNhaSanXuat);
                    chiTietDongLoa.BCoMicro = BitConverter.GetBytes(loa.CoMicro)[0];
                    dsLoa.Add(chiTietDongLoa);
                }
                return dsLoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        /// <summary>
        /// Lấy thông tin mã dòng loa dựa vào tên dòng loa
        /// </summary>
        /// <param name="_sTenLoa">Tên dòng loa</param>
        /// <returns>Thông tin dòng loa cần tra cứu</returns>
        public static int LayMaDongLoa(string _sTenLoa)
        {
            try
            {
                int maDongLoa = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGLOAs where p.TenDongDongLoa == _sTenLoa select p;
                if (query == null)
                    return maDongLoa;
                foreach (CHITIETDONGLOA laptop in query)
                {
                    maDongLoa = laptop.MaDongLoa;
                    break;
                }
                return maDongLoa;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
