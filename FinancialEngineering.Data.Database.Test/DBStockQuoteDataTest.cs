using FinancialEngineering.Data.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using FinancialEngineering.Model;
using System.Diagnostics;

namespace FinancialEngineering.Data.Database.Test
{
    
    
    /// <summary>
    ///This is a test class for DBStockQuoteDataTest and is intended
    ///to contain all DBStockQuoteDataTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DBStockQuoteDataTest
    {
        private DBStockQuoteData context;

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
        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {
           
        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            context = new DBStockQuoteData(); 

        }
        
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
        public void Test_All_Result_Fetch_When_secuCode_Set_Null()
        {
            string secuCode = null;
            var startDate = new DateTime(2011,1,7); // TODO: Initialize to an appropriate value
            var endDate = new DateTime(2011,1,10); // TODO: Initialize to an appropriate value
            StockPrice[] expected = null; // TODO: Initialize to an appropriate value
            StockPrice[] actual;
            actual = context.GetStockPrice(null, 60, endDate);

          
            var c = actual.Select(p=>p.InnerCode).Distinct().Count();
           
            Assert.IsTrue(c > 1000);  //股票市场有大于2300只股票
            
        }
        [TestMethod()]
        public void Test_When_secuCode_Set()
        {
            string secuCode = "000012";
            var startDate = new DateTime(2011, 1, 7); // TODO: Initialize to an appropriate value
            var endDate = new DateTime(2011, 1, 10); // TODO: Initialize to an appropriate value
            StockPrice[] expected = null; // TODO: Initialize to an appropriate value
            StockPrice[] actual;
            actual = context.GetStockPrice(secuCode, 60, endDate);


            var ss = actual.Aggregate<StockPrice, string>("", (s, p) =>
            {
                s += p.Close.ToString() + ",";
                return s;
            });

            var c = actual.Select(p => p.InnerCode).Distinct().Count() == 1;
            Assert.AreEqual(60,actual.Count());
            Assert.IsTrue(c);


        }

        [TestMethod()]
        public void Test_When_Start_Date_Not_Trading_Day()
        {
            string secuCode = null;
            var startDate = new DateTime(2011, 1, 7); // TODO: Initialize to an appropriate value
            var endDate = new DateTime(2011, 1, 9); // TODO: Initialize to an appropriate value
            StockPrice[] expected = null; // TODO: Initialize to an appropriate value
            StockPrice[] actual;
            actual = context.GetStockPrice(null, 60, endDate);

            Assert.IsTrue(actual == null || actual.Count() == 0);  //不是工作日则不选出
        }

    
 
        //private bool CheckDayIsConsecutive(StockPrice[] price)
        //{
        //    if (price == null || price.Length == 0) return false;
        //    DateTime d = price[0].Tradingday;
        //    int code = price[0].InnerCode;
          
        //    for (int i = 0; i < price.Length; i++)
        //    {
        //        if (price[i].InnerCode != code)
        //        {
        //            code = price[i].InnerCode;
        //            d = price[i].Tradingday;
                  
        //        }
                
        //        if (price[i].Tradingday != d)
        //        {
        //            return false;
        //        }
        //        d = d.AddDays(1);
        //    }
        //    return true;
        //}
    }
}
