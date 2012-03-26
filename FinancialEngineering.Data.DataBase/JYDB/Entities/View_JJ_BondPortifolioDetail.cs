using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_JJ_BondPortifolioDetail
	{
		public string StockCode { get; set; }
		public string StockName { get; set; }
		public string BondType { get; set; }
		public string N_IfInConvertibleTerm { get; set; }
		public Nullable<decimal> N_RatioInNV { get; set; }
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public int SerialNumber { get; set; }
		public Nullable<int> BondCode { get; set; }
		public Nullable<decimal> HoldVolume { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> RatioInNV { get; set; }
		public byte IfInConvertibleTerm { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

