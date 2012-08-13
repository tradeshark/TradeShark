using FinancialEngineering.IndexCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FinancialEngineering.IndexCalculation.Generic;
using FinancialEngineering.Test.Common;
using System.Linq;
namespace FinancialEngineering.IndexCalculation.Test
{
    
    
    /// <summary>
    ///This is a test class for EMATest and is intended
    ///to contain all EMATest Unit Tests
    ///</summary>
    [TestClass()]
    public class EMATest
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
            sampleData = new SampleDataGenerator().GetStockPrice("002094", 60, new DateTime(2012, 3, 29));
        }
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

        [TestMethod]
        public void ValueTest_002094_20120329()
        {
            EMA target = null; // TODO: Initialize to an appropriate value
            int initLength = 0;
            if (EMA.TryCreateInstance(26, 0.01, sampleData.Take(30).ToArray(), out target, out initLength))
            {
                target.AddSample(sampleData.Skip(30).Take(1).First());
                var actual = target.Value;
            }
            else
            {
                EMA.TryCreateInstance(26, 0.01, sampleData.Take(initLength).ToArray(), out target, out initLength);
                 target.AddRange(sampleData.Skip(initLength));
                 var v = target.Value;
                 Assert.AreEqual(10.32, Math.Round(v, 2));
            }
        }
    }
}
