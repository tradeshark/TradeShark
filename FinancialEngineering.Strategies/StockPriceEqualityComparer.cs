using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.DataSets.Model;

namespace FinancialEngineering.Strategy
{
    public class StockPriceEqualityComparer  : IEqualityComparer<StockPrice>
    {
        public bool Equals(StockPrice x, StockPrice y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(StockPrice obj)
        {
            throw new NotImplementedException();
        }
    }
}
