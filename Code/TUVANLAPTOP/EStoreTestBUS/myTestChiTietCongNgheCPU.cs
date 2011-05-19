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
    public class myTestChiTietCongNgheCPU
    {
        [Test]
        public void TestLayDSCongNgheCPU()
        {
            List<myChiTietCongNgheCPUDTO> listChiTietCongNgheCPU = myChiTietCongNgheCPUBUS.LayDSCongNgheCPU();
            Assert.IsNotNull(listChiTietCongNgheCPU);
            Assert.LessOrEqual(4, listChiTietCongNgheCPU.Count);
        }

        [Test]
        public void TestThemCongNgheCPU()
        {
            myChiTietCongNgheCPUDTO chiTietCongNgheCPU = new myChiTietCongNgheCPUDTO();
            chiTietCongNgheCPU.FHeSo = (float)1.0;
            chiTietCongNgheCPU.STenChiTietCongNgheCPU = "Core dual";

            Assert.Less(0, myChiTietCongNgheCPUBUS.ThemCongNgheCPU(chiTietCongNgheCPU));
            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETCONGNGHECPUs.Max(it => it.MaChiTietCongNgheCPU);
            m_eStoreDataContext.CHITIETCONGNGHECPUs.DeleteOnSubmit(m_eStoreDataContext.CHITIETCONGNGHECPUs.Single(it => it.MaChiTietCongNgheCPU == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
