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
        /// <summary>
        /// lay thong tin dong pin dua vao ma dong pin
        /// </summary>
        /// <param name="_iMaChiTietDongPin">ma dong pin </param>
        /// <returns></returns>
        public static myChiTietDongPinDTO LayChiTietDongPin(int _iMaChiTietDongPin)
        {
            myChiTietDongPinDTO chiTietPin = null;

            var query = m_eStoreDataContext.CHITIETDONGPINs.Single(pin => pin.MaDongPin == _iMaChiTietDongPin);
            if (query != null)
            {
                chiTietPin = new myChiTietDongPinDTO();
                chiTietPin.FTenDongPin = query.TenDongPin;
                chiTietPin.FThoiGianSuDung = (float)query.ThoiGianSuDung;
                chiTietPin.NhaSanXuat = new myNhaSanXuatDTO(query.NHASANXUAT.TenNhaSanXuat);

                myChiTietThoiLuongPinDTO chiTietThoiLuongPin = new myChiTietThoiLuongPinDTO();
                chiTietThoiLuongPin.STenThoiLuongPin = query.CHITIETTHOILUONGPIN.TenThoiLuongPin;
                chiTietThoiLuongPin.FHeSo = (float)query.CHITIETTHOILUONGPIN.HeSo;
                chiTietPin.ChiTietThoiLuongPin = chiTietThoiLuongPin;
            }

            return chiTietPin;
        }
        /// <summary>
        /// Lay tat cac thong tin cac dong pin trong csdl
        /// </summary>
        /// <returns></returns>
        public List<myChiTietDongPinDTO> LayChiTietDongPin()
        {
            List<myChiTietDongPinDTO> dsPin = new List<myChiTietDongPinDTO>();
            DataClasses1DataContext m_EStoreContext = new DataClasses1DataContext();
            try
            {
                var query = from p in m_EStoreContext.CHITIETDONGPINs select p;
                if (query == null)
                    return null;
                foreach (CHITIETDONGPIN pin in query)
                {
                    myChiTietDongPinDTO chiTietPin = new myChiTietDongPinDTO();
                    chiTietPin.FTenDongPin = pin.TenDongPin;
                    chiTietPin.FThoiGianSuDung = (float)pin.ThoiGianSuDung;
                    chiTietPin.NhaSanXuat = new myNhaSanXuatDTO(pin.NHASANXUAT.TenNhaSanXuat);

                    myChiTietThoiLuongPinDTO chiTietThoiLuongPin = new myChiTietThoiLuongPinDTO();
                    chiTietThoiLuongPin.STenThoiLuongPin = pin.CHITIETTHOILUONGPIN.TenThoiLuongPin;
                    chiTietThoiLuongPin.FHeSo = (float)pin.CHITIETTHOILUONGPIN.HeSo;
                    chiTietPin.ChiTietThoiLuongPin = chiTietThoiLuongPin;
                    dsPin.Add(chiTietPin);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dsPin;
        }
        /// <summary>
        /// Lay thong tin ma dong pin dua vao ten dong pin
        /// </summary>
        /// <param name="_sTenDongPin">Ten dong pin</param>
        /// <returns></returns>
        public static int LayMaDongPin(string _sTenDongPin)
        {
            int maDongPin = -1;
            DataClasses1DataContext m_EStore = new DataClasses1DataContext();
            var query = from p in m_EStore.CHITIETDONGPINs where p.TenDongPin == _sTenDongPin select p;
            if (query == null)
                return maDongPin;
            foreach (CHITIETDONGPIN laptop in query)
            {
                maDongPin = laptop.MaDongPin;
                break;
            }
            return maDongPin;

        }
    }
}
