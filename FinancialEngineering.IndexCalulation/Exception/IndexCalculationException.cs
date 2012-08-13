using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinancialEngineering.IndexCalculation.Exception
{
    public class IndexCalculationException :System.Exception
    {
        public IndexCalculationException()
        {

        }
        public IndexCalculationException(string m) : base(m)
        {

        }
        public IndexCalculationException(string m ,System.Exception innerEx) : base(m,innerEx)
        {
                
        }
    }
}
