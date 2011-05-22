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
    class myTestDoTuoiDAO
    {
        [Test]
        public void LayDanhSachDoTuoiTest()
        {
            List<DOTUOI> DanhSachDoTuoi = myDoTuoiDAO.LayDoTuoi();
            Assert.IsNotNull(DanhSachDoTuoi);
        }
    }
}
