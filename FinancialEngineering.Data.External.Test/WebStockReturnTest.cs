using FinancialEngineering.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinancialEngineering.Model;
using System.Collections.Generic;

namespace FinancialEngineering.Data.External.Test
{
    /// <summary>
    ///This is a test class for WebStockReturnTest and is intended
    ///to contain all WebStockReturnTest Unit Tests
    ///</summary>
    [TestClass()]
    public class WebStockReturnTest
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
        ///A test for GetStockReturn
        ///</summary>
        [TestMethod()]
        public void GetStockReturnTest()
        {
            WebStockReturn target = new WebStockReturn(); // TODO: Initialize to an appropriate value
            string secuCodeList = "000002,000004"; // TODO: Initialize to an appropriate value
            DateTime startDate = new DateTime(2012,3,11); // TODO: Initialize to an appropriate value
            DateTime endDate = new DateTime(2012, 3, 12); // TODO: Initialize to an appropriate value
    
            List<StockReturn> actual;
            actual = target.GetStockReturn(secuCodeList, startDate, endDate);
            Assert.AreEqual(2, actual.Count);
            Assert.IsTrue(actual.Exists(s => s.SecuCode == "000002"));
          
        }
    }
}
