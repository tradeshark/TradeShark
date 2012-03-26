using FinancialEngineering.Data.External;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinancialEngineering.Model;

namespace FinancialEngineering.Data.External.Test
{
    
    
    /// <summary>
    ///This is a test class for WebStockQuoteDataTest and is intended
    ///to contain all WebStockQuoteDataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WebStockQuoteDataTest
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
        ///A test for GetStockPrice
        ///</summary>
        [TestMethod()]
        public void GetStockPriceTest()
        {
            WebStockQuoteData target = new WebStockQuoteData(); // TODO: Initialize to an appropriate value
            string secuCode = string.Empty; // TODO: Initialize to an appropriate value
            int numRecord = 0; // TODO: Initialize to an appropriate value
            DateTime endDate = new DateTime(); // TODO: Initialize to an appropriate value
            StockPrice[] expected = null; // TODO: Initialize to an appropriate value
            StockPrice[] actual;
            actual = target.GetStockPrice(secuCode, numRecord, endDate);
            Assert.AreNotEqual(expected, actual);
            
        }
    }
}
