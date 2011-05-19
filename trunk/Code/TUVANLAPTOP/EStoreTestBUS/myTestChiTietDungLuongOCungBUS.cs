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
    
    class myTestChiTietDungLuongOCungBUS
    {
        [Test]
        public void TestLayDanhSachOCung()
        {
            List<myChiTietDungLuongOCungDTO> listDungLuongOCung = myChiTietDungLuongOCungBUS.LayChiTietDungLuongOCung();
            Assert.IsNotNull(listDungLuongOCung);
            Assert.LessOrEqual(1, listDungLuongOCung.Count);
        }

        [Test]
        public void TestThemOCungMoi()
        {
            myChiTietDungLuongOCungDTO dlOCung = new myChiTietDungLuongOCungDTO();
            dlOCung.STenChiTietDungLuongOCung = "10TB ";
            dlOCung.FHeSo = (float)1.0;

            Assert.AreEqual(true, myChiTietDungLuongOCungBUS.ThemDungLuongOCung(dlOCung));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.Max(it => it.MaChiTietDungLuongOCung);
            CHITIETDUNGLUONGOCUNG chiTietDungLuongOCung = m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.Single(it => it.MaChiTietDungLuongOCung == maMax);
            m_eStoreDataContext.CHITIETDUNGLUONGOCUNGs.DeleteOnSubmit(chiTietDungLuongOCung);
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
