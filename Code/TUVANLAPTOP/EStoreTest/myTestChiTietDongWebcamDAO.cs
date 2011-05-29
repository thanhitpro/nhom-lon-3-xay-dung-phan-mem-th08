using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using EStoreDAO;
using EStoreDTO;

namespace EStoreTest
{
    [TestFixture]
    class myTestChiTietDongWebcamDAO
    {
        [Test]
        public void TestLayChiTietDongWebcam()
        {
            myChiTietDongWebcamDTO dongWebcam = myChiTietDongWebcamDAO.LayChiTietDongWebcam(1);
            Assert.IsNotNull(dongWebcam);
            Assert.AreEqual("Colorvis 2005", dongWebcam.STenDongWebCam);
            Assert.AreEqual(1, dongWebcam.FDoPhanGiai);
        }
    }
}
