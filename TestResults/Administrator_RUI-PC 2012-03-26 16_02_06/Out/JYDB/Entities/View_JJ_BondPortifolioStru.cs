using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_JJ_BondPortifolioStru
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public System.DateTime ReportDate { get; set; }
		public string BondType { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> RatioInNV { get; set; }
		public Nullable<decimal> RatioInBondPortfolio { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

