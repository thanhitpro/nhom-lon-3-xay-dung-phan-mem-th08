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
    class myTestMucDichSuDungBUS
    {
        [Test]
        public void LayDanhSachMucDichSuDungTest()
        {
            myMucDichSuDungBUS MucDichSuDungBUS = new myMucDichSuDungBUS();
            List<MUCDICHSUDUNG> DSMucDichSuDung = MucDichSuDungBUS.LayMucDichSuDung();
            Assert.IsNotNull(DSMucDichSuDung);
        }
    }
}
