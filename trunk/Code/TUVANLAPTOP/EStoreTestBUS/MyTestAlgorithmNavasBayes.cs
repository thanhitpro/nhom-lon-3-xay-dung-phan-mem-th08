using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using NUnit.Framework;
using EStoreDTO;
using EStoreBUS;
using EStoreDAO;

namespace EStoreTestBUS
{
    [TestFixture]
    class MyTestAlgorithmNavasBayes
    {
        [Test]
        public void LoadFileXMLTest()
        {
            AlgorithmNavasBayes NavasBayes=new AlgorithmNavasBayes();
            XmlDocument xmlDocument = NavasBayes.LoadFileXML("ResultAnalyseData.xml");
            Assert.NotNull(xmlDocument);
        }

        [Test]
        public void SaveFileXMLTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            XmlDocument xmlDocument=NavasBayes.LoadFileXML("ResultAnalyseData.xml");
            bool Actual = NavasBayes.SaveFileXML(xmlDocument,"ResultAnalyseData.xml");
            Assert.IsTrue(Actual);
        }

        [Test]
        public void TinhTyLeTheoNgheNghiepTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            List<float> TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoNgheNghiep(DanhSachGiaoDich);
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachNgheNghiep.Count; ++index)
                TyLeGiaoDich_Expect.Add(0);
            Assert.AreSame(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoMucDichSuDungTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            List<float> TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoMucDichSuDung(DanhSachGiaoDich);
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachMucDichSuDung.Count; ++index)
                TyLeGiaoDich_Expect.Add(0);
            Assert.AreSame(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoDoTuoiTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            List<float> TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoDoTuoi(DanhSachGiaoDich);
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachDoTuoi.Count; ++index)
                TyLeGiaoDich_Expect.Add(0);
            Assert.AreSame(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoTinhThanhTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            List<float> TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoTinhThanh(DanhSachGiaoDich);
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < NavasBayes.DanhSachTinhThanh.Count; ++index)
                TyLeGiaoDich_Expect.Add(0);
            Assert.AreSame(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void TinhTyLeTheoGioiTinhTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<GIAODICH> DanhSachGiaoDich = new List<GIAODICH>();
            List<float> TyLeGiaoDich_Actual = NavasBayes.TinhTyLeTheoGioiTinh(DanhSachGiaoDich);
            List<float> TyLeGiaoDich_Expect = new List<float>();
            for (int index = 0; index < 2; ++index)
                TyLeGiaoDich_Expect.Add(0);
            Assert.AreSame(TyLeGiaoDich_Expect, TyLeGiaoDich_Actual);
        }

        [Test]
        public void ThuatToanNaiveBayes()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<EStoreBUS.MyStruct> listSanPham = null;
            List<EStoreBUS.MyStruct> listSanPham_Test = new List<MyStruct>();
            listSanPham = NavasBayes.ThuatToanNaiveBayes(1, 0, 4, 1, 1, 4);
            Assert.AreEqual(listSanPham, listSanPham_Test);
        }

        [Test]
        public void KiemTraHopLe()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            List<EStoreBUS.MyStruct> listSanPham = new List<MyStruct>();
            EStoreBUS.MyStruct myStruct1 = new MyStruct();
            myStruct1.gt = 2.2424;
            myStruct1.id = 3;
            listSanPham.Add(myStruct1);
            int IDMucGia = 0;
            Assert.AreEqual(listSanPham, NavasBayes.KiemTraHopLe(listSanPham, IDMucGia));
        }
    }
}
