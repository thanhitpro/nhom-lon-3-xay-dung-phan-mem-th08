using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreDAO;

namespace EStoreTest
{

    public class myTestChiTietDongCardMangDAO
    {
        [Test]
        public void TestLayChiTietDongCardMang()
        {
            Assert.IsNotNull(myChiTietDongCardMangDAO.LayChiTietDongCardMang(1));

        }
    }
}
