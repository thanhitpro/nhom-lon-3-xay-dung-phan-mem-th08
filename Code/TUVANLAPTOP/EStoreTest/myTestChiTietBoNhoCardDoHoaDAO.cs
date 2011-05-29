﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDTO;
using EStoreDAO;

namespace EStoreTest
{
    [TestFixture]
    public class myTestChiTietBoNhoCardDoHoaDAO
    {
        [Test]
        public void TestThem()
        {
            myChiTietBoNhoCardDoHoaDTO bn = new myChiTietBoNhoCardDoHoaDTO();
            bn.FHeSo = (float)1.0;
            bn.STenChiTietCardDoHoa = "Lớn hơn 2GB";

            myChiTietBoNhoCardDoHoaDAO myChiTietBoNhoCardDoHoaDAO = new myChiTietBoNhoCardDoHoaDAO();
            Assert.AreEqual(true, myChiTietBoNhoCardDoHoaDAO.ThemBoNhoCardMH(bn));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.Max(it => it.MaChiTietBoNhoCardDoHoa);
            CHITIETBONHOCARDDOHOA chiTietBoNhoCardDoHoa = m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.Single(it => it.MaChiTietBoNhoCardDoHoa == maMax);
            m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.DeleteOnSubmit(chiTietBoNhoCardDoHoa);
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
