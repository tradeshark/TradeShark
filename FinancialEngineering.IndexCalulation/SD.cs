using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.IndexCalculation.Generic;

namespace FinancialEngineering.IndexCalculation
{
    public class SD 
    {
        private MA movingAverage;
        CircularList<double> samples;
        protected double value;

        /// <summary>
        /// Get the average for the current number of samples.
        /// </summary>
        public  double Value
        {
            get
            {
                if (samples.Count == 0)
                {
                    throw new ApplicationException("Number of samples is 0.");
                }
                if (samples.Length != Count)
                {
                    throw new ApplicationException("Not Enough Data To Calculate Moving Average");
                }
                return CalcValue();
            }
        }

        private double CalcValue()
        {
            var total = 0.0d;
            foreach (var v in samples)
            {
                total += Math.Pow(v - this.movingAverage.Value, 2);
            }
            return Math.Sqrt(total / (this.Count -1 ));
        }

        /// <summary>
        /// Constructor, initializing the sample size to the specified number.
        /// </summary>
        public SD(int numSamples)
        {
            this.Count = numSamples;
           
            if (numSamples <= 0)
            {
                throw new ArgumentOutOfRangeException("numSamples can't be negative or 0.");
            }

            samples = new CircularList<double>(numSamples);
            this.movingAverage = new MA(samples,numSamples);
            
        }
        public SD(MA ma)
        {
            this.movingAverage = ma;
            this.samples = ma.Samples;
            this.Count = ma.Count;
            
        }
       
        public int Count
        {
            get;
            set;
        }
    }
}
