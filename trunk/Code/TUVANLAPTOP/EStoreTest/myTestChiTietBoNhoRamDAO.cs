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
    public class myTestChiTietBoNhoRamDAO
    {
        [Test]
        public void TestLayChiTietBoNhoRam()
        {
            Assert.IsNotNull(myChiTietBoNhoRamDAO.LayChiTietBoNhoRam());
        }

        [Test]
        public void TestThemBoNhoRAM()
        {
            myChiTietBoNhoRamDTO bnR = new myChiTietBoNhoRamDTO();
            bnR.FHeSo = (float)1.0;
            bnR.STenChiTietBoNhoRam = "4G";

            Assert.AreEqual(true, myChiTietBoNhoRamDAO.ThemBoNhoRAM(bnR));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETBONHORAMs.Max(it => it.MaChiTietBoNhoRAM);

            m_eStoreDataContext.CHITIETBONHORAMs.DeleteOnSubmit(m_eStoreDataContext.CHITIETBONHORAMs.Single(it => it.MaChiTietBoNhoRAM == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
