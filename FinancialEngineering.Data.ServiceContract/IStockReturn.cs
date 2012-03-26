using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.Model;

namespace FinancialEngineering.Data.ServiceContract
{
    public  interface IStockReturn
    {
        List<StockReturn> GetStockReturn(string secuCodeList, DateTime startDate, DateTime endDate);
        
    }
}
