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
    class myTestChiTietKichThuocManHinhDAO
    {
        [Test]
        public void TestLayDSKichThuocManHinh()
        {
            List<myChiTietKichThuocManHinhDTO> dsKichThuoc = myChiTietKichThuocManHinhDAO.LayDSKichThuocManHinh();
            Assert.IsNotNull(dsKichThuoc);
            Assert.Less(0, dsKichThuoc.Count);
        }

        [Test]
        public void TestThemKichThuocManHinh()
        {
            myChiTietKichThuocManHinhDTO kichThuoc = new myChiTietKichThuocManHinhDTO();
            kichThuoc.STenChiTietKichThuocManHinh = "32 inches";
            kichThuoc.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietKichThuocManHinhDAO.ThemKichThuocManHinh(kichThuoc));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.Max(it => it.MaChiTietKichThuocManHinh);
            m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.DeleteOnSubmit(m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.Single(it => it.MaChiTietKichThuocManHinh == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
