using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.Model;
using FinancialEngineering.Common.Utils;
using FinancialEngineering.Data.ServiceContract;

namespace FinancialEngineering.Service
{
    public class WebStockReturn : IStockReturn
    {
        public List<StockReturn> GetStockReturn(string secuCodeList, DateTime startDate, DateTime endDate)
        {
            EnhancedUriBuilder uriBuilder = new EnhancedUriBuilder("http://218.6.198.202:8081/SData/Return");
            uriBuilder.QueryItems.Add("secuCodeList", secuCodeList);
            uriBuilder.QueryItems.Add("startDate", startDate.ToString("yyyyMMdd"));
            uriBuilder.QueryItems.Add("endDate", endDate.ToString("yyyyMMdd"));
            return HttpUtil.PerformHttpGetXmlObject<List<StockReturn>>(uriBuilder.Uri.AbsoluteUri, true);
        }
    }
}
