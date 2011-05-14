using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDAO;
using EStoreDTO;

namespace EStoreTest
{
    [TestFixture]
    class myTestChiTietDongRamDAO
    {
        [Test]
        public void TestLayChiTietDongRam()
        {
            myChiTietDongRamDTO dongRAM = myChiTietDongRamDAO.LayChiTietDongRam(1);
            Assert.IsNotNull(dongRAM);
            Assert.IsNotNull(dongRAM.ChiTietBoNhoRam);
            Assert.IsNotNull(dongRAM.ChiTietCongNgheRam);
            Assert.AreEqual("4GB DDRAM3 KINGMAX", dongRAM.STenDongRAM);
        }
    }
}
