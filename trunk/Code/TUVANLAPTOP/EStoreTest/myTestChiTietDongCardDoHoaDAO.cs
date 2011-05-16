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
    public class myTestChiTietDongCardDoHoaDAO
    {
        [Test]
        public void TestLayDSDongCardDoHoa()
        {
            Assert.IsNotNull(myChiTietDongCardDoHoaDAO.LayChiTietDongCardDoHoa(1));
            Assert.AreEqual("NDIVIA", myChiTietDongCardDoHoaDAO.LayChiTietDongCardDoHoa(1).STenDongCardDoHoa);
        }
    }
}
