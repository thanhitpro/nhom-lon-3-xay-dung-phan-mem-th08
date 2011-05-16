using EStoreBUS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestEStoreProject
{
    
    
    /// <summary>
    ///This is a test class for myChiTietDongLaptopBUSTest and is intended
    ///to contain all myChiTietDongLaptopBUSTest Unit Tests
    ///</summary>
    [TestClass()]
    public class myChiTietDongLaptopBUSTest
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
        ///A test for KiemTraSanPhamTonTai
        ///</summary>
        [TestMethod()]
        public void KiemTraSanPhamTonTaiTest()
        {
            int _iMaDongLaptop = 1; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = myChiTietDongLaptopBUS.KiemTraSanPhamTonTai(_iMaDongLaptop);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for KiemTraGiaTienHopLe
        ///</summary>
        [TestMethod()]
        public void KiemTraGiaTienHopLeTest()
        {
            int _iMaDongLaptop = 1; // TODO: Initialize to an appropriate value
            int _iMucGia = 2; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = myChiTietDongLaptopBUS.KiemTraGiaTienHopLe(_iMaDongLaptop, _iMucGia);
            Assert.AreEqual(expected, actual);
        }
    }
}
