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
            bool Actual = NavasBayes.LoadFileXML("ResultAnalyseData.xml");
            Assert.IsTrue(Actual);
        }

        [Test]
        public void SaveFileXMLTest()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            bool Actual = NavasBayes.SaveFileXML("ResultAnalyseData.xml");
            Assert.IsTrue(Actual);
        }

        [Test]
        public void TaoXMLNodeTest()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode NodeTest = xmlDocument.CreateElement("NGHE_NGHIEP");
            XmlAttribute xmlID = xmlDocument.CreateAttribute("ID");
            XmlAttribute xmlTyLeGiaoDich = xmlDocument.CreateAttribute("TyLeGiaoDich");
            XmlAttribute xmlTyLeKhongGiaoDich = xmlDocument.CreateAttribute("TyLeKhongGiaoDich");

            xmlID.Value = "1";
            xmlTyLeGiaoDich.Value = "10.01";
            xmlTyLeKhongGiaoDich.Value = "2.01";

            NodeTest.Attributes.Append(xmlID);
            NodeTest.Attributes.Append(xmlTyLeGiaoDich);
            NodeTest.Attributes.Append(xmlTyLeKhongGiaoDich);

            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            NavasBayes.Xmldocument = new XmlDocument();
            XmlNode NodeResult = NavasBayes.TaoXMLNode("NGHE_NGHIEP", 1, 10.01f, 2.01f);
            Assert.AreSame(NodeTest, NodeResult);
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
