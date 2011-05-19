using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;

namespace EStoreTestBUS
{
    [TestFixture]
    class myTestChiTietDongCardReaderBUS
    {
        [Test]
        public void TestLayDSCardReader()
        {
            myChiTietDongCardReaderBUS chiTietDongCardReaderBUS = new myChiTietDongCardReaderBUS();
            List<myChiTietDongCardReaderDTO> ListChiTietDongCardReaderBUS = chiTietDongCardReaderBUS.LayChiTietDongCardReader();

            Assert.IsNotNull(ListChiTietDongCardReaderBUS);
            Assert.LessOrEqual(1, ListChiTietDongCardReaderBUS.Count);
        }
    }
}
