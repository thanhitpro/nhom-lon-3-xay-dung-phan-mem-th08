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
        public void TestLayDanhSachChiTietDongLaptop()
        {
            List<myChiTietDongLaptopDTO> listChiTietDongLaptop = myChiTietDongLaptopDAO.LayDanhSachChiTietDongLaptop();
            Assert.IsNotNull(listChiTietDongLaptop);
            Assert.Less(30, listChiTietDongLaptop.Count);
        }

        [Test]
        public void ThemMoiChiTietDongLaptopTest()
        {
            DataClasses1DataContext dataContext = new DataClasses1DataContext();
            CHITIETDONGLAPTOP dongLaptopCanThemMoi = new CHITIETDONGLAPTOP();
            dongLaptopCanThemMoi.TenChiTietDongLapTop = "dell";
            dongLaptopCanThemMoi.MaDongRAM = 1;
            dongLaptopCanThemMoi.MaDongOCung = 1;
            dongLaptopCanThemMoi.MaDongManHinh = 1;
            dongLaptopCanThemMoi.MaDongCardDoHoa = 1;
            dongLaptopCanThemMoi.MaDongLoa = 1;
            dongLaptopCanThemMoi.MaDongODiaQuang = 1;
            dongLaptopCanThemMoi.MaDongCardMang = 1;
            dongLaptopCanThemMoi.MaDongCardReader = 1;
            dongLaptopCanThemMoi.MaDongWebCam = 1;
            dongLaptopCanThemMoi.MaDongPin = 1;
            dongLaptopCanThemMoi.MaHeDieuHanh = 1;
            dongLaptopCanThemMoi.MaChiTietTrongLuong = 1;
            dongLaptopCanThemMoi.FingerprintReader = true;
            dongLaptopCanThemMoi.HDMI = true;
            dongLaptopCanThemMoi.SoLuongCongUSB = 3;
            dongLaptopCanThemMoi.MaNhaSanXuat = 1;
            dongLaptopCanThemMoi.MaDanhGia = 1;
            dongLaptopCanThemMoi.GiaBanHienHanh = 16700;
            dongLaptopCanThemMoi.MoTaThem = "";
            dongLaptopCanThemMoi.SoLuongNhap = 20;
            dongLaptopCanThemMoi.SoLuongConLai = 10;
            dongLaptopCanThemMoi.ThoiGianBaoHanh = 12;
            dongLaptopCanThemMoi.HinhAnh = "image/1.png";
            dongLaptopCanThemMoi.MauSac = "xanh";
            dongLaptopCanThemMoi.Deleted = false;
            dongLaptopCanThemMoi.NgayNhap = DateTime.Now;

            myChiTietDongLaptopDAO.ThemMoiChiTietDongLaptop(dongLaptopCanThemMoi);
            CHITIETDONGLAPTOP temp = (from dongLaptop in dataContext.CHITIETDONGLAPTOPs orderby dongLaptop.MaDongLapTop descending select dongLaptop).First();
            Assert.That(dongLaptopCanThemMoi.TenChiTietDongLapTop, Is.EqualTo(temp.TenChiTietDongLapTop));
            dataContext.CHITIETDONGLAPTOPs.DeleteOnSubmit(temp);
            dataContext.SubmitChanges();
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
        public void TestTraCuu()
        {

            myChiTietDongLaptopDAO laptop = new myChiTietDongLaptopDAO();

            InfoComboboxOfFormTraCuu infoCombobox = new InfoComboboxOfFormTraCuu();

            //mau sac
            infoCombobox.SMauSac = "Màu Đen ";
            Assert.That(laptop.TraCuu(infoCombobox)[0].STenChiTietDongLapTop, Is.EqualTo("ACER Aspire 4745 352G32Mn 041"));
            Assert.That(laptop.TraCuu(infoCombobox)[1].STenChiTietDongLapTop, Is.EqualTo("LAPTOP SONY VGN - CF112FX "));
            //            Assert.That(laptop.TraCuu(infoCombobox)[2].STenChiTietDongLapTop, Is.EqualTo("DELL Inspiron 14R N4030-JM1W74"));



            //ten laptop va mau sac (màu đen)
            infoCombobox.STendongLapTop = "ACER Aspire 4745 352G32Mn 041";

            Assert.That(laptop.TraCuu(infoCombobox)[0].STenChiTietDongLapTop, Is.EqualTo("ACER Aspire 4745 352G32Mn 041"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].SMauSac, Is.EqualTo("Màu Đen"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].IThoiGianBaoHanh, Is.EqualTo(12));

            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongRam.STenDongRAM, Is.EqualTo("4GB DDRAM3 KINGMAX"));

            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongOCung.STenDongOCung, Is.EqualTo("Sony HDD 320GB 7200rpm"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongCacDoHoa.STenDongCardDoHoa, Is.EqualTo("NDIVIA"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongCardMang.STenDongCardMang, Is.EqualTo("1 "));

            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongCPU.STenDongCPU, Is.EqualTo("EL Core i7-950 (3.06GHz)"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongCardReader.STenDongCardReader, Is.EqualTo(" 1"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongLoa.STenDongLoa, Is.EqualTo("Creative"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongManHinh.STenDongManHinh, Is.EqualTo("11.6 inches HD WLED"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongODiaQuang.STenDongODiaQuang, Is.EqualTo("DVD-16X SAMSUNG"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongPin.FTenDongPin, Is.EqualTo("1"));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietDongWebCam.STenDongWebCam, Is.EqualTo("1 "));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ChiTietHeDieuHanh.STenHeDieuHanh, Is.EqualTo("Win home "));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ISoLuongCongUSB, Is.EqualTo(2));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ISoLuongNhap, Is.EqualTo(50));
            Assert.That(laptop.TraCuu(infoCombobox)[0].ISoLuongConLai, Is.EqualTo(9));
            Assert.That(laptop.TraCuu(infoCombobox)[0].SHinhAnh, Is.EqualTo("image/1.png"));

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
        public void TestCapNhatChiTietDongCPU()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongCPU = 3;

            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();


            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongCPU(laptop, donglaptop).TenDongCPU, Is.EqualTo("EL Core i5-760 (2.8GHz)"));
        }

        [Test]
        public void TestCapNhatChiTietDongOCung()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongOCung = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongOCung(laptop, donglaptop).TenDongOCung, Is.EqualTo("Sony HDD 320GB 7200rpm"));
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
        public void TestCapNhatChiTietDongODiaQuang()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongODiaQuang = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongODiaQuang(laptop, donglaptop).TenDongODiaQuang, Is.EqualTo("DVD-16X SAMSUNG"));
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
        public void TestCapNhatChiTietDongWebCam()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongWebCam = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();

            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongWebCam(laptop, donglaptop).TenDongWebCam, Is.EqualTo("1 "));
        }

        [Test]
        public void TestCapNhatChiTietDongPin()
        {
            CHITIETDONGLAPTOP laptop = new CHITIETDONGLAPTOP();
            laptop.MaDongPin = 1;
            CHITIETDONGLAPTOP donglaptop = new CHITIETDONGLAPTOP();


            //            myChiTietDongLaptopDAO capnhat = new myChiTietDongLaptopDAO();

            Assert.That(myChiTietDongLaptopDAO.CapNhatChiTietDongPin(laptop, donglaptop).TenDongPin, Is.EqualTo("1"));
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
