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
    class myTestChiTietDongOCungDAO
    {
        [Test]
        public void TestLayChiTietDongOCung()
        {
            myChiTietDongOCungDTO dongOCung = myChiTietDongOCungDAO.LayChiTietDongOCung(1);

            Assert.IsNotNull(dongOCung);
            Assert.IsNotNull(dongOCung.ChiTietDungLuongOCung);
            Assert.IsNotNull(dongOCung.ChiTietVongQuayOCung);
            Assert.IsNotNull(dongOCung.NhaSanXuat);

            Assert.AreEqual("HDD 320GB 7200rpm", dongOCung.STenDongOCung);
        }
    }
}
