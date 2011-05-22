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
    class myTestKhachHangBUS
    {
        [Test]
        public void LayKhachHangTest()
        {
            myKhachHangBUS KhachHangBUS = new myKhachHangBUS();
            KHACHHANG KhachHang = null;
            KhachHang = KhachHangBUS.LayKhachHang(1);
            Assert.IsNotNull(KhachHang);
        }

        [Test]
        public void LayDSToanBoKhachHangTest()
        {
            myKhachHangBUS KhachHangBUS = new myKhachHangBUS();
            List<KHACHHANG> DanhSachKhachHang = KhachHangBUS.LayKhachHang();
            Assert.IsNotNull(DanhSachKhachHang);
        }

        [Test]
        public void SLKhachHangTheoNgheNghiep()
        {
            int SoLuongKHTheoNgheNghiep = myKhachHangBUS.SLKhachHangTheoNgheNghiep(1);
            Assert.Less(0, SoLuongKHTheoNgheNghiep);
        }

        [Test]
        public void SLKhachHangTheoMucDich()
        {
            int SoLuongKHTheoMucDich = myKhachHangBUS.SLKhachHangTheoMucDich(1);
            Assert.Less(0, SoLuongKHTheoMucDich);
        }


        [Test]
        public void SLKhachHangTheoDoTuoi()
        {
            int SoLuongKHTheoDoTuoi = myKhachHangBUS.SLKhachHangTheoDoTuoi(1);
            Assert.Less(0, SoLuongKHTheoDoTuoi);
        }

        [Test]
        public void SLKhachHangTheoTinhThanh()
        {
            int SoLuongKHTheoTinhThanh = myKhachHangBUS.SLKhachHangTheoTinhThanh(1);
            Assert.Less(0, SoLuongKHTheoTinhThanh);
        }

        [Test]
        public void SLKhachHangTheoGioiTinh()
        {
            int SoLuongKHTheoGioiTinh = myKhachHangBUS.SLKhachHangTheoGioiTinh(true);
            Assert.Less(0, SoLuongKHTheoGioiTinh);
        }
    }
}
