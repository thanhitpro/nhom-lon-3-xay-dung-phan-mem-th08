using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TUVANLAPTOP;
using NUnit.Framework;

namespace EStoreTestTUVANLAPTOP
{
    [TestFixture]
    class myTestUCSanPham
    {
        [Test]
        public void TestReduceString()
        {
            UC_SANPHAM userControlSanPham = new UC_SANPHAM();
            string strReduced = "Nhóm nhỏ 24 - Nhóm lớn 3 - FIT08";
            Assert.AreEqual("Nhóm nhỏ 24 - Nhóm lớn 3 ...",userControlSanPham.ReduceLengthString(strReduced));
        }
    }
}
