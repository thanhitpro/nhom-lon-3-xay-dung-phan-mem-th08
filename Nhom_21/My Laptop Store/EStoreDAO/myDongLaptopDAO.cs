using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;

namespace EStoreDAO
{
    public class myDongLaptopDAO
    {
        /// <summary>
        /// DataContext làm việc với LINQ
        /// </summary> 
        private EStoreDataContext m_eDB = new EStoreDataContext(); 

        /// <summary>
        /// Hàm lấy danh sách tất cả các dòng laptop
        /// </summary>
        public List<myDongLaptop> LayDSDongLaptop()
        {
            var query = from dongLapTop in m_eDB.CHITIETDONGLAPTOPs select dongLapTop;
            List<myDongLaptop> danhSachDongLaptop = new List<myDongLaptop>();
            foreach (CHITIETDONGLAPTOP dongLT in query)
            {
                danhSachDongLaptop.Add(new myDongLaptop() {IMaDong = dongLT.MaDongLapTop,STenDong = dongLT.TenChiTietDongLapTop,SHinhAnh = dongLT.HinhAnh,SMauSac = dongLT.MauSac,SMoTaThem = dongLT.MoTaThem,FGiaBanHienHanh= (float)dongLT.GiaBanHienHanh,IThoiGianBaoHanh = (int)dongLT.ThoiGianBaoHanh,NMaNhaSX = new myNhaSX((int)dongLT.MaNhaSanXuat,dongLT.NHASANXUAT.TenNhaSanXuat)});
            }
            return danhSachDongLaptop;
        }

        /// <summary>
        /// Hàm lấy danh sách tất cả các dòng laptop của một nhà sản xuất
        /// </summary>
        public List<myDongLaptop> LayDSDongLaptop(int _iMaNhaSX)
        {
            var query = from dongLapTop in m_eDB.CHITIETDONGLAPTOPs where dongLapTop.MaNhaSanXuat==_iMaNhaSX  select dongLapTop;
            List<myDongLaptop> danhSachDongLaptop = new List<myDongLaptop>();
            foreach (CHITIETDONGLAPTOP dongLT in query)
            {
                danhSachDongLaptop.Add(new myDongLaptop() { IMaDong = dongLT.MaDongLapTop, STenDong = dongLT.TenChiTietDongLapTop, SHinhAnh = dongLT.HinhAnh, SMauSac = dongLT.MauSac, SMoTaThem = dongLT.MoTaThem, FGiaBanHienHanh = (float)dongLT.GiaBanHienHanh, IThoiGianBaoHanh = (int)dongLT.ThoiGianBaoHanh });
            }
            return danhSachDongLaptop;
        }
    }
}