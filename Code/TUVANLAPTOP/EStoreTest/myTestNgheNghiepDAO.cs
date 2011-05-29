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
    class myTestNgheNghiepDAO
    {
        [Test]
        public void LayDanhSachNgheNghiepTest()
        {
            List<NGHENGHIEP> DanhSachNgheNghiep = myNgheNghiepDAO.LayNgheNghiep();
            Assert.IsNotNull(DanhSachNgheNghiep);
        }

        public void LayNgheNghiepTest()
        {
            NGHENGHIEP NgheNghiep = myNgheNghiepDAO.LayNgheNghiep(1);
            Assert.IsNotNull(NgheNghiep);
        }
    }
}
