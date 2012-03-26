using System.Web.DataSets;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.DataSets.Model;

namespace System.Web.DataSets.Test
{
    
    
    /// <summary>
    ///This is a test class for DBStockQuoteDataTest and is intended
    ///to contain all DBStockQuoteDataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DBStockQuoteDataTest
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
            DBStockQuoteData target = new DBStockQuoteData(); // TODO: Initialize to an appropriate value
            string secuCode = string.Empty; // TODO: Initialize to an appropriate value
            int numRecord = 0; // TODO: Initialize to an appropriate value
            DateTime endDate = new DateTime(2011,01,20); // TODO: Initialize to an appropriate value
            StockPrice[] expected = null; // TODO: Initialize to an appropriate value
            StockPrice[] actual;
            actual = target.GetStockPrice("000001", 1, endDate);
            Assert.IsNotNull(actual);
        }

        /// <summary>
        ///A test for CalcReturn
        ///</summary>
        [TestMethod()]
        public void CalcReturnTest()
        {
            DBStockQuoteData target = new DBStockQuoteData(); // TODO: Initialize to an appropriate value
            List<string> secuCode = new List<string>{"000001"}; // TODO: Initialize to an appropriate value
            DateTime startTime = new DateTime(2011,1,3); // TODO: Initialize to an appropriate value
            DateTime endTime = new DateTime(2011,1,5); // TODO: Initialize to an appropriate value
         
            
         //   var actual = target.CalcReturn(secuCode, startTime, endTime);
         //   Assert.AreNotEqual(null, actual);
        //    Assert.IsTrue(actual.Exists(s=>s.SecuCode == "000001"));
        //    Assert.IsTrue(actual.Where(s=>s.SecuCode == "000001").First().Value != default(double));
           
        }
    }
}
