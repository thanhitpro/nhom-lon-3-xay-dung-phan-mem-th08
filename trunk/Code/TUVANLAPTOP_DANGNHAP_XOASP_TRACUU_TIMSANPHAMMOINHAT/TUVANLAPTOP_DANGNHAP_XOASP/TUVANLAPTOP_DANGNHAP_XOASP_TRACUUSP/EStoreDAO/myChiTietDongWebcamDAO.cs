using System;
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
        /// lay thong tin webcam dua vao thong tin ma webcam
        /// </summary>
        /// <param name="_iMaChiTietDongWebcam">ma webcam</param>
        /// <returns></returns>
        public static myChiTietDongWebcamDTO LayChiTietDongWebcam(int _iMaChiTietDongWebcam)
        {
            myChiTietDongWebcamDTO chiTietWebcam = null;
            var query = m_eStoreDataContext.CHITIETDONGWEBCAMs.Single(wc => wc.MaDongWebCam == _iMaChiTietDongWebcam);
            if (query != null)
            {
                chiTietWebcam = new myChiTietDongWebcamDTO();
                chiTietWebcam.STenDongWebCam = query.TenDongWebCam;
                chiTietWebcam.FDoPhanGiai = (float) query.DoPhanGiai;
                chiTietWebcam.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);
            }
            return chiTietWebcam;
        }
        /// <summary>
        /// lay thong tin tat ca cac dong webcam
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongWebcamDTO> LayChiTietDongWebcam()
        {
            List<myChiTietDongWebcamDTO> dsWebCam = new List<myChiTietDongWebcamDTO>();
            DataClasses1DataContext m_EStoreComtext = new DataClasses1DataContext();
            var query = from p in m_EStoreComtext.CHITIETDONGWEBCAMs select p;
            if (query == null)
                return null;
            foreach (CHITIETDONGWEBCAM webcam in query)
            {
                myChiTietDongWebcamDTO chiTietWebcam = new myChiTietDongWebcamDTO();
                chiTietWebcam.STenDongWebCam = webcam.TenDongWebCam;
                chiTietWebcam.FDoPhanGiai = (float)webcam.DoPhanGiai;
                chiTietWebcam.NhaSanXuat = new myNhaSanXuatDTO(webcam.NHASANXUAT.TenNhaSanXuat);
                dsWebCam.Add(chiTietWebcam);
            }
            return dsWebCam;
        }
        /// <summary>
        /// Lay thong tin ma webcam tu ten webcam
        /// </summary>
        /// <param name="TenRam"></param>
        /// <returns></returns>
        public static int LayMaDongWebCam(string _sTenWebCam)
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
    }
}
