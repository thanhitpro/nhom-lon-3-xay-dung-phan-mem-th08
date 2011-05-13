using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EStoreDTO;
using NUnit.Framework;
using EStoreDAO;

namespace EStoreTest
{
    [TestFixture]
    public class myTestChiTietCongNgheRamDAO
    {
        [Test]
        public void TestLayChiTietCongNgheRam()
        {
            Assert.IsNotNull(myChiTietCongNgheRamDAO.LayChiTietCongNgheRam());
        }

        [Test]
        public void TestThemCongNgheRAM()
        {
            myChiTietCongNgheRamDTO cnRAM = new myChiTietCongNgheRamDTO();
            cnRAM.FHeSo = (float)1.0;
            cnRAM.STenCongNgheRam = "DDR8";

            Assert.AreEqual(true, myChiTietCongNgheRamDAO.ThemCongNgheRAM(cnRAM));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETCONGNGHERAMs.Max(it => it.MaChiTietCongNgheRAM);

            m_eStoreDataContext.CHITIETCONGNGHERAMs.DeleteOnSubmit(m_eStoreDataContext.CHITIETCONGNGHERAMs.Single(it => it.MaChiTietCongNgheRAM == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
