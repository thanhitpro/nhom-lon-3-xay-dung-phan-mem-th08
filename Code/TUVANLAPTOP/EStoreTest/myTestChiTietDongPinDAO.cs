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
    class myTestChiTietDongPinDAO
    {
        [Test]
        public void TestLayChiTietDongPin()
        {
            myChiTietDongPinDTO dongPin = myChiTietDongPinDAO.LayChiTietDongPin(1);
            
            Assert.IsNotNull(dongPin);
            Assert.IsNotNull(dongPin.ChiTietThoiLuongPin);
            Assert.AreEqual("3 giờ",dongPin.FTenDongPin);
            Assert.AreEqual(3, dongPin.FThoiGianSuDung);
        }
    }
}
