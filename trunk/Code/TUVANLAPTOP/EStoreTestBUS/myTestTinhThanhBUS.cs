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
    class myTestTinhThanhBUS
    {
        [Test]
        public void LayDanhSachTinhThanh()
        {
            myTinhThanhBUS TinhThanhBUS = new myTinhThanhBUS();
            List<TINHTHANH> DanhSachTinhThanh = TinhThanhBUS.LayTinhThanh();
            Assert.IsNotNull(DanhSachTinhThanh);
        }
    }
}
