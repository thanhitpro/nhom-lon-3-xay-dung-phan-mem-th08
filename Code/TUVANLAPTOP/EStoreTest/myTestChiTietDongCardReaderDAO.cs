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
    public class myTestChiTietDongCardReaderDAO
    {
        [Test]
        public void TestLayChiTietDongCardReader()
        {
            myChiTietDongCardReaderDTO chiTietCardReader = myChiTietDongCardReaderDAO.LayChiTietDongCardReader(1);
            Assert.IsNotNull(chiTietCardReader);
            Assert.IsNotNull(chiTietCardReader.NhaSanXuat);
            Assert.IsNotNull(chiTietCardReader.ChiTietCongNgheCardReader);
        }
    }
}
