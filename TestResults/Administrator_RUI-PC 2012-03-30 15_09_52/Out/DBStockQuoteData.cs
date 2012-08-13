using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Collections;
using FinancialEngineering.Data.Database.JYDB;
using FinancialEngineering.Data.Database.JYDB.Entities;
using FinancialEngineering.Model;


namespace FinancialEngineering.Data.Database

{
    public class DBStockQuoteData 
    {
        
        public   StockPrice[] GetStockPrice(string secuCode,int numRecord,DateTime endDate)
        {
            string commandText = @"
                DECLARE @Num int
                SET @Num = {0}
                DECLARE @minDate dateTime
                DECLARE @maxDate dateTime
                SET @maxDate = {1}
                SELECT @minDate=Min(TradingDate)FROM (SELECT TOP(@Num) TradingDate FROM JYDB.dbo.QT_TradingDayNew 
                                                      WHERE SecuMarket='83' and IfTradingDay='1' 
                                                      AND TradingDate<= @maxDate
                                                      ORDER BY TradingDate DESC) T
                SELECT   A.InnerCode,E.Tradingday,A.SecuCode
                --     ,E.ClosePrice + AdjustingConst AS AdjustedClose
                        ,CONVERT(float,E.ClosePrice) AS [Close]
                FROM JYDB.dbo.QT_DailyQuote E 
                LEFT JOIN JYDB.dbo.SecuMain A
                ON A.InnerCode=E.InnerCode 
                LEFT OUTER JOIN JYDB.dbo.QT_AdjustingFactor C 
                ON A.InnerCode=C.InnerCode 
                AND C.ExDiviDate= (SELECT TOP 1 ExDiviDate FROM QT_AdjustingFactor 
                                           WHERE InnerCode=A.InnerCode AND ExDiviDate<=E.TradingDay 
                                           ORDER BY ExDiviDate DESC)
                WHERE  ({2} IS NULL OR A.SecuCode = {2})
                    AND  (E.TradingDay >= @minDate) 
                    AND (E.TradingDay <= @maxDate)
                    AND  A.SecuCategory IN (1,2)
                    AND A.SecuMarket IN (83,90) 
                    AND TurnoverVolume>0
                    AND EXISTS(SELECT * FROM JYDB.dbo.QT_TradingDayNew 
                                      WHERE SecuMarket='83' and IfTradingDay='1' 
                                      AND TradingDate = @maxDate)
                ORDER BY E.InnerCode,TradingDay
            ";
            using (var context = new JYDBContext(@"JYDBLocal"))
            {
                var result = context.Database.SqlQuery<StockPrice>(commandText, numRecord, endDate, secuCode);
                return result.ToArray<StockPrice>();
            }
        }

//        public List<StockReturn> CalcReturn(string secuCodeList, DateTime startTime, DateTime endTime)
//        {
//            using (var context = new JYDB_FE(@"metadata=res://*/JYDB_FE.csdl|res://*/JYDB_FE.ssdl|res://*/JYDB_FE.msl;
//                provider=System.Data.SqlClient;provider connection string='
//                data source=10.254.8.204,1435;initial catalog=JYDB_FE;user id=sa;password=hxdb666;multipleactiveresultsets=True;
//                App=EntityFramework'"))
//            {
//                var result = context.CalcReturn(startTime, endTime, secuCodeList);
//                return result.ToList();
//            }
//        }
//        public List<StockReturn> CalcReturn(List<string> secuCode, DateTime startTime, DateTime endTime)
        //{

        //        var stockStr = secuCode.Aggregate<string,string>("",(seed,s)=>
        //        {
        //            if(!string.IsNullOrWhiteSpace(s))
        //            {
        //                seed += "'" + s + "'" + ",";
        //            }
        //            return seed;
        //        });
        //        if (string.IsNullOrWhiteSpace(stockStr)) throw new ArgumentException("Empty SecuCode List");
        //        if (stockStr.EndsWith(","))
        //        {
        //            stockStr = stockStr.Remove(stockStr.Length - 1);
        //        }
        //        return this.CalcReturn(stockStr, startTime, endTime);
        //}
    }
}
