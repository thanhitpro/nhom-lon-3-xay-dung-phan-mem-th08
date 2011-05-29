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
    class MyTestChiTietDongCardDoHoaBUS
    {
        [Test]
        public void TestLayChiTietDongCardDoHoa()
        {
            MyChiTietDongCardDoHoaBUS chiTietDongCardDoHoaBUS = new MyChiTietDongCardDoHoaBUS();
            List<myChiTietDongCardDoHoaDTO> ListChiTietDongCardDoHoaDTO = chiTietDongCardDoHoaBUS.LayChiTietDongCardDoHoa();
            Assert.IsNotNull(ListChiTietDongCardDoHoaDTO);
            Assert.LessOrEqual(2, ListChiTietDongCardDoHoaDTO.Count); ;
        }
    }
}
