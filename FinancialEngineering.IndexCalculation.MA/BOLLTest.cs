using FinancialEngineering.IndexCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinancialEngineering.IndexCalculation.Test
{
    
    
    /// <summary>
    ///This is a test class for BOLLTest and is intended
    ///to contain all BOLLTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BOLLTest
    {


        private TestContext testContextInstance;
        private static double[] sampleData;
        private static MA ma;

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
            // 000012 -截至到2011-1-10前60个交易日收盘价,包含1-10号
            sampleData = new double[] { 15.51, 15.86, 15.81, 16.05, 15.88, 17.02, 17.74, 16.9, 18.59, 18.87, 19.55
                , 19.18, 18.16, 19.98, 21.34, 21.35, 22.9, 22.43, 21.86
                , 20.31, 22.34, 21.19, 19.2, 20.62, 22.68, 23.02, 23.9, 23.98
                , 23.57, 23.32, 23.21, 22.1, 21.71, 21.6, 22.55, 21.77, 22.41, 22.47
                , 22.47, 22.29, 23.3, 23.14, 22.56, 22.36, 22.46, 21.94, 21.75, 22.52
                , 21.52, 21.29, 19.93, 18.66, 19.36, 19.05, 19.75
                , 20.03, 19.76, 19.34, 19.01, 18.25 };
            ma = new MA(60);
            ma.AddRange(sampleData);
            var s = ma.Value;
            
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
        ///A test for DN
        ///</summary>
        [TestMethod()]
        public void DNTest()
        {
            BOLL target = new BOLL(ma, 0.97);
            double actual;
            actual = target.DN;
            Assert.AreEqual(17.52, Math.Round(actual, 2));
        }

        /// <summary>
        ///A test for MB
        ///</summary>
        [TestMethod()]
        public void MBTest()
        {
            BOLL target = new BOLL(); // TODO: Initialize to an appropriate value
            double actual;
            actual = target.MB;
            Assert.Inconclusive("Verify the correctness of this test method.");
            
        }

        /// <summary>
        ///A test for UP
        ///</summary>
        [TestMethod()]
        public void UPTest()
        {
            BOLL target = new BOLL(); // TODO: Initialize to an appropriate value
            double actual;
            actual = target.UP;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
