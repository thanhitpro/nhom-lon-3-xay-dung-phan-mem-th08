using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;
using TUVANLAPTOP;
using NUnit.Framework;

namespace EStoreTestTUVANLAPTOP
{

    [TestFixture]
    class myTestTHEMSANPHAM
    {
        THEMSANPHAM myThemSanPham_test = new THEMSANPHAM();

        [Test]
        public void LoadRAM_Test()
        {            
            Assert.AreEqual(true, myThemSanPham_test.LoadRAM());
        }

        [Test]
        public void LoadCPU_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadCPU());
        }

        [Test]
        public void LoadOCung_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadOCung());
        }

        [Test]
        public void LoadManHinh_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadManHinh());
        }

        [Test]
        public void LoadCardManHinh_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadCardManHinh());
        }

        [Test]
        public void LoadDongLoa_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadDongLoa());
        }

        [Test]
        public void LoadODiaQuang_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadODiaQuang());
        }

        [Test]
        public void LoadHeDieuHanh_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadHeDieuHanh());
        }

        [Test]
        public void LoadTrongLuong_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadTrongLuong());
        }

        [Test]
        public void LoadTenVaMauSac_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadTenVaMauSac());
        }

        [Test]
        public void LoadCardMang_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadCardMang());
        }

        [Test]
        public void LoadCardReader_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadCardReader());
        }

        [Test]
        public void LoadWebcam_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadWebcam());
        }

        [Test]
        public void LoadPin_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadPin());
        }

        [Test]
        public void LoadKhaNangNhanDangVanTay_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadKhaNangNhanDangVanTay());
        }

        [Test]
        public void LoadCongHDMI_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadCongHDMI());
        }

        [Test]
        public void LoadSoCongUSB_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadSoCongUSB());
        }

        [Test]
        public void LoadNhaSX_Test()
        {
            Assert.AreEqual(true, myThemSanPham_test.LoadNhaSX());
        }

        [Test]
        public void LayThongTinLaptopMoi_Test()
        {
            myThemSanPham_test.LoadRAM();
            myThemSanPham_test.LoadCPU();
            myThemSanPham_test.LoadOCung();
            myThemSanPham_test.LoadManHinh();
            myThemSanPham_test.LoadCardManHinh();
            myThemSanPham_test.LoadDongLoa();
            myThemSanPham_test.LoadODiaQuang();
            myThemSanPham_test.LoadHeDieuHanh();
            myThemSanPham_test.LoadTrongLuong();
            myThemSanPham_test.LoadTenVaMauSac();
            myThemSanPham_test.LoadCardMang();
            myThemSanPham_test.LoadCardReader();
            myThemSanPham_test.LoadWebcam();
            myThemSanPham_test.LoadPin();
            myThemSanPham_test.LoadKhaNangNhanDangVanTay();
            myThemSanPham_test.LoadCongHDMI();
            myThemSanPham_test.LoadSoCongUSB();
            myThemSanPham_test.LoadNhaSX();

            myThemSanPham_test.GanThongTinTextBox_Test("Asus N43J", "1", "1", "Asus");
            CHITIETDONGLAPTOP dongLaptop = new CHITIETDONGLAPTOP();
            dongLaptop = myThemSanPham_test.LayThongTinLaptopMoi();
            Assert.AreEqual("Asus N43J", dongLaptop.TenChiTietDongLapTop);
            Assert.AreEqual(1, dongLaptop.SoLuongNhap);
            //Assert.AreEqual(1000000, dongLaptop.GiaBanHienHanh);
        }
    }
}
