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
    class myTestTinhThanhDAO
    {
        [Test]
        public void LayDanhSachTinhThanh()
        {
            List<TINHTHANH> DanhSachTinhThanh = myTinhThanhDAO.LayTinhThanh();
            Assert.IsNotNull(DanhSachTinhThanh);
        }
    }
}
