using EStoreDAO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EStoreDTO;
using System.Collections.Generic;

namespace TestEStoreProject
{
    
    
    /// <summary>
    ///This is a test class for myChiTietDongLaptopDAOTest and is intended
    ///to contain all myChiTietDongLaptopDAOTest Unit Tests
    ///</summary>
    [TestClass()]
    public class myChiTietDongLaptopDAOTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for LayChiTietDongLaptopMoiNhat
        ///</summary>
        [TestMethod()]
        public void LayChiTietDongLaptopMoiNhatTest()
        {
            myChiTietDongLaptopDTO donglaptop = new myChiTietDongLaptopDTO() ; // TODO: Initialize to an appropriate value
            donglaptop = myChiTietDongLaptopDAO.LayChiTietDongLaptop(12);
            myChiTietDongLaptopDTO lt1 = new myChiTietDongLaptopDTO();
            lt1 = myChiTietDongLaptopDAO.LayChiTietDongLaptop(13);
            myChiTietDongLaptopDTO lt2 = new myChiTietDongLaptopDTO();
            lt2 = myChiTietDongLaptopDAO.LayChiTietDongLaptop(15);
            List<myChiTietDongLaptopDTO> expected = new List<myChiTietDongLaptopDTO>() ; // TODO: Initialize to an appropriate value
            expected.Add(lt1);
            expected.Add(lt2);
            List<myChiTietDongLaptopDTO> actual = new List<myChiTietDongLaptopDTO>();
            actual = myChiTietDongLaptopDAO.LayChiTietDongLaptopMoiNhat(donglaptop);
            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0].IMaDongLaptop, actual[0].IMaDongLaptop);
            Assert.AreEqual(expected[1].IMaDongLaptop, actual[1].IMaDongLaptop);
        }
    }
}
