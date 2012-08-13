using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.DataSets.Model;
using System.Web.DataSets;

namespace FinancialEngineering.Test.Common
{
    public class SampleDataGenerator
    {
        public double[] GetStockPrice(string secuCode,int numRecord,DateTime endDate)
        {
            return new DBStockQuoteData().GetStockPrice(secuCode, numRecord, endDate)
                .Select<StockPrice,double>(p=>p.Close.Value).ToArray();
        }

    }
}
