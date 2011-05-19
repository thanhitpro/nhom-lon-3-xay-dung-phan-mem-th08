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
    public class myTestChiTietKichThuocManHinhBUS
    {
        [Test]
        public void TestLayDSKichThuocManHinh()
        {
            //myChiTietKichThuocManHinhBUS chiTietKichThuocManHinhBUS = new myChiTietKichThuocManHinhBUS();
            List<myChiTietKichThuocManHinhDTO> listKichThuocManHinhDTO = myChiTietKichThuocManHinhBUS.LayDSKichThuocManHinh();

            Assert.IsNotNull(listKichThuocManHinhDTO);
            Assert.LessOrEqual(1, listKichThuocManHinhDTO.Count);
        }

        [Test]
        public void TestThemMoiKichThuocManHinh()
        {
            myChiTietKichThuocManHinhDTO kichThuoc = new myChiTietKichThuocManHinhDTO();
            kichThuoc.STenChiTietKichThuocManHinh = "32 inches";
            kichThuoc.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietKichThuocManHinhBUS.ThemMoiKichThuocMH(kichThuoc));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.Max(it => it.MaChiTietKichThuocManHinh);
            CHITIETKICHTHUOCMANHINH chiTietKichThuocManHinh = m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.Single(it => it.MaChiTietKichThuocManHinh == maMax);
            m_eStoreDataContext.CHITIETKICHTHUOCMANHINHs.DeleteOnSubmit(chiTietKichThuocManHinh);
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
