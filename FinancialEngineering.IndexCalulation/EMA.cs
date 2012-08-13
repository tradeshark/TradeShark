using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.IndexCalculation.Generic;

namespace FinancialEngineering.IndexCalculation
{
    public class EMA : IMovingAverage
    {
        private double value;
        private double multiplier;
        private int period;
        private double exp;
        private double tolerance;
        private double v0;
        public Generic.CircularList<double> Samples
        {
            get;
            set;
        }

        public int Length
        {
            get;
            set;
        }
        public double Value
        {
            get
            {
                return value;
            }
            internal set
            {
               this.value = value;
            }
        }
        public static bool TryCreateInstance(int period,double tolerance,double[] initSamples,out EMA ema,out int initLength)
        {
            ema = null;
            var multiplier = 2.0 / (period + 1.0);
            var exp = (period - 1.0) / (period + 1.0); ;
            initLength = initSamples.Length;
            var isFitTolerance = Math.Round(Math.Log(tolerance / initSamples[0], exp)) <= initSamples.Length;
            if (isFitTolerance)
            {
                ema = new EMA(period, tolerance);
                int i = 0;
                ema.Value = multiplier * initSamples.Aggregate(0.0, (seed, v) =>
                {

                    seed += Math.Pow(exp, i) * initSamples[initSamples.Length - 1 - i];
                    i++;
                    return seed;
                });
            }
            else
            {
                initLength = Convert.ToInt32(Math.Round(Math.Log(tolerance / initSamples[0], exp)));
            }
            return isFitTolerance;
        }
          /// <summary>
        /// Constructor, initializing the sample size to the specified number.
        /// </summary>
        public EMA(int period ,double tolerance) : this(period)
        {
            this.tolerance = tolerance;
        }

        public EMA(int period)
        {
            this.period = period;
            this.multiplier = 2.0 / (period + 1.0);
            this.exp = (period - 1.0) / (period + 1.0);
            if (period <= 0)
            {
                throw new ArgumentOutOfRangeException("period can't be negative or 0.");
            }
            this.tolerance = 0.0001;
        }
        public void AddSample(double val)
        {
           
            value = (val - value) * multiplier + value; ;

        }
        public void ClearSamples()
        {
            value = 0;
            Samples.Clear();
        }

        public void AddRange(IEnumerable<double> values)
        {
            if (values == null) return;
            foreach (var v in values)
            {
                this.AddSample(v);
            }
        }
        public bool IsFull { get; set; }
        public bool IsFitPresion
        {
            get
            {
                return Math.Round(Math.Log(tolerance / Samples[0], exp)) < Samples.Count;
            }
        }
    }
}
