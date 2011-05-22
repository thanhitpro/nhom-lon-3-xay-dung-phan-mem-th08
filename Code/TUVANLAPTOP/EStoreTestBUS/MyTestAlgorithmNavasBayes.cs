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
    }
}
