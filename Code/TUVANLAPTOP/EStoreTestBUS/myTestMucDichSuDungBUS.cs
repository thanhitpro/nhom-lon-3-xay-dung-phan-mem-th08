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
    class MyTestMucDichSuDungBUS
    {
        [Test]
        public void LayDanhSachMucDichSuDungTest()
        {
            MyMucDichSuDungBUS MucDichSuDungBUS = new MyMucDichSuDungBUS();
            List<MUCDICHSUDUNG> DSMucDichSuDung = MucDichSuDungBUS.LayMucDichSuDung();
            Assert.IsNotNull(DSMucDichSuDung);
        }
    }
}
