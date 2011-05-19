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
            List<int> maDongLaptop = new List<int> { 1, 2, 3, 4 };
            myChiTietDongLaptopDAO.CapNhatXoaChiTietDongLaptop(maDongLaptop);

            for (int i = 0; i < maDongLaptop.Count(); i++)
            {
                myChiTietDongLaptopDTO kiemTraGiaTri = myChiTietDongLaptopDAO.LayChiTietDongLaptop(maDongLaptop[i]);
                Assert.AreEqual(true, kiemTraGiaTri.BDeleted);
            }
            myChiTietDongLaptopDAO.CapNhatXoaChiTietDongLaptop(maDongLaptop);
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
    }
}
