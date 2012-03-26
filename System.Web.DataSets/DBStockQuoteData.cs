using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Collections;
using System.Web.DataSets;
using System.Web.DataSets.Entities;
using System.Web.DataSets.Model;



namespace System.Web.DataSets

{
    public class DBStockQuoteData 
    {
        
        public   StockPrice[] GetStockPrice(string secuCode,int numRecord,DateTime endDate)
        {
//            string commandText = @"
//                DECLARE @Num int
//                SET @Num = @p0
//                DECLARE @minDate dateTime
//                DECLARE @maxDate dateTime
//                SET @maxDate = @p1
//                DECLARE @SecuCode nvarchar(4000)
//                SET @SecuCode = @p2
//                ;
//                WITH b as
//                ( 
//                   SELECT A.InnerCode,E.Tradingday,A.SecuCode,CONVERT(float,E.ClosePrice) AS [Close],
//					row_number() over (partition by A.innercode order by tradingDay DESC) as [rn] 
//					FROM JYDB.dbo.QT_DailyQuote E 
//					LEFT JOIN JYDB.dbo.SecuMain A
//					ON A.InnerCode=E.InnerCode 
//					WHERE  (@SecuCode IS NULL OR A.SecuCode = @SecuCode)
//						AND (E.TradingDay <= @maxDate)
//						AND  A.SecuCategory IN (1,2)
//						AND A.SecuMarket IN (83,90) 
//						AND E.TurnoverVolume>0
//                )
//                SELECT InnerCode,Tradingday,SecuCode,[Close] FROM b
//                WHERE [rn] <= @Num
//                ORDER BY InnerCode,TradingDay 
//            ";
            var result = new List<StockPrice>();
            using (var context = new JYDBContext(
                "JYDBLocal"))
            {

                using (var con = context.Database.Connection)
                {
                  
                    var command = new SqlCommand("GetClosePrice", (SqlConnection)con);
                    command.CommandType = Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@num", Data.SqlDbType.Int);
                    command.Parameters["@num"].Value = numRecord;
                    command.Parameters.Add("@maxDate", Data.SqlDbType.DateTime);
                    command.Parameters["@maxDate"].Value = endDate;
                    command.Parameters.Add("@secuCode", Data.SqlDbType.VarChar,4000);
                    command.Parameters["@secuCode"].Value = secuCode;
                    command.CommandTimeout = 0;
                    con.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var sp = new StockPrice();
                            var v0 = reader.GetValue(0);
                            if (v0 != DBNull.Value)
                            {
                                sp.InnerCode = (int)reader.GetValue(0);
                            }
                            var v1 = reader.GetValue(1);
                            if (v1 != DBNull.Value)
                            {
                                sp.Tradingday = (DateTime)reader.GetValue(1);
                            }
                            var v2 = reader.GetValue(2);
                            if (v2 != DBNull.Value)
                            {
                                sp.SecuCode = (string)reader.GetValue(2);
                            }
                            var v3 = reader.GetValue(3);
                            if (v3 != DBNull.Value)
                            {
                                sp.Close = (double)reader.GetValue(3);
                            }
                            result.Add(sp);
                        }
                    }
                }

               //var result = context.Database.SqlQuery<StockPrice>(commandText, numRecord, endDate, secuCode);
              
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
