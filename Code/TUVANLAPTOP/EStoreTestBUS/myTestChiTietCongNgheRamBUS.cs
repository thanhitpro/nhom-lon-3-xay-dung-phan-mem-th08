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
    class myTestChiTietCongNgheRamBUS
    {
        [Test]
        public void TestLayChiTietCongNgheRam()
        {
            List<myChiTietCongNgheRamDTO> listChiTietCongNgheRAMDTO = myChiTietCongNgheRamBUS.LayChiTietCongNgheRam();
            Assert.IsNotNull(listChiTietCongNgheRAMDTO);
            Assert.LessOrEqual(1, listChiTietCongNgheRAMDTO.Count);
        }

        [Test]
        public void TestThemCongNgheRAM()
        {
            myChiTietCongNgheRamDTO chiTietCongNgheRAM = new myChiTietCongNgheRamDTO();
            chiTietCongNgheRAM.FHeSo = (float)1.0;
            chiTietCongNgheRAM.STenCongNgheRam = "DDR8";

            Assert.AreEqual(true, myChiTietCongNgheRamBUS.ThemCongNgheRAM(chiTietCongNgheRAM));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETCONGNGHERAMs.Max(it => it.MaChiTietCongNgheRAM);
            m_eStoreDataContext.CHITIETCONGNGHERAMs.DeleteOnSubmit(m_eStoreDataContext.CHITIETCONGNGHERAMs.Single(it => it.MaChiTietCongNgheRAM == maMax));
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
