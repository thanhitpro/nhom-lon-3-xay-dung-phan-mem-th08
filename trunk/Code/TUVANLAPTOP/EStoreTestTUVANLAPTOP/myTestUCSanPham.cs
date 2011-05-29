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
        public void TestCheckExistImagePath()
        {
            UC_SANPHAM userControlSanPham = new UC_SANPHAM();
            string imagePath = @"E:\Studying\Projects\TUVANLAPTOP\EStoreTestTUVANLAPTOP\bin\Release\1.png";
            Assert.AreEqual(true,userControlSanPham.CheckExistImagePath(imagePath));
        }

        [Test]
        public void TestReduceString()
        {
            UC_SANPHAM userControlSanPham = new UC_SANPHAM();
            string strReduced = "Nhóm nhỏ 24 - Nhóm lớn 3 - FIT08";
            Assert.AreEqual("Nhóm nhỏ 24 - Nhóm lớn 3 ...",userControlSanPham.ReduceLengthString(strReduced));
        }
    }
}
