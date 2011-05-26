namespace EStoreBUS
{
    using System;
    using System.Collections.Generic;
    using EStoreDAO;
    using EStoreDTO;

    /// <summary>
    /// Lớp chi tiết dòng Webcam BUS
    /// </summary>
    public class MyChiTietDongWebcamBUS
    {
        /// <summary>
        /// Lấy chi tiết dòng webcam
        /// </summary>
        /// <param name="maChiTietDongWebcam">Mã chi tiết dòng webcame</param>
        /// <returns>trả về giá trị null</returns>
        public myChiTietDongWebcamDTO LayChiTietDongWebcam(int maChiTietDongWebcam)
        { 
            return null; 
        }

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
        /// <param name="tenWebcam">Tên của dòng Webcam</param>
        /// <returns>trả về mã dòng Webcam</returns>
        public int LayChiTietDongWebcam(string tenWebcam)
        {
            try
            {
                return myChiTietDongWebcamDAO.LayMaDongWebCam(tenWebcam);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
