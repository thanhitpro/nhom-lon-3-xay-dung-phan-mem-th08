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

        public static NHASANXUAT LayNhaSanXuat(int _iMaNhaSanXuat)
        {
           // ChuyenXe _Chuyen = QLXK.ChuyenXes.Single(c => c.MaChuyenXe.Trim() == MaChuyen.Trim());
            NHASANXUAT _NhaSanXuat = m_eStoreDataContext.NHASANXUATs.Single(nsx => nsx.MaNhaSanXuat == _iMaNhaSanXuat);
            return _NhaSanXuat;
           /* myNhaSanXuatDTO nhasanxuat_DTO = null;
            foreach (NHASANXUAT nhasanxuat_DAO in m_eStoreDataContext.NHASANXUATs)
            {
                if (nhasanxuat_DAO.MaNhaSanXuat == _iMaNhaSanXuat)
                {
                    nhasanxuat_DTO = new myNhaSanXuatDTO();
                    nhasanxuat_DTO.STenNhaSanXuat = nhasanxuat_DAO.TenNhaSanXuat;
                    break;
                }
            }
            return nhasanxuat_DTO;*/
        }

        public static List<NHASANXUAT> LayNhaSanXuat()
        {

            var query = from NhaSanXuat in m_eStoreDataContext.NHASANXUATs select NhaSanXuat;
            List<NHASANXUAT> _DSNhaSanXuat = new List<NHASANXUAT>();
            foreach(NHASANXUAT _NhaSX in query)
            {
                _DSNhaSanXuat.Add(_NhaSX);
            }
            return _DSNhaSanXuat;
           /* List<myNhaSanXuatDTO> danhsachNhaSanXuat = new List<myNhaSanXuatDTO>();
            foreach (NHASANXUAT nhasanxuat_DAO in m_eStoreDataContext.NHASANXUATs)
            {
                myNhaSanXuatDTO nhasanxuat_DTO = new myNhaSanXuatDTO();
                nhasanxuat_DTO.STenNhaSanXuat = nhasanxuat_DAO.TenNhaSanXuat;
                danhsachNhaSanXuat.Add(nhasanxuat_DTO);
            }
            return danhsachNhaSanXuat;*/
        }
    }
}
