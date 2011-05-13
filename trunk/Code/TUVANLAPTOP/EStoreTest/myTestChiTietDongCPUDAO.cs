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
    public class myTestChiTietDongCPUDAO
    {
        [Test]
        public void TestLayChiTietDongCPU()
        {
            myChiTietDongCPUDTO chiTietDongCPU = myChiTietDongCPUDAO.LayChiTietDongCPU(1);

            Assert.IsNotNull(chiTietDongCPU);
            Assert.AreEqual("Intel Core i7-950 (3.06GHz)", chiTietDongCPU.STenDongCPU);
        }

        [Test]
        public void TestThemMoiDongCPU()
        {
            myChiTietDongCPUDTO chiTietDongCPU = new myChiTietDongCPUDTO();
            chiTietDongCPU.STenDongCPU = "Intel Core i5 2.6GHz (3MB)";
            chiTietDongCPU.NhaSanXuat = new myNhaSanXuatDTO("Intel");
            chiTietDongCPU.NhaSanXuat.IMaNhaSanXuat = 32;
            chiTietDongCPU.ChiTietCongNgheCPU = new myChiTietCongNgheCPUDTO();
            chiTietDongCPU.ChiTietCongNgheCPU.IMaChiTietCN = 3;

            Assert.AreEqual(true, myChiTietDongCPUDAO.ThemDongCPU(chiTietDongCPU));
            
            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();

            int maMax = m_eStoreDataContext.CHITIETDONGCPUs.Max(it => it.MaDongCPU);
            Assert.IsNotNull(myChiTietDongCPUDAO.LayChiTietDongCPU(maMax));

            m_eStoreDataContext.CHITIETDONGCPUs.DeleteOnSubmit(m_eStoreDataContext.CHITIETDONGCPUs.Single(it => it.MaDongCPU == maMax));
            m_eStoreDataContext.SubmitChanges();
        }

        [Test]
        public void TestKiemTraTonTaiDongCPU()
        {
            Assert.AreEqual(true,myChiTietDongCPUDAO.KiemTraTonTaiDongCPU("Intel Core i7-950 (3.06GHz)"));
            Assert.AreNotEqual(true, myChiTietDongCPUDAO.KiemTraTonTaiDongCPU("Intel Core i5 3.06GHz"));
        }
    }
}
