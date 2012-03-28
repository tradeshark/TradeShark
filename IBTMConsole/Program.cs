using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using FinancialEngineering.Strategy;
using FinancialEngineering.BackTesting.Storage;
using System.Web.DataSets;
using FinancialEngineering.Common.Utils;
using System.Web.DataSets.Entities;
using System.Data;
using System.Data.SqlClient;
using System.Web.DataSets.Model;


namespace IBTMConsole
{
    class Program
    {

       
        static void CalcHistoryIBTM()
        {
        
        }

     
        static void Main(string[] args)
        {
           
            CalcTodayIBTM();
        }

        private static void CalcTodayIBTM()
        {
            var dateFrom = DateTime.Now;
            var s = File.AppendText(@"C:\Users\Administrator\Desktop\IBTM.txt");
            TradeSharkContext context = new TradeSharkContext("TradeShark"); // TODO: Initialize to an appropriate value
            var strategy = context.Strategies.Where(sg => sg.Id == 1).First();
            try
            {
                IBTM target = new IBTM(20, dateFrom, 2, 0.00d); // TODO: Initialize to an appropriate value
                var filtered = new List<StockPrice>();
                Func<IEnumerable<StockPrice>, IEnumerable<StockPrice>> customFilter =  ps =>
                {
                    var lastest5DayPrice = ps.Reverse().Take(6);
                    if (lastest5DayPrice == null) return filtered;
                    var ps2 = lastest5DayPrice.ToArray();
               
                    var t = 0;
                    if (ps2[0].Close < 1)  //剔除股价太低股票
                    {
                        filtered.Add(ps2[0]);
                        return filtered;
                    }
                    for (int i = 0; i < ps2.Count() -1;i++)  //剔除下跌超过3日股票
                    {
                        if (ps2[i].Close - ps2[i + 1].Close < 0)
                        {
                            t++;
                        }
                    }
                    if (t >= 3) filtered.Add(lastest5DayPrice.FirstOrDefault());
                    return filtered;
                };

                var actual = target.GetCandidateStocksForOpen(customFilter);


                if (actual == null || actual.Count == 0)
                {
                    s.WriteLine(dateFrom.ToString("yyyyMMdd") + ": 今日无候选 ");
                }
                else
                {
                    foreach (var sp in actual)
                    {
                        context.StrategyPortfolios.Add(new FinancialEngineering.BackTesting.Model.StrategyPortfolio()
                        {
                            InnerCode = sp.InnerCode,
                            OpenDate = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day),
                            SecuAbbr = "",
                            SecuCode = sp.SecuCode,
                            Strategy = strategy
                        });
                    }
                    context.SaveChanges();
                    s.WriteLine(dateFrom.ToString("yyyyMMdd") + ":  " + actual.Aggregate("", (r, i) =>
                    {
                        r += i.SecuCode + ","; return r;
                    }));

                }
                Console.WriteLine("计算成功结束");
            }
            catch (Exception e)
            {
                s.WriteLine(dateFrom.ToString("yyyyMMdd") + ": 发生错误： " + e.Message);
                s.WriteLine(e.StackTrace);
            }
            finally
            {
                context.Dispose();
                s.Flush();
                s.Dispose();
              
            }
        }
    }
}
