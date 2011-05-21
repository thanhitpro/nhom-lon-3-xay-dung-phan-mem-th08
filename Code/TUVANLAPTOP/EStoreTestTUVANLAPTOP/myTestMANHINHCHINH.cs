using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;
using TUVANLAPTOP;
using System.Xml;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using EStoreBUS;
using EStoreDAO;
using EStoreDTO;
namespace EStoreTestTUVANLAPTOP
{
    [TestFixture]
    class myTestMANHINHCHINH
    {
        MANHINHCHINH manhinh = new MANHINHCHINH();
        [Test]
        public void TestSapXep()
        {
            TUVANLAPTOP.MANHINHCHINH.MyStruct myStruct1 = new MANHINHCHINH.MyStruct();
            myStruct1.gt = 0;
            myStruct1.id = 0;
            TUVANLAPTOP.MANHINHCHINH.MyStruct myStruct2 = new MANHINHCHINH.MyStruct();
            myStruct2.gt = 1;
            myStruct2.id = 1;
            TUVANLAPTOP.MANHINHCHINH.MyStruct myStruct3 = new MANHINHCHINH.MyStruct();
            myStruct3.gt = 2;
            myStruct3.id = 2;
            List<TUVANLAPTOP.MANHINHCHINH.MyStruct> listTest = new List<MANHINHCHINH.MyStruct>();
            listTest.Add(myStruct2);
            listTest.Add(myStruct1);
            listTest.Add(myStruct3);
            listTest = manhinh.SapXep(listTest);
            List<TUVANLAPTOP.MANHINHCHINH.MyStruct> listResult = new List<MANHINHCHINH.MyStruct>();
            listTest.Add(myStruct1);
            listTest.Add(myStruct2);
            listTest.Add(myStruct3);
            Assert.AreEqual(listResult, listTest);
        }

        [Test]
        public void KhoiTaoKhachHang()
        {
            int IDNgheNghiep = 1;
            int IDDoTuoi = 1;
            int IDTinhThanh = 1; 
            int IDMucDich=1;
            KHACHHANG khach = new KHACHHANG();
            khach.MaNgheNghiep = 1;
            khach.MaDoTuoi = 1;
            khach.MaTinhThanh = 1;
            khach.MaMucDichSuDung = 1;

            KHACHHANG khackKetQua = manhinh.KhoiTaoKhachHang(IDNgheNghiep, IDDoTuoi, IDTinhThanh, IDMucDich);
            Assert.AreEqual(khach, khackKetQua);
        }

    }
}
