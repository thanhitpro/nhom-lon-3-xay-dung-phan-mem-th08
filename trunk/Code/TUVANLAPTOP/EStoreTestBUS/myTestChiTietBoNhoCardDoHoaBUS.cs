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
    public class myTestChiTietBoNhoCardDoHoaBUS
    {
        [Test]
        public void TestLayChiTietBoNhoCardMH()
        {
            List<myChiTietBoNhoCardDoHoaDTO> listBoNhoCardDoHoaDTO = myChiTietBoNhoCardDoHoaBUS.LayDanhSachChiTietBoNhoCardMH();
            Assert.IsNotNull(listBoNhoCardDoHoaDTO);
            Assert.LessOrEqual(3, listBoNhoCardDoHoaDTO.Count);
        }

        [Test]
        public void TestThemBoNhoCardMH()
        {
            myChiTietBoNhoCardDoHoaDTO bn = new myChiTietBoNhoCardDoHoaDTO();
            bn.FHeSo = (float)1.0;
            bn.STenChiTietCardDoHoa = "Lớn hơn 2GB";

            Assert.AreEqual(true,myChiTietBoNhoCardDoHoaBUS.ThemBoNhoCardMH(bn));

            DataClasses1DataContext m_eStoreDataContext = new DataClasses1DataContext();
            int maMax = m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.Max(it => it.MaChiTietBoNhoCardDoHoa);
            CHITIETBONHOCARDDOHOA chiTietBoNhoCardDoHoa = m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.Single(it => it.MaChiTietBoNhoCardDoHoa == maMax);
            m_eStoreDataContext.CHITIETBONHOCARDDOHOAs.DeleteOnSubmit(chiTietBoNhoCardDoHoa);
            m_eStoreDataContext.SubmitChanges();
        }
    }
}
