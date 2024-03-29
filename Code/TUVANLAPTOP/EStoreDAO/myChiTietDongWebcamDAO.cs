﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongWebcamDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

        /// <summary>
        /// Lấy thông tin chi tiết dòng Webcam dựa vào mã dòng dòng Webcam
        /// </summary>
        /// <param name="_iMaChiTietDongWebcam">Mã dòng Webcam</param>
        /// <returns>
        ///     Thành công: trả về thông tin chi tiết dòng Webcam có mã chỉ định
        ///     Thất bại: throw một exception cho tầng trên xử lý
        /// </returns>
        public static myChiTietDongWebcamDTO LayChiTietDongWebcam(int _iMaChiTietDongWebcam)
        {
            try
            {
                myChiTietDongWebcamDTO chiTietWebcam = null;
                var query = m_eStoreDataContext.CHITIETDONGWEBCAMs.Single(wc => wc.MaDongWebCam == _iMaChiTietDongWebcam);
                if (query != null)
                {
                    chiTietWebcam = new myChiTietDongWebcamDTO();
                    chiTietWebcam.STenDongWebCam = query.TenDongWebCam;
                    chiTietWebcam.FDoPhanGiai = (float)query.DoPhanGiai;
                    chiTietWebcam.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);
                }
                return chiTietWebcam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy thông tin tất cả các dòng webcam
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongWebcamDTO> LayChiTietDongWebcam()
        {
            List<myChiTietDongWebcamDTO> dsWebCam = new List<myChiTietDongWebcamDTO>();
            DataClasses1DataContext m_EStoreComtext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStoreComtext.CHITIETDONGWEBCAMs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGWEBCAM webcam in query)
                {
                    myChiTietDongWebcamDTO chiTietWebcam = new myChiTietDongWebcamDTO();
                    chiTietWebcam.STenDongWebCam = webcam.TenDongWebCam;
                    chiTietWebcam.IMaDongWebcam = webcam.MaDongWebCam;
                    chiTietWebcam.FDoPhanGiai = (float)webcam.DoPhanGiai;
                    chiTietWebcam.NhaSanXuat = new myNhaSanXuatDTO(webcam.NHASANXUAT.TenNhaSanXuat);
                    dsWebCam.Add(chiTietWebcam);
                }
                return dsWebCam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lay thong tin ma webcam tu ten webcam
        /// </summary>
        /// <param name="TenRam"></param>
        /// <returns></returns>
        public static int LayMaDongWebCam(string _sTenWebCam)
        {
            try
            {
                int maWebCam = -1;
                DataClasses1DataContext m_EStore = new DataClasses1DataContext();
                var query = from p in m_EStore.CHITIETDONGWEBCAMs where p.TenDongWebCam == _sTenWebCam select p;
                if (query == null)
                    return maWebCam;
                foreach (CHITIETDONGWEBCAM laptop in query)
                {
                    maWebCam = laptop.MaDongWebCam;
                    break;
                }
                return maWebCam;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
