using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;

namespace EStoreTestBUS
{
    [TestFixture]
    class myTestChiTietDongLaptopBUS
    {
        [Test]
        public void TestLayChiTietDongLaptop()
        {
            myChiTietDongLaptopDTO chiTietDongLapTopDTO = myChiTietDongLaptopBUS.LayChiTietDongLaptop(1);

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
        public void LayDanhSachChiTietDongLaptop()
        {
            List<myChiTietDongLaptopDTO> listChiTietDongLaptop = myChiTietDongLaptopBUS.LayDanhSachChiTietDongLaptop();

            Assert.IsNotNull(listChiTietDongLaptop);
            Assert.LessOrEqual(30, listChiTietDongLaptop.Count);
        }

        [Test]
        public void TestKiemTraGiaTienHopLe()
        {
            Assert.AreEqual(true,myChiTietDongLaptopBUS.KiemTraGiaTienHopLe(1,2));
        }
    }
}
