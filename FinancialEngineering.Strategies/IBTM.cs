using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinancialEngineering.Strategy;
using FinancialEngineering.IndexCalculation;

using FinancialEngineering.Data.ServiceContract;
using FinancialEngineering.Data.Database;
using System.Collections;
using FinancialEngineering.Data.External;
using System.Web.DataSets.Model;

namespace FinancialEngineering.Strategy
{
    public class IBTM : StrategyBase
    {
        private double delta = 0;

        public double Delta
        {
            get { return delta; }
            set { delta = value; }
        }

        private double lamda = 2;

        public double Lamda
        {
            get { return lamda; }
            set { lamda = value; }
             }

        private int days = 20;
        private Dictionary<DateTime, BOLL> bolls = new Dictionary<DateTime,BOLL>();

        public Dictionary<DateTime,BOLL> Bolls
        {
          get { return bolls; }
          set { bolls = value; }
        }
        private Dictionary<DateTime, double> closeprice = new Dictionary<DateTime,double>();

        public Dictionary<DateTime, double> ClosePrice
        {
          get { return closeprice; }
          set { closeprice = value; }
        }

        public int Days
        {
            get { return days; }
            set { days = value; }
        }

        public IBTM(int days,DateTime endDate ,double lamda, double delta)
           
        {
            this.days = days;
            this.lamda = lamda;
            this.delta = delta;
            this.endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day); ;
            this.Initialize();
        }
        public IBTM()
        {
            this.Initialize();
        }
        public IBTM(int days,DateTime endDate) 
        {
            this.days = days;
            this.endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day); ;
            this.Initialize();
            
        }
        public IBTM(int days, DateTime endDate,double lamda)
        {
            this.days = days;
            this.endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day); ;
            this.lamda = lamda;
            this.Initialize();

        }
         public IBTM(int days)
        {
            this.days = days;
            this.Initialize();
        }
        
        private Func<bool> openRule;

	public Func<bool> OpenRule
	{
		get { return openRule;}
		set { openRule = value;}
	}
        
    private Func<bool> closeRule;
    private bool initialized;
    private  DateTime endDate = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
    private IEnumerable<IGrouping<int, StockPrice>> stockPrices;

    public IEnumerable<IGrouping<int, StockPrice>> StockPrices
    {
        get { return stockPrices; }
      
    }

    public DateTime EndDate
    {
      get { return endDate; }
      set { endDate = value; }
    }

	public Func<bool> CloseRule
	{
		get { return closeRule;}
		set { closeRule = value;}
	}

    private void Initialize()
    {
        if (!this.initialized)
        {
            var stockQuoteService = new System.Web.DataSets.DBStockQuoteData();
            stockPrices = stockQuoteService.GetStockPrice(null, days + 1, endDate)
                .GroupBy(t=>t.InnerCode);
            this.initialized = true;

        }
    }

    public List<StockPrice> GetCandidateStocksForOpen(Func<IEnumerable<StockPrice>,IEnumerable<StockPrice>> customFilter = null)
    {
        var result = new List<StockPrice>();
        IEnumerable<StockPrice> filtered = null;
        foreach (var g in StockPrices)
        {
            if (g.Max(p => p.Tradingday) != endDate) continue;
            var ma = new MA(days);
            bolls.Clear();
            closeprice.Clear();
            foreach (var p in g.ToArray())
            {
                if (p.InnerCode == default(int) || p.Tradingday == default(DateTime)) break;
                ma.AddSample(p.Close.Value);

                if (ma.IsFull)
                {

                    var boll = new BOLL(ma, lamda);
                    bolls.Add(p.Tradingday, boll);
                    closeprice.Add(p.Tradingday, p.Close.Value);
                }
            }
            try
            {
                if (OpenPosition())
                {
                    StockPrice c = g.Where(p => p.Tradingday == endDate).FirstOrDefault();
                    if (c.Tradingday != default(DateTime) && c.InnerCode != default(int))
                    {
                        result.Add(c);
                    }
                }
                if (customFilter != null)
                {
                    filtered = customFilter(g);
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
            }

        }
        if (filtered != null) return result.Except(filtered).ToList();
        return result;
    }
    public void GetCandidateStocksForClose()
    {
       throw new NotImplementedException();
    }
    private bool OpenPosition()
    {
        if (!this.initialized) throw new InvalidOperationException("Invoke Initialize Method First");

        if(openRule != null) return openRule();

        if (this.closeprice == null || this.closeprice.Count < 2 || this.bolls == null || this.bolls.Count < 2) return false;

        var bollLen = this.bolls.Count;
        var priceLen = this.closeprice.Count;
        var prevDay = this.closeprice.Keys.Where(t => t < endDate).OrderByDescending(d => d).First();

        if (this.bolls[prevDay].DN < this.closeprice[prevDay] +   this.closeprice[prevDay] * delta && this.bolls[endDate].DN > this.closeprice[endDate] - this.closeprice[endDate] * delta)
        {
            return true;
        }

        return false;
    }

    private bool ClosePosition()
    {
        throw new NotImplementedException();
    }

        
    }
}
