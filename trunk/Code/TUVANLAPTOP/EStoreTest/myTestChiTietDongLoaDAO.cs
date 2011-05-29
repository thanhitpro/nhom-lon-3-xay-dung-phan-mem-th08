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
    public class myTestChiTietDongLoaDAO
    {
        [Test]
        public void TestLayChiTietDongLoa()
        {
            myChiTietDongLoaDTO chiTietDongLoa = myChiTietDongLoaDAO.LayChiTietDongLoa(1);
            Assert.IsNotNull(chiTietDongLoa);
            Assert.AreEqual("Creative", chiTietDongLoa.STenDongLoa);
            Assert.AreEqual(true, (chiTietDongLoa.BCoMicro == 1));
        }
    }
}
