using System;


using FinancialEngineering.IndexCalculation;
using FinancialEngineering.IndexCalculation.Generic;
using System.Collections;
using System.Collections.Generic;

namespace FinancialEngineering.IndexCalculation
{
    public class MA : IMovingAverage
    {
        CircularList<double> samples;

        public CircularList<double> Samples
        {
            get { return samples; }
            set { samples = value; }
        }
        private double total;

        /// <summary>
        /// Get the average for the current number of samples.
        /// </summary>
        public  double Value
        {
            get
            {
                if (Samples.Count == 0)
                {
                    throw new ApplicationException("Number of samples is 0.");
                }
                if (Samples.Length != Length)
                {
                    throw new ApplicationException("Not Enough Data To Calculate Moving Average");
                }
                return total / Samples.Count;
            }
        }

        /// <summary>
        /// Constructor, initializing the sample size to the specified number.
        /// </summary>
        public MA(int numSamples)
        {
            this.count = numSamples;
            if (numSamples <= 0)
            {
                throw new ArgumentOutOfRangeException("numSamples can't be negative or 0.");
            }

            samples = new CircularList<double>(numSamples);
            total = 0;
        }

        public MA(CircularList<double> samples,int c )
        {
           
            this.samples = samples;
            count = c;
            total = 0;
            
        }
     
        public bool IsFull
        {
            get { return Samples.Count == Length; }
         
        }
        
        /// <summary>
        /// Adds a sample to the sample collection.
        /// </summary>
        public void AddSample(double val)
        {
            if (Samples.Count == Samples.Length)
            {
                total -= Samples.Value;
            }
            total += val;
            Samples.Add(val);
        }

        public void AddRange(IEnumerable<double> samples)
        {
            if (samples == null) return;
            foreach (var v in samples)
            {
                this.AddSample(v);
            }
        }

        /// <summary>
        /// Clears all samples to 0.
        /// </summary>
        public void ClearSamples()
        {
            total = 0;
            Samples.Clear();
        }


        private int count;

        public int Length
        {
            get { return count; }
            set { count = value; }
        }
        
    }
}
