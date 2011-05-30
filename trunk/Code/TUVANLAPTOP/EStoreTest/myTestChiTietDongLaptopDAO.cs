using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using EStoreDAO;
using EStoreDTO;

namespace EStoreTest
{
    [TestFixture]
    public class myTestChiTietDongLaptopDAO
    {
        [Test]
        public void TestLayChiTietDongLaptop()
        {
            myChiTietDongLaptopDTO chiTietDongLapTopDTO = myChiTietDongLaptopDAO.LayChiTietDongLaptop(1);

            Assert.IsNotNull(chiTietDongLapTopDTO);
            Assert.AreEqual("ACER Aspire 4745 352G32Mn 041", chiTietDongLapTopDTO.STenChiTietDongLapTop.Trim());
            Assert.AreEqual(1, chiTietDongLapTopDTO.BFingerprintReader);
            Assert.AreEqual(1, chiTietDongLapTopDTO.BHDMI);
            Assert.AreEqual(2, chiTietDongLapTopDTO.ISoLuongCongUSB);
            Assert.AreEqual(10454, chiTietDongLapTopDTO.FGiaBanHienHanh);
            Assert.AreEqual(12, chiTietDongLapTopDTO.IThoiGianBaoHanh);
            Assert.AreEqual(50, chiTietDongLapTopDTO.ISoLuongNhap);
            Assert.AreEqual("Màu Đen", chiTietDongLapTopDTO.SMauSac.Trim());
            Assert.AreEqual("image/1.png", chiTietDongLapTopDTO.SHinhAnh);
        }


        [Test]
        public void CapNhatXoaChiTietDongLaptop_Test()
        {
            List<int> maDongLaptop = new List<int> {1,5,29,30};
            Assert.AreEqual(true,myChiTietDongLaptopDAO.CapNhatXoaChiTietDongLaptop(maDongLaptop));
        }

        [Test]
        public void TestTaoChiTietLapTop()
        {
            DataClasses1DataContext storeDataContext = new DataClasses1DataContext();
            CHITIETDONGLAPTOP chiTietDongLaptop = storeDataContext.CHITIETDONGLAPTOPs.Single(laptop => laptop.MaDongLapTop == 1);
            myChiTietDongLaptopDTO dongLaptopKetQua = myChiTietDongLaptopDAO.TaoChiTietLapTop(chiTietDongLaptop);

            Assert.AreEqual(chiTietDongLaptop.MaDongLapTop, dongLaptopKetQua.IMaDongLaptop);
        }

        [Test]
        public void TestLayChiTietDongLaptopMoiNhat()
        {
            DataClasses1DataContext storeDataContext = new DataClasses1DataContext();
            CHITIETDONGLAPTOP chiTietDongLaptop = storeDataContext.CHITIETDONGLAPTOPs.Single(laptop => laptop.MaDongLapTop == 1);
            myChiTietDongLaptopDTO dongLaptopKetQua = myChiTietDongLaptopDAO.TaoChiTietLapTop(chiTietDongLaptop);

            List<myChiTietDongLaptopDTO> listLaptopMoiNhat = myChiTietDongLaptopDAO.LayChiTietDongLaptopMoiNhat(dongLaptopKetQua);
            Assert.IsNotNull(listLaptopMoiNhat);
        }


        [Test]
        public void TestCapNhatChiTietDongLaptop()
        {
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            donglaptop.MaDongLapTop = 4;
            donglaptop.TenChiTietDongLapTop = "Dell";
            donglaptop.MaDongRAM = 1;
            donglaptop.MaDongCPU = 3;
            donglaptop.MaDongOCung = 1;
            donglaptop.MaDongManHinh = 1;
            donglaptop.MaDongCardDoHoa = 1;
            donglaptop.MaDongLoa = 1;
            donglaptop.MaDongODiaQuang = 1;
            donglaptop.MaHeDieuHanh = 1;
            donglaptop.MaChiTietTrongLuong = 1;
            donglaptop.ThoiGianBaoHanh = 11;
            donglaptop.MauSac = "Màu Đỏ";
            donglaptop.GiaBanHienHanh = 11;
            donglaptop.MaDongCardMang = 1;
            donglaptop.MaDongCardReader = 1;
            donglaptop.MaDongWebCam = 1;
            donglaptop.MaDongPin = 1;
            donglaptop.FingerprintReader = true;
            donglaptop.HDMI = true;
            donglaptop.SoLuongCongUSB = 3;
            donglaptop.MaNhaSanXuat = 1;
            donglaptop.SoLuongConLai = 10;
            donglaptop.MoTaThem = "Đẹp - gọn - nhẹ";
            donglaptop.SoLuongNhap = 100;
            donglaptop.NgayNhap = DateTime.Parse("11/11/2011");
            donglaptop.HinhAnh = "images/fsdfsdf";

            Assert.AreEqual(true, myChiTietDongLaptopDAO.CapNhatChiTietDongLaptop(donglaptop));


        }

        [Test]
        public void TestCapNhatTenDongLapTop()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.TenChiTietDongLapTop = "123";
            laptop.MaDongLapTop = 4;


            Assert.That(myChiTietDongLaptopDAO.CapNhatTenChiTietDongLapTop(laptop).TenChiTietDongLapTop, Is.EqualTo("123"));
        }
        [Test]
        public void TestCapNhatChiTietDongRam()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongRAM = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongRam(laptop, donglaptop).TenDongRAM
                        , Is.EqualTo("4GB DDRAM3 KINGMAX"));
        }


        [Test]
        public void TestCapNhatChiTietDongManHinh()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongManHinh = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongManHinh(laptop, donglaptop).TenDongManHinh, Is.EqualTo("11.6 inches HD WLED"));
        }

        [Test]
        public void TestCapNhatChiTietDongCardDoHoa()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongCardDoHoa = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongCardDoHoa(laptop, donglaptop).TenDongCardDoHoa, Is.EqualTo("NDIVIA"));
        }

        [Test]
        public void TestCapNhatChiTietDongLoa()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongLoa = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongLoa(laptop, donglaptop).TenDongDongLoa, Is.EqualTo("Creative"));
        }


        [Test]
        public void TestCapNhatHeDieuHanh()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaHeDieuHanh = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatHeDieuHanh(laptop, donglaptop).MaChiTietHeDieuHanh, Is.EqualTo(1));
        }

        [Test]
        public void TestCapNhatChiTietTrongLuong()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaChiTietTrongLuong = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietTrongLuong(laptop, donglaptop).GiaTriTrongLuong, Is.EqualTo(1));
        }

        [Test]
        public void TestCapNhatChiTietDongCardMang()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongCardMang = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongCardMang(laptop, donglaptop).TenDongCardMang, Is.EqualTo("1 "));
        }

        [Test]
        public void TestCapNhatChiTietDongCardReader()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongCardReader = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongCardReader(laptop, donglaptop).TenDongCardReader, Is.EqualTo(" 1"));
        }


        [Test]
        public void TestCapNhatNhaSanXuat()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaNhaSanXuat = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatNhaSanXuat(laptop, donglaptop).TenNhaSanXuat, Is.EqualTo("Apple"));
        }

    }
}
