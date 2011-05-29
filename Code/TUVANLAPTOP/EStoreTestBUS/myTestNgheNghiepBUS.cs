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
    class MyTestNgheNghiepBUS
    {
        [Test]
        public void LayDanhSachNgheNghiepTest()
        {
            MyNgheNghiepBUS NgheNghiepBUS = new MyNgheNghiepBUS();
            List<NGHENGHIEP> DanhSachNgheNghiep = NgheNghiepBUS.LayNgheNghiep();
            Assert.IsNotNull(DanhSachNgheNghiep);
        }
    }
}
