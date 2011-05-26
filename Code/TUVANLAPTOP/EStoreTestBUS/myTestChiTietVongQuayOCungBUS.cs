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
    class MyTestChiTietVongQuayOCungBUS
    {
        [Test]
        public void TestLayDanhSachChiTietVongQuayOCung()
        {
            List<myChiTietVongQuayOCungDTO> listVongXoay = myChiTietVongQuayOCungDAO.LayDSVongQuayOCung();
            Assert.IsNotNull(listVongXoay);
            Assert.LessOrEqual(1, listVongXoay.Count);
        }

        [Test]
        public void TestThemMoiChiTietVongQuayOCung()
        {
            myChiTietVongQuayOCungDTO vongQuay = new myChiTietVongQuayOCungDTO();
            vongQuay.STenChiTietVongQuayOCung = "Vòng quay  5400rpm";
            vongQuay.FHeSo = (float)1.0;

            Assert.AreEqual(true, MyChiTietVongQuayOCungBUS.ThemVongQuayOCung(vongQuay));
            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.Max(it => it.MaChiTietVongQuayOCung);
            CHITIETVONGQUAYOCUNG chiTietVongXoay = m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.Single(it => it.MaChiTietVongQuayOCung == maMax);
            m_eStoreDataContext.CHITIETVONGQUAYOCUNGs.DeleteOnSubmit(chiTietVongXoay);
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
