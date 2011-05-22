using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreDAO;
using EStoreBUS;

namespace EStoreTestBUS
{
    [TestFixture]
    class myTestDoTuoiBUS
    {
        [Test]
        public void LayDanhSachDoTuoiTest()
        {
            myDoTuoiBUS DoTuoi = new myDoTuoiBUS();
            List<DOTUOI> DanhSachDoTuoi = DoTuoi.LayDoTuoi();
            Assert.IsNotNull(DanhSachDoTuoi);
        }
    }
}
