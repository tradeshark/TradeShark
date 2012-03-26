using FinancialEngineering.IndexCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FinancialEngineering.IndexCalculation.Test
{
    
    
    /// <summary>
    ///This is a test class for SDTest and is intended
    ///to contain all SDTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SDTest
    {


        private TestContext testContextInstance;
        private double expected;
        private double[] samples;

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
        [TestInitialize()]
        public void MyTestInitialize()
        {
            samples = new double[] { 1, 4.2, 6.8, 8.3, 1, 4.2, 6.8, 8.3, 9.2, 2.2, 1.5, 5, 3, 10, 0.3, 0.1, 2.2, 1.5, 5, 3 };



            expected = 3.1205;
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Value
        ///</summary>
        [TestMethod()]
        public void ValueTest()
        {
            MA ma = new MA(20); // TODO: Initialize to an appropriate value
            ma.AddRange(samples);
            SD target = new SD(ma); // TODO: Initialize to an appropriate value
            double actual;
            actual = Math.Round(target.Value,4);
            Assert.AreEqual(expected, actual);
        }
    }
}
