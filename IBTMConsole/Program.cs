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

                var actual = target.GetCandidateStocksForOpen();


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
