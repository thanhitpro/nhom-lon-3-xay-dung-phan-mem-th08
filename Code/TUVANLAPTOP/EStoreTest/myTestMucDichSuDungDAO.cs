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
    class myTestMucDichSuDungDAO
    {
        [Test]
        public void LayDanhSachMucDichSuDungTest()
        {
            List<MUCDICHSUDUNG> DSMucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung();
            Assert.IsNotNull(DSMucDichSuDung);
        }

        [Test]
        public void LayMucDichSuDungTest()
        {
            MUCDICHSUDUNG MucDichSuDung = myMucDichSuDungDAO.LayMucDichSuDung(1);
            Assert.IsNotNull(MucDichSuDung);
        }

    }
}
