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

        public List<myChiTietDongWebcamDTO> LayChiTietDongWebcam()
        {
            return null;
        }
    }
}
