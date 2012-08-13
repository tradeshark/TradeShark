using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.IndexCalculation.Generic;
using FinancialEngineering.IndexCalculation.Exception;

namespace FinancialEngineering.IndexCalculation
{
    public class MACD
    {
        private int shortDay;
        private int longDay;
        private int m;
        private int coefShort;
        private int coefLong;
        private double dea;
        private double diff;
        private EMA emaS;
        private EMA emaL;
        private EMA diffCache;
        public MACD(int shortDay ,int longDay,int m) 
        {
            this.shortDay = shortDay;
            this.longDay = longDay;
            this.m = m;
            this.coefShort = 2 / (shortDay + 1);
            this.coefLong = 2 / (longDay + 1);
        
            emaS = new EMA(shortDay,10);
            emaL = new EMA(longDay,10);
            diffCache = new EMA(m,10);
        }
        public MACD()
        {
            this.shortDay = 12;
            this.longDay = 26;
            this.m = 9;
            this.coefShort = 2 / (shortDay + 1);
            this.coefLong = 2 / (longDay + 1);
       
            emaS = new EMA(12,10);
            emaL = new EMA(26,10);
            diffCache = new EMA(m,10);
        }

        public void AddSample(double val)
        {
           
            emaL.AddSample(val);
            if(emaL.Samples.IsFull || emaL.Samples.Index > longDay - shortDay)
            {
                emaS.AddSample(val);
            }
            if (emaL.Samples.IsFull)
            {
                CalcDiff();
            }
            if (diffCache.Samples.IsFull)
            {
                dea = diffCache.Value;
                diff = diffCache.Samples[m-1];
            }
        }
        private void CalcDiff()
        {
            diffCache.AddSample(emaS.Value - emaL.Value); 
        }
        public void ClearSamples()
        {
            emaS.ClearSamples();
            emaL.ClearSamples();
            diff = 0.0;
            dea = 0.0;
        }
        public void AddRange(IEnumerable<double> values)
        {
            if (values == null) return;
            foreach (var v in values)
            {
                this.AddSample(v);
            }
        }
        public double DIF
        {
            get
            {
                if (!HasValue)
                {
                    throw new IndexCalculationException("Not Enough Samples To Calc DIF");
                }
                return diff;
            }
        }
        public double DEA
        {
            get
            {
                if (!HasValue)
                {
                    throw new IndexCalculationException("Not Enough Samples To Calc DEA");
                }
                return dea;
            }
        }
        public bool HasValue
        {
            get
            {
                return diffCache.IsFull;
            }
        }
        public double Value { 
            get 
            {
                if (!HasValue)
                {
                    throw new IndexCalculationException("Not Enough Samples To Calc MACD");
                }
                return (diff - dea) * 2; 
            } 
        }
    }
}
