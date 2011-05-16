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
    public class myTestChiTietCongNgheCPUDAO
    {
        [Test]
        public void TestLayDSCongNgheCPU()
        {
            Assert.IsNotNull(myChiTietCongNgheCPUDAO.LayDSCongNgheCPU());
        }

        [Test]
        public void TestThemCongNgheCPU()
        {
            myChiTietCongNgheCPUDTO cnCPU = new myChiTietCongNgheCPUDTO();
            cnCPU.FHeSo = (float)1.0;
            cnCPU.STenChiTietCongNgheCPU = "Core dual";

            Assert.Less(0, myChiTietCongNgheCPUDAO.ThemCongNgheCPU(cnCPU));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETCONGNGHECPUs.Max(it => it.MaChiTietCongNgheCPU);

            m_eStoreDataContext.CHITIETCONGNGHECPUs.DeleteOnSubmit(m_eStoreDataContext.CHITIETCONGNGHECPUs.Single(it => it.MaChiTietCongNgheCPU == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
