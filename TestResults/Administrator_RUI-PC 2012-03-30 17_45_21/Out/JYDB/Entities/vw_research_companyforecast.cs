using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class vw_research_companyforecast
	{
		public string years { get; set; }
		public System.DateTime endDate { get; set; }
		public string secucode { get; set; }
		public int companytype { get; set; }
		public Nullable<decimal> SalesRevenue { get; set; }
		public Nullable<decimal> MainIncomeGrowRate { get; set; }
		public Nullable<decimal> GrossProfit { get; set; }
		public Nullable<decimal> GrossProfitGrowRate { get; set; }
		public Nullable<decimal> NetProfit { get; set; }
		public Nullable<decimal> NetProfitGrowRate { get; set; }
		public Nullable<decimal> EPS { get; set; }
		public Nullable<decimal> NetAssetPS { get; set; }
		public Nullable<decimal> ROE { get; set; }
	}
}

