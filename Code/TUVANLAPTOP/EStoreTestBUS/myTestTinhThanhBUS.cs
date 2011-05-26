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
    class MyTestTinhThanhBUS
    {
        [Test]
        public void LayDanhSachTinhThanh()
        {
            MyTinhThanhBUS TinhThanhBUS = new MyTinhThanhBUS();
            List<TINHTHANH> DanhSachTinhThanh = TinhThanhBUS.LayTinhThanh();
            Assert.IsNotNull(DanhSachTinhThanh);
        }
    }
}
