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
    class myTestChiTietHeDieuHanhBUS
    {
        [Test]
        public void TestLayDSHeDieuHanh()
        {
            List<myChiTietHeDieuHanhDTO> listHeDieuHanh = myChiTietHeDieuHanhBUS.LayDSHeDieuHanh();
            Assert.IsNotNull(listHeDieuHanh);
            Assert.Less(0, listHeDieuHanh.Count);
        }

        [Test]
        public void TestThemHeDieuHanh()
        {
            myChiTietHeDieuHanhDTO chiTietHeDieuHanh = new myChiTietHeDieuHanhDTO();
            chiTietHeDieuHanh.STenHeDieuHanh = "Windows 8";
            chiTietHeDieuHanh.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietHeDieuHanhBUS.ThemMoiHDH(chiTietHeDieuHanh));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETHEDIEUHANHs.Max(it => it.MaChiTietHeDieuHanh);
            CHITIETHEDIEUHANH chiTietHDH = m_eStoreDataContext.CHITIETHEDIEUHANHs.Single(it => it.MaChiTietHeDieuHanh == maMax);
            m_eStoreDataContext.CHITIETHEDIEUHANHs.DeleteOnSubmit(chiTietHDH);
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
