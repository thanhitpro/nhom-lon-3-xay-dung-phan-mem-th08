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

        public List<myChiTietDongWebcamDTO> LayChiTietDongWebcam()
        {
            myChiTietDongWebcamDAO chiTietWebCam = new myChiTietDongWebcamDAO();
            return chiTietWebCam.LayChiTietDongWebcam();
        }
    }
}
