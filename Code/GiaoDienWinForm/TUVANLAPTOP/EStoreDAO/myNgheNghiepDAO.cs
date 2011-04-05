using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myNgheNghiepDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static NGHENGHIEP LayNgheNghiep(int _iMaNgheNghiep)
        {
            NGHENGHIEP _NgheNghiep = m_eStoreDataContext.NGHENGHIEPs.Single(Nghe => Nghe.MaNgheNghiep == _iMaNgheNghiep);
            return _NgheNghiep;
           /* myNgheNghiepDTO ngheNghiep = null;
            foreach (NGHENGHIEP ngheNghiep_DAO in m_eStoreDataContext.NGHENGHIEPs)
            {
                if (ngheNghiep_DAO.MaNgheNghiep == _iMaNgheNghiep)
                {
                    ngheNghiep = new myNgheNghiepDTO();
                    ngheNghiep.STenNgheNghiep = ngheNghiep_DAO.TenNgheNghiep;
                    break;
                }
            }
            return ngheNghiep;*/
        }

        public static List<NGHENGHIEP> LayNgheNghiep()
        {
           
            var Query = from NgheNghiep in m_eStoreDataContext.NGHENGHIEPs select NgheNghiep;
            List<NGHENGHIEP> DSNgheNghiep = new List<NGHENGHIEP>();
            foreach(NGHENGHIEP _NgheNghiep in Query )
            {
                DSNgheNghiep.Add(_NgheNghiep);
            }
            return DSNgheNghiep;
            /*List<myNgheNghiepDTO> danhSachNgheNghiep = new List<myNgheNghiepDTO>();

            foreach (NGHENGHIEP NgheNghiep_DAO in m_eStoreDataContext.NGHENGHIEPs)
            {
                myNgheNghiepDTO NgheNghiep_DTO = new myNgheNghiepDTO();
                NgheNghiep_DTO.STenNgheNghiep = NgheNghiep_DAO.TenNgheNghiep;
                danhSachNgheNghiep.Add(NgheNghiep_DTO);
            }
            return danhSachNgheNghiep;*/
        }
    }
}
