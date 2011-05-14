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
    class myTestDanhGiaDAO
    {
        [Test]
        public void TestLayDanhGia()
        {
            myDanhGiaDTO danhGia = myDanhGiaDAO.LayDanhGia(1);

            Assert.IsNotNull(danhGia);
            Assert.AreEqual(1000, danhGia.ITongDiem);
        }
    }
}
