using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreDAO;
using EStoreBUS;

namespace EStoreTestBUS
{
    [TestFixture]
    class MyTestKhachHangBUS
    {
        [Test]
        public void LayKhachHangTest()
        {
            MyKhachHangBUS KhachHangBUS = new MyKhachHangBUS();
            KHACHHANG KhachHang = null;
            KhachHang = KhachHangBUS.LayKhachHang(1);
            Assert.IsNotNull(KhachHang);
        }

        [Test]
        public void LayDSToanBoKhachHangTest()
        {
            MyKhachHangBUS KhachHangBUS = new MyKhachHangBUS();
            List<KHACHHANG> DanhSachKhachHang = KhachHangBUS.LayKhachHang();
            Assert.IsNotNull(DanhSachKhachHang);
        }

        [Test]
        public void SLKhachHangTheoNgheNghiep()
        {
            int SoLuongKHTheoNgheNghiep = MyKhachHangBUS.SLKhachHangTheoNgheNghiep(1);
            Assert.Less(0, SoLuongKHTheoNgheNghiep);
        }

        [Test]
        public void SLKhachHangTheoMucDich()
        {
            int SoLuongKHTheoMucDich = MyKhachHangBUS.SLKhachHangTheoMucDich(1);
            Assert.Less(0, SoLuongKHTheoMucDich);
        }


        [Test]
        public void SLKhachHangTheoDoTuoi()
        {
            int SoLuongKHTheoDoTuoi = MyKhachHangBUS.SLKhachHangTheoDoTuoi(1);
            Assert.Less(0, SoLuongKHTheoDoTuoi);
        }

        [Test]
        public void SLKhachHangTheoTinhThanh()
        {
            int SoLuongKHTheoTinhThanh = MyKhachHangBUS.SLKhachHangTheoTinhThanh(1);
            Assert.Less(0, SoLuongKHTheoTinhThanh);
        }

        [Test]
        public void SLKhachHangTheoGioiTinh()
        {
            int SoLuongKHTheoGioiTinh = MyKhachHangBUS.SLKhachHangTheoGioiTinh(true);
            Assert.Less(0, SoLuongKHTheoGioiTinh);
        }
    }
}
