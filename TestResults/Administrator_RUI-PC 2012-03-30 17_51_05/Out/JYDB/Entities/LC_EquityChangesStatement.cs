using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_EquityChangesStatement
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int Mark { get; set; }
		public int AccountingStandards { get; set; }
		public Nullable<int> ItemsSN { get; set; }
		public string ItemsName { get; set; }
		public Nullable<int> ItemsType { get; set; }
		public Nullable<decimal> PaidInCapital { get; set; }
		public Nullable<decimal> CapitalReserveFund { get; set; }
		public Nullable<decimal> SurplusReserveFund { get; set; }
		public Nullable<decimal> RetainedProfit { get; set; }
		public Nullable<decimal> TreasuryStock { get; set; }
		public Nullable<decimal> CommonRiskReserve { get; set; }
		public Nullable<decimal> ConversionMarginInFCR { get; set; }
		public Nullable<decimal> OtherShareholderEquity { get; set; }
		public Nullable<decimal> SpecialItem { get; set; }
		public Nullable<decimal> AdjustmentItem { get; set; }
		public Nullable<decimal> TotalShareholderEquity { get; set; }
		public Nullable<decimal> TotalParentCompanySE { get; set; }
		public Nullable<decimal> MinoritySE { get; set; }
		public string SpecialFieldRemark { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

