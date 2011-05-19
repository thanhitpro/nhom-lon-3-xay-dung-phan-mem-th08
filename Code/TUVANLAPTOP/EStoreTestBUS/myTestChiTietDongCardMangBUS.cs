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
    class myTestChiTietDongCardMangBUS
    {
        [Test]
        public void TestLayDSCardMang()
        {
            myChiTietDongCardMangBUS chiTietCardMangBUS = new myChiTietDongCardMangBUS();
            List<myChiTietDongCardMangDTO> listChiTietDongCardMangDTO = chiTietCardMangBUS.LayChiTietDongCardMang();
            
            Assert.IsNotNull(listChiTietDongCardMangDTO);
            Assert.LessOrEqual(2, listChiTietDongCardMangDTO.Count);
        }
    }
}
