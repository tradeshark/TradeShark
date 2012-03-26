using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.Data.ServiceContract;
using FinancialEngineering.Model;
using System.Data.SqlClient;
using System.Collections;
using FinancialEngineering.Common.Utils;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace FinancialEngineering.Data.External
{
    public class WebStockQuoteData : IStockQuoteData
    {
        
        public Model.StockPrice[] GetStockPrice(string secuCode,int numRecord,DateTime endDate)
        {
            EnhancedUriBuilder uriBuilder = new EnhancedUriBuilder("http://218.6.198.202:8081/SData/Data");
            uriBuilder.QueryItems.Add("stock", secuCode);
            uriBuilder.QueryItems.Add("total", numRecord.ToString());
            uriBuilder.QueryItems.Add("date", endDate.ToString("yyyyMMdd"));
            return HttpUtil.PerformHttpGetXmlObject<StockPrice[]>(uriBuilder.Uri.AbsoluteUri, true);
        }
       
        //public StockPrice[] GetFormalizedStockPrice(string secuCode, DateTime startDate, DateTime endDate)
        //{
           
        //    var old = this.GetStockPrice(secuCode,startDate,endDate);
        //    var result = new List<StockPrice>();
        //    int days = (endDate - startDate).Days;
        //    var currStock = old[0].InnerCode;
        //    int j = 0;
        //    int d = 0;
        //    StockPrice lastMatch = default(StockPrice);
        //    if (old != null && old.Length > 0)
        //    {
        //        while(j < old.Length)
        //        {
        //            if (old[j].InnerCode != currStock)
        //            {
        //                //if(result.Last().Tradingday != endDate)
        //                //    throw new ApplicationException("The last one date in result earlier than the enddate");

        //                currStock = old[j].InnerCode;
        //                d = 0;
        //            }
        //            if (old[j].Tradingday < startDate)
        //            {
        //                j++;
        //                continue;
        //            }
        //            if (old[j].Tradingday == startDate.AddDays(d))
        //            {
        //                result.Add(old[j]);
        //                d++;
        //                lastMatch = old[j];
        //                j++;
        //                continue;
        //            }
        //            int k = 0;
        //            while (old[j].Tradingday > startDate.AddDays(d))
        //            {
        //                var lastMatchCopy = lastMatch;
        //                lastMatchCopy.Tradingday = startDate.AddDays(d);
        //                result.Add(lastMatchCopy);
        //                d++;
        //            }   
                 
        //        }
        //    }
         
              
        //    return result.ToArray<StockPrice>();
        //}
    }
}
