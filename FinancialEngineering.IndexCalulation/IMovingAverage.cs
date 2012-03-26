using System;
using System.Collections.Generic;
using System.Text;
using FinancialEngineering.IndexCalculation.Generic;


namespace FinancialEngineering.IndexCalculation
{
	public interface IMovingAverage 
	{
        CircularList<double> Samples { get; set; }
        int Count { get; set; }
      
        void AddSample(double val);
        void ClearSamples();
        void AddRange(IEnumerable<double> samples);
        
	}
}
