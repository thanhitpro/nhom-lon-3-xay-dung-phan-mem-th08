using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongWebcamBUS
    {
        public myChiTietDongWebcamDTO LayChiTietDongWebcam(int _iMaChiTietDongWebcam)
        { return null; }

        /// <summary>
        /// Lấy danh sách tất cả các dòng webcam
        /// </summary>
        /// <returns>Danh sách tất cả các dòng webcam</returns>
        public List<myChiTietDongWebcamDTO> LayChiTietDongWebcam()
        {
            myChiTietDongWebcamDAO chiTietWebCam = new myChiTietDongWebcamDAO();
            try
            {
                return chiTietWebCam.LayChiTietDongWebcam();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Lấy mã webcam dựa vào tên webcam
        /// </summary>
        /// <returns></returns>
        public int LayChiTietDongWebcam(string m_tenWebCam)
        {
            try
            {
                return myChiTietDongWebcamDAO.LayMaDongWebCam(m_tenWebCam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
