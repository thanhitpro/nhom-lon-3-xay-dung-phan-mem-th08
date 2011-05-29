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
    public class MyTestChiTietBoNhoRamBUS
    {
        [Test]
        public void TestLayChiTietBoNhoRam()
        {
            List<myChiTietBoNhoRamDTO> listChiTietBoNhoRAM = MyChiTietBoNhoRamBUS.LayChiTietBoNhoRam();
            Assert.IsNotNull(listChiTietBoNhoRAM);
            Assert.LessOrEqual(2, listChiTietBoNhoRAM.Count);
        }

        [Test]
        public void TestThemBoNhoRAM()
        {
            myChiTietBoNhoRamDTO chiTietBoNhoRamDTO = new myChiTietBoNhoRamDTO();
            chiTietBoNhoRamDTO.FHeSo = (float)1.0;
            chiTietBoNhoRamDTO.STenChiTietBoNhoRam = "4G";

            Assert.AreEqual(true, MyChiTietBoNhoRamBUS.ThemBoNhoRAM(chiTietBoNhoRamDTO));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETBONHORAMs.Max(it => it.MaChiTietBoNhoRAM);
            m_eStoreDataContext.CHITIETBONHORAMs.DeleteOnSubmit(m_eStoreDataContext.CHITIETBONHORAMs.Single(it => it.MaChiTietBoNhoRAM == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
