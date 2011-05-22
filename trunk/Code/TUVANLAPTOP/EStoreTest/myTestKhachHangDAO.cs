using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreDAO;

namespace EStoreTest
{
    [TestFixture]
    class myTestKhachHangDAO
    {
        [Test]
        public void LayKhachHangTest()
        {
            KHACHHANG KhachHang= null;
            KhachHang = myKhachHangDAO.LayKhachHang(1);
            Assert.IsNotNull(KhachHang);
        }

        [Test]
        public void LayDSToanBoKhachHangTest()
        {
            List<KHACHHANG> DanhSachKhachHang = myKhachHangDAO.LayKhachHang();
            Assert.IsNotNull(DanhSachKhachHang);
        }

        [Test]
        public void SLKhachHangTheoNgheNghiep()
        {
            int SoLuongKHTheoNgheNghiep = myKhachHangDAO.SLKhachHangTheoNgheNghiep(1);
            Assert.Less(0, SoLuongKHTheoNgheNghiep);
        }

        [Test]
        public void SLKhachHangTheoMucDich()
        {
            int SoLuongKHTheoMucDich = myKhachHangDAO.SLKhachHangTheoMucDich(1);
            Assert.Less(0, SoLuongKHTheoMucDich);
        }


        [Test]
        public void SLKhachHangTheoDoTuoi()
        {
            int SoLuongKHTheoDoTuoi = myKhachHangDAO.SLKhachHangTheoDoTuoi(1);
            Assert.Less(0, SoLuongKHTheoDoTuoi);
        }

        [Test]
        public void SLKhachHangTheoTinhThanh()
        {
            int SoLuongKHTheoTinhThanh = myKhachHangDAO.SLKhachHangTheoTinhThanh(1);
            Assert.Less(0, SoLuongKHTheoTinhThanh);
        }

        [Test]
        public void SLKhachHangTheoGioiTinh()
        {
            int SoLuongKHTheoGioiTinh = myKhachHangDAO.SLKhachHangTheoGioiTinh(true);
            Assert.Less(0, SoLuongKHTheoGioiTinh);
        }
    }
}
