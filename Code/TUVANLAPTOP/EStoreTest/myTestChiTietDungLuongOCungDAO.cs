using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDAO;
using EStoreDTO;

namespace EStoreTest
{
    [TestFixture]
    class myTestChiTietDungLuongOCungDAO
    {
        [Test]
        public void TestLayDSDungLuongOCung()
        {
            List<myChiTietDungLuongOCungDTO> dsDungLuongOCung = myChiTietDungLuongOCungDAO.LayDSDungLuongOCung();

            Assert.IsNotNull(dsDungLuongOCung);
            Assert.Less(0, dsDungLuongOCung.Count);
        }

        [Test]
        public void TestThemDungLuongOCung()
        {
            myChiTietDungLuongOCungDTO dlOCung = new myChiTietDungLuongOCungDTO();
            dlOCung.STenChiTietDungLuongOCung = "10TB ";
            dlOCung.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietDungLuongOCungDAO.ThemDungLuongOCung(dlOCung));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.Max(it => it.MaChiTietDungLuongOCung);
            m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.DeleteOnSubmit(m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.Single(it => it.MaChiTietDungLuongOCung == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
