using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_AssetBuyAndSale
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> EventType { get; set; }
		public string SubjectName { get; set; }
		public Nullable<int> SubjectCode { get; set; }
		public Nullable<int> SubjectAssociation { get; set; }
		public string ObjectName { get; set; }
		public Nullable<int> ObjectCode { get; set; }
		public Nullable<int> ObjectAssociation { get; set; }
		public string TargetAsset { get; set; }
		public string CounterPartyAsset { get; set; }
		public Nullable<System.DateTime> TradingDay { get; set; }
		public Nullable<int> CurrencyUnit { get; set; }
		public Nullable<decimal> Price { get; set; }
		public Nullable<decimal> ProfitToReportPeriod { get; set; }
		public Nullable<decimal> TradeProfitOrLoss { get; set; }
		public Nullable<int> IfConnectedTransaction { get; set; }
		public string PricingRule { get; set; }
		public Nullable<int> IfOwnershipTransfered { get; set; }
		public Nullable<int> IfDebtTransfered { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

