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
    class MyTestDoTuoiBUS
    {
        [Test]
        public void LayDanhSachDoTuoiTest()
        {
            MyDoTuoiBUS DoTuoi = new MyDoTuoiBUS();
            List<DOTUOI> DanhSachDoTuoi = DoTuoi.LayDoTuoi();
            Assert.IsNotNull(DanhSachDoTuoi);
        }
    }
}
