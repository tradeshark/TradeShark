using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System.Web.DataSets.Model
{
    public struct StockPrice 
    {
        public string SecuCode { get; set; }
        public int InnerCode { get; set; }
        public DateTime Tradingday { get; set; }
        public double? Open { get; set; }
        public double? High { get; set; }
        public double? Low { get; set; }
        public double? Close { get; set; }
        public double? AdjustedClose { get; set; }
    }
}
