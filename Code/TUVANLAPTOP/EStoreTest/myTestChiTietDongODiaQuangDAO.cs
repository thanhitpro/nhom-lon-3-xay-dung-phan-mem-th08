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
    class myTestChiTietDongODiaQuangDAO
    {
        [Test]
        public void TestLayChiTietDongODiaQuang()
        {
            myChiTietDongODiaQuangDTO dongODiaQuang = myChiTietDongODiaQuangDAO.LayChiTietDongODiaQuang(1);

            Assert.IsNotNull(dongODiaQuang);
            Assert.IsNotNull(dongODiaQuang.ChiTietCacKhaNangODiaQuang);
            Assert.AreEqual("DVD-16X SAMSUNG READER", dongODiaQuang.STenDongODiaQuang);
        }
    }
}
