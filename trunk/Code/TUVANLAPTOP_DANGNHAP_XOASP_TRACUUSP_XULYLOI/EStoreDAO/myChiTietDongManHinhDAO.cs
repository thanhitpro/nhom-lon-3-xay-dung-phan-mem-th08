﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongManHinhDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        /// <summary>
        /// Lay thong tin man hinh tu ma man hinh
        /// </summary>
        /// <param name="_iMaChiTietDongManHinh"></param>
        /// <returns></returns>
        public static myChiTietDongManHinhDTO LayChiTietDongManHinh(int _iMaChiTietDongManHinh)
        {
            myChiTietDongManHinhDTO chiTietManHinh = null;

            var query = m_eStoreDataContext.CHITIETDONGMANHINHs.Single(manhinh => manhinh.MaDongManHinh == _iMaChiTietDongManHinh);
            if (query != null)
            {
                chiTietManHinh = new myChiTietDongManHinhDTO();
                chiTietManHinh.STenDongManHinh = query.TenDongManHinh;
                chiTietManHinh.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietKichThuocManHinhDTO chiTietKichThuoc = new myChiTietKichThuocManHinhDTO();
                chiTietKichThuoc.STenChiTietKichThuocManHinh = query.CHITIETKICHTHUOCMANHINH.TenChiTietKichThuocManHinh;
                chiTietKichThuoc.FHeSo = (float)query.CHITIETKICHTHUOCMANHINH.HeSo;

                chiTietManHinh.ChiTietKichThuocManHinh = chiTietKichThuoc;
            }

            return chiTietManHinh;
        }
        /// <summary>
        /// Lay thong tin tat ca cac dong man hinh
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongManHinhDTO> LayChiTietDongManHinh()
        {
            List<myChiTietDongManHinhDTO> dsManHinh = new List<myChiTietDongManHinhDTO>();
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            var query = from p in m_EStore.CHITIETDONGMANHINHs select p;
            if (query == null)
                return null;
            foreach (CHITIETDONGMANHINH manhinh in query)
            {
                myChiTietDongManHinhDTO chiTietManHinh = new myChiTietDongManHinhDTO();
                chiTietManHinh.STenDongManHinh = manhinh.TenDongManHinh;
                chiTietManHinh.NhaSanXuat = new myNhaSanXuatDTO(manhinh.NHASANXUAT.TenNhaSanXuat);

                myChiTietKichThuocManHinhDTO chiTietKichThuoc = new myChiTietKichThuocManHinhDTO();
                chiTietKichThuoc.STenChiTietKichThuocManHinh = manhinh.CHITIETKICHTHUOCMANHINH.TenChiTietKichThuocManHinh;
                chiTietKichThuoc.FHeSo = (float)manhinh.CHITIETKICHTHUOCMANHINH.HeSo;

                chiTietManHinh.ChiTietKichThuocManHinh = chiTietKichThuoc;
                dsManHinh.Add(chiTietManHinh);
            }
            return dsManHinh;
        }
        public static int LayMaDongManHinh(string _sTenMaHinh)
        {
            int iMaManHinh = -1;
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            var query = from p in m_EStore.CHITIETDONGMANHINHs where p.TenDongManHinh == _sTenMaHinh select p;
            if (query == null)
                return iMaManHinh;
            foreach (CHITIETDONGMANHINH laptop in query)
            {
                iMaManHinh = laptop.MaDongManHinh;
                break;
            }
            return iMaManHinh;
        }
    }
}