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
    class myTestChiTietDongManHinhDAO
    {
        [Test]
        public void TestLayChiTietDongManHinh()
        {
            myChiTietDongManHinhDTO dongManHinh = myChiTietDongManHinhDAO.LayChiTietDongManHinh(1);

            Assert.IsNotNull(dongManHinh);
            Assert.AreEqual("11.6 inches HD WLED", dongManHinh.STenDongManHinh);
            Assert.IsNotNull(dongManHinh.ChiTietKichThuocManHinh);
            Assert.AreEqual("LED", dongManHinh.ChiTietKichThuocManHinh.STenChiTietKichThuocManHinh);
        }
    }
}
