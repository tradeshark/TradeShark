using FinancialEngineering.IndexCalculation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FinancialEngineering.IndexCalculation.Test
{
    
    
    /// <summary>
    ///This is a test class for MATest and is intended
    ///to contain all MATest Unit Tests
    ///</summary>
    [TestClass()]
    public class MATest
    {


        private TestContext testContextInstance;
        private double[] samples;
        private double expected;
        private double[] sampleData;
        private double expectedSampleDataMA;

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


          

            expected = 4.18;
        }
        
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        [TestMethod]
        public void Compare_With_Trade_softWare()
        {
              // 000012 -截至到2011-1-10前60个交易日收盘价,包含1-10号
            sampleData = new double[] { 15.51, 15.86, 15.81, 16.05, 15.88, 17.02, 17.74, 16.9, 18.59, 18.87, 19.55
                , 19.18, 18.16, 19.98, 21.34, 21.35, 22.9, 22.43, 21.86
                , 20.31, 22.34, 21.19, 19.2, 20.62, 22.68, 23.02, 23.9, 23.98
                , 23.57, 23.32, 23.21, 22.1, 21.71, 21.6, 22.55, 21.77, 22.41, 22.47
                , 22.47, 22.29, 23.3, 23.14, 22.56, 22.36, 22.46, 21.94, 21.75, 22.52
                , 21.52, 21.29, 19.93, 18.66, 19.36, 19.05, 19.75
                , 20.03, 19.76, 19.34, 19.01, 18.25 };

            expectedSampleDataMA = 20.63;
            MA target = new MA(60); // TODO: Initialize to an appropriate value
            target.AddRange(sampleData);
            Assert.AreEqual(expectedSampleDataMA, Math.Round(target.Value,2));

            
        }
        /// <summary>
        ///A test for AddSample
        ///</summary>
        [TestMethod()]
        public void Verify_AddSample_Add_New_One()
        {
            int numSamples = 20; // TODO: Initialize to an appropriate value
            MA target = new MA(numSamples); // TODO: Initialize to an appropriate value
            target.AddRange(samples);
            target.AddSample(3.2);
            Assert.AreEqual(4.29, target.Value);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Verify_Error_Throw_When_Init_Count_Not_Equal_Sample_Count()
        {
            int numSamples = 40; // TODO: Initialize to an appropriate value
            MA target = new MA(numSamples); // TODO: Initialize to an appropriate value
            
            double value =  target.Value;
        }

        /// <summary>
        ///A test for ClearSamples
        ///</summary>
        [TestMethod()]
        public void ClearSamplesTest()
        {
            int numSamples = 20; // TODO: Initialize to an appropriate value
            MA target = new MA(numSamples); // TODO: Initialize to an appropriate value
            target.AddSample(3.2);
            target.AddSample(1.5);
            target.ClearSamples();
          
            Assert.AreEqual(target.Samples.Count, 0);
        }
      

        /// <summary>
        ///A test for Count
        ///</summary>
        [TestMethod()]
        public void CountTest()
        {
            int numSamples = 20; // TODO: Initialize to an appropriate value
            MA target = new MA(numSamples); // TODO: Initialize to an appropriate value
         
            target.ClearSamples();
            target.AddRange(samples);

            var actual = target.Value;
            Assert.AreEqual(expected, actual);
          
        }
    }
}

