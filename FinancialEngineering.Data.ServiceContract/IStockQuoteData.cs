using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.Model;

namespace FinancialEngineering.Data.ServiceContract
{
    public  interface IStockQuoteData
    {
        Model.StockPrice[] GetStockPrice(string secuCode, int numRecord, DateTime endDate);
        
    }
}
