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
    class myTestChiTietHeDieuHanhDAO
    {
        [Test]
        public void TestLayChiTietHDH()
        {
            myChiTietHeDieuHanhDTO heDieuHanh = myChiTietHeDieuHanhDAO.LayChiTietHDH(1);
            Assert.IsNotNull(heDieuHanh);
            Assert.AreEqual("Win 7 Home Premium", heDieuHanh.STenHeDieuHanh.Trim());
        }

        [Test]
        public void TestLayDSHeDieuHanh()
        {
            List<myChiTietHeDieuHanhDTO> dsHDH = myChiTietHeDieuHanhDAO.LayDSHeDieuHanh();
            Assert.IsNotNull(dsHDH);
            Assert.Less(0, dsHDH.Count);
        }

        [Test]
        public void TestThemHeDieuHanh()
        {
            myChiTietHeDieuHanhDTO heDieuHanh = new myChiTietHeDieuHanhDTO();
            heDieuHanh.STenHeDieuHanh = "Windows 8";
            heDieuHanh.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietHeDieuHanhDAO.ThemHDH(heDieuHanh));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETHEDIEUHANHs.Max(it => it.MaChiTietHeDieuHanh);
            m_eStoreDataContext.CHITIETHEDIEUHANHs.DeleteOnSubmit(m_eStoreDataContext.CHITIETHEDIEUHANHs.Single(it => it.MaChiTietHeDieuHanh == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
