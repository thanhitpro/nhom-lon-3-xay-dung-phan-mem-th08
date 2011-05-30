using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreBUS;
using EStoreDAO;
using EStoreDTO;
using TUVANLAPTOP;
using NUnit.Framework;

namespace EStoreTestTUVANLAPTOP
{
    [TestFixture]
    public class myTestCAPNHATXOASANPHAM
    {
        CAPNHATXOASANPHAM myCapNhatXoaSanPham_test = new CAPNHATXOASANPHAM();

        [Test]
        public void LayDanhSachMaDongLaptop_Test()
        {
            List<int> danhSachMaDongLapTop = myCapNhatXoaSanPham_test.LayDanhSachMaDongLaptop();
            List<int> test = new List<int> { 1, 30};
            Assert.AreNotEqual(test, danhSachMaDongLapTop);
        }

        [Test]
        public void AssignValueToCheckBoxCell_Test()
        {
            Assert.AreEqual(true, myCapNhatXoaSanPham_test.AssignValueToCheckBoxCell(true));
        }

        [Test]
        public void AddDataIntoDataGridView_Test()
        {
            myChiTietDongLaptopDTO chiTietDongLapTop = MyChiTietDongLaptopBUS.LayChiTietDongLaptop(1);
            Assert.AreEqual(true, myCapNhatXoaSanPham_test.AddDataIntoDataGridView(chiTietDongLapTop));
        }

    }
}
