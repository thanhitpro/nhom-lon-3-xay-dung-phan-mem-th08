using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreDAO;

namespace EStoreTest
{
    [TestFixture]
    class myTestChiTietVongQuayOCungDAO
    {
        [Test]
        public void TestLayDSVongQuayOCung()
        {
            List<myChiTietVongQuayOCungDTO> dsVongQuay = myChiTietVongQuayOCungDAO.LayDSVongQuayOCung();
            Assert.IsNotNull(dsVongQuay);
            Assert.Less(0, dsVongQuay.Count);
        }

        [Test]
        public void TestThemVongQuay()
        {
            myChiTietVongQuayOCungDTO vongQuay = new myChiTietVongQuayOCungDTO();
            vongQuay.STenChiTietVongQuayOCung = "Vòng quay  5400rpm";
            vongQuay.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietVongQuayOCungDAO.ThemVongQuay(vongQuay));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.Max(it => it.MaChiTietVongQuayOCung);
            m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.DeleteOnSubmit(m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.Single(it => it.MaChiTietVongQuayOCung == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }    
}
