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
    public class myTestChiTietDongLaptopDAO
    {
        [Test]
        public void TestLayChiTietDongLaptop()
        {
            myChiTietDongLaptopDTO dongLaptop = myChiTietDongLaptopDAO.LayChiTietDongLaptop(1);

            Assert.IsNotNull(dongLaptop);
            Assert.IsNotNull(dongLaptop.ChiTietDongCacDoHoa);
            Assert.IsNotNull(dongLaptop.ChiTietDongCardMang);
            Assert.IsNotNull(dongLaptop.ChiTietDongCardReader);
            Assert.IsNotNull(dongLaptop.ChiTietDongCPU);
            Assert.IsNotNull(dongLaptop.ChiTietDongLoa);
            Assert.IsNotNull(dongLaptop.ChiTietDongManHinh);
            Assert.IsNotNull(dongLaptop.ChiTietDongOCung);
            Assert.IsNotNull(dongLaptop.ChiTietDongODiaQuang);
            Assert.IsNotNull(dongLaptop.ChiTietDongPin);
            Assert.IsNotNull(dongLaptop.ChiTietDongRam);
            Assert.IsNotNull(dongLaptop.ChiTietDongWebCam);
            Assert.IsNotNull(dongLaptop.ChiTietHeDieuHanh);
            Assert.IsNotNull(dongLaptop.ChiTietTrongLuong);
            Assert.IsNotNull(dongLaptop.DanhGia);
            Assert.IsNotNull(dongLaptop.NhaSanXuat);
            Assert.AreEqual("ACER Aspire 4745 352G32Mn 041", dongLaptop.STenChiTietDongLapTop);
        }
    }
}
