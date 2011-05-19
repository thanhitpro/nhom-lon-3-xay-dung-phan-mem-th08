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
    class myTestChiTietDongCPUBUS
    {
        [Test]
        public void TestLayDSDongCPU()
        {
            myChiTietDongCPUBUS chiTietDongCPUBUS = new myChiTietDongCPUBUS();
            List<myChiTietDongCPUDTO> listChiTietDongCPUBUS = chiTietDongCPUBUS.LayChiTietDongCPU();

            Assert.IsNotNull(listChiTietDongCPUBUS);
            Assert.LessOrEqual(1, listChiTietDongCPUBUS.Count);
        }
    }
}
