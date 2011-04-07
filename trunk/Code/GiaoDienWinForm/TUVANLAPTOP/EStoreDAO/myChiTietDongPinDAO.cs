using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myChiTietDongPinDAO
    {
        private static DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
        public static myChiTietDongPinDTO LayChiTietDongPin(int _iMaChiTietDongPin)
        {
            myChiTietDongPinDTO chiTietPin = null;

            var query = m_eStoreDataContext.CHITIETDONGPINs.Single(pin => pin.MaDongPin == _iMaChiTietDongPin);
            if (query != null)
            {
                chiTietPin = new myChiTietDongPinDTO();
                chiTietPin.FTenDongPin = query.TenDongPin;
                chiTietPin.FThoiGianSuDung = (float) query.ThoiGianSuDung;
                chiTietPin.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);
                
                myChiTietThoiLuongPinDTO chiTietThoiLuongPin = new myChiTietThoiLuongPinDTO();
                chiTietThoiLuongPin.STenThoiLuongPin = query.CHITIETTHOILUONGPIN.TenThoiLuongPin;
                chiTietThoiLuongPin.FHeSo = (float)query.CHITIETTHOILUONGPIN.HeSo;
                chiTietPin.ChiTietThoiLuongPin = chiTietThoiLuongPin;
            }

            return chiTietPin;
        }
        public List<myChiTietDongPinDTO> LayChiTietDongPin()
        {
            return null;
        }
    }
}
