using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_JJ_TradeSeat
	{
		public string N_InstitutionCode { get; set; }
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string SecuCoName { get; set; }
		public Nullable<int> InstitutionCode { get; set; }
		public Nullable<decimal> StockTradeVolume { get; set; }
		public Nullable<decimal> RatioInTotalStockTrade { get; set; }
		public Nullable<decimal> BondTradeVolume { get; set; }
		public Nullable<decimal> RatioInTotalBondTrade { get; set; }
		public Nullable<decimal> BondRepoVolume { get; set; }
		public Nullable<decimal> RatioInTotalRepoVolume { get; set; }
		public Nullable<decimal> Commision { get; set; }
		public Nullable<decimal> RatioInTotalCommision { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

