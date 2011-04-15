using System;
using System.Collections.Generic;
using System.Text;
using EStoreDTO;
using EStoreDAO;

namespace EStoreBUS
{
    public class myChiTietDongLaptopBUS
    {
        public static myChiTietDongLaptopDTO LayChiTietDongLaptop(int _iMaChiTietDongLaptop)
        {
            return myChiTietDongLaptopDAO.LayChiTietDongLaptop(_iMaChiTietDongLaptop);
        }
        public static List<myChiTietDongLaptopDTO> LayChiTietDongLaptop()
        {
            
            return myChiTietDongLaptopDAO.LayChiTietDongLaptop();
        }
        public List<myChiTietDongLaptopDTO> TraCuu(InfoComboboxOfFormTraCuu infoCombobox)
        {
            myChiTietDongLaptopDAO chiTietlapTop = new myChiTietDongLaptopDAO();
            return chiTietlapTop.TraCuu(infoCombobox);
        }
        public static bool KiemTraGiaTienHopLe(int _iMaDongLaptop, int _iMucGia)
        {
            myChiTietDongLaptopDTO chiTietDongLt = LayChiTietDongLaptop(_iMaDongLaptop);
            if (chiTietDongLt != null)
            {
                float giaLaptop = (float)chiTietDongLt.FGiaBanHienHanh;
                switch (_iMucGia)
                {
                    case 0:
                        return (giaLaptop < 8.0);
                    case 1:
                        return (giaLaptop >= 8.0 && giaLaptop < 10.0);
                    case 2:
                        return (giaLaptop >= 10.0 && giaLaptop < 12.0);
                    case 3:
                        return (giaLaptop >= 12.0 && giaLaptop < 14.0);
                    case 4:
                        return (giaLaptop >= 14.0 && giaLaptop < 16.0);
                    case 5:
                        return (giaLaptop >= 16.0 && giaLaptop < 22.0);
                    case 6:
                        return (giaLaptop >= 22.0 && giaLaptop < 26.0);
                    case 7:
                        return (giaLaptop >= 26.0);
                }
            }
            return false;
        }

        /// <summary>
        /// Xoa 1 dong laptop voi ma~ nam trong list
        /// </summary>
        /// <param name="_liMaDongLaptops"> danh sach cac ma dong laptop xoa</param>
        /// <returns> Boolean: cap nhat thanh cong hay that bai</returns>
        public static bool CapNhatXoaChiTietDongLaptop(List<int> _liMaDongLaptops)
        {
            return myChiTietDongLaptopDAO.CapNhatXoaChiTietDongLaptop(_liMaDongLaptops);
        }

        public static List<myChiTietDongLaptopDTO> LayChiTietDongLaptopMoiNhat(myChiTietDongLaptopDTO dongLaptop)
        {
            return myChiTietDongLaptopDAO.LayChiTietDongLaptopMoiNhat(dongLaptop);
        }
    }
}
