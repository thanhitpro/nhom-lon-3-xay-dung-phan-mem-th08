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
    class myTestNgheNghiepBUS
    {
        [Test]
        public void LayDanhSachNgheNghiepTest()
        {
            myNgheNghiepBUS NgheNghiepBUS = new myNgheNghiepBUS();
            List<NGHENGHIEP> DanhSachNgheNghiep = NgheNghiepBUS.LayNgheNghiep();
            Assert.IsNotNull(DanhSachNgheNghiep);
        }
    }
}
