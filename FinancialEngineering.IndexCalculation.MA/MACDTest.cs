using FinancialEngineering.IndexCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinancialEngineering.Test.Common;
using System.Linq;

namespace FinancialEngineering.IndexCalculation.Test
{
    
    
    /// <summary>
    ///This is a test class for MACDTest and is intended
    ///to contain all MACDTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MACDTest
    {


        private TestContext testContextInstance;
        private static double[] sampleData;

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
            sampleData = new SampleDataGenerator().GetStockPrice("002094", 36, new DateTime(2012, 3, 29));
          
        }
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
        ///A test for MACD
        ///</summary>
        [TestMethod()]
        public void MACDTest1()
        {
            MACD target = new MACD(3,5,2); // TODO: Initialize to an appropriate value
            target.AddRange(new double[7] { 1, 2, 3, 4, 5, 6, 7 });
            double actual;
            actual = target.DIF;
            Assert.AreNotEqual(0, actual);
        }
        [TestMethod()]
        public void MACDTest_With_002994_20120329()
        {
            MACD target = new MACD();
            target.AddRange(sampleData.Take(34));
            Assert.AreEqual(0.15, Math.Round(target.DIF, 2));
            Assert.AreEqual(0.20, Math.Round(target.DEA, 2));
            Assert.AreEqual(-0.10, Math.Round(target.Value, 2));

        }
    }
}
