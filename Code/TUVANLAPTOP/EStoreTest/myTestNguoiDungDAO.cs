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
    public class myTestNguoiDungDAO
    {
        [Test]
        public void TestKiemTraNguoiDungTonTai()
        {
            Assert.AreEqual(true, myNguoiDungDAO.KiemTraNguoiDungTonTai("admin", "123456"));
            Assert.AreNotEqual(true, myNguoiDungDAO.KiemTraNguoiDungTonTai("xyz", "123456"));
        }
    }
}
