using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_RelatedTrade
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> InfoSourceType { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Media { get; set; }
		public string RelatedParty { get; set; }
		public Nullable<int> Association { get; set; }
		public Nullable<int> TradeType { get; set; }
		public Nullable<decimal> TradeSum { get; set; }
		public Nullable<decimal> RatioInProject { get; set; }
		public Nullable<int> PricingMethod { get; set; }
		public string PaymentMeans { get; set; }
		public Nullable<System.DateTime> ConfirmedDate { get; set; }
		public string TradeContent { get; set; }
		public string IndeFinaAdvisor { get; set; }
		public string FinancialEffect { get; set; }
		public Nullable<int> TradeChangeInfo { get; set; }
		public Nullable<System.DateTime> TradeChangeDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

