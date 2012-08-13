using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_Dividend
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<int> Process { get; set; }
		public Nullable<System.DateTime> DMPublDate { get; set; }
		public Nullable<System.DateTime> DMSignDate { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<System.DateTime> ListingPublDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> DividendPeriod { get; set; }
		public Nullable<System.DateTime> FiscalYear { get; set; }
		public Nullable<int> IfDividend { get; set; }
		public Nullable<int> DividendType { get; set; }
		public Nullable<int> DividendUnit { get; set; }
		public Nullable<decimal> CashDividendPS { get; set; }
		public Nullable<int> OtherOption { get; set; }
		public Nullable<decimal> SpecialDividendPS { get; set; }
		public Nullable<int> SpecialDividendSubstitute { get; set; }
		public Nullable<int> ShareDividendRateX { get; set; }
		public Nullable<int> ShareDividendRateY { get; set; }
		public Nullable<int> WarrantDividendRateX { get; set; }
		public Nullable<int> WarrantDividendRateY { get; set; }
		public Nullable<int> PhysicalDividendRateX { get; set; }
		public Nullable<int> PhysicalDividendRateY { get; set; }
		public string Statement { get; set; }
		public Nullable<decimal> TotalCashDividend { get; set; }
		public Nullable<int> DividendBase { get; set; }
		public Nullable<decimal> DividendBaseShares { get; set; }
		public Nullable<decimal> TotalShareDividend { get; set; }
		public Nullable<decimal> TotalWarrantDividend { get; set; }
		public Nullable<System.DateTime> LastTradeDay { get; set; }
		public Nullable<System.DateTime> ExDate { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
		public Nullable<System.DateTime> TransferBeginDate { get; set; }
		public Nullable<System.DateTime> TransferEndDate { get; set; }
		public Nullable<System.DateTime> DividendPayableDate { get; set; }
		public Nullable<System.DateTime> PayoutDate { get; set; }
		public Nullable<System.DateTime> ShareDiviListingDate { get; set; }
		public Nullable<decimal> ScripDividendIssuePrice { get; set; }
		public Nullable<System.DateTime> ScripDividendPayoutDate { get; set; }
		public Nullable<System.DateTime> ScripDividendListingDate { get; set; }
		public Nullable<decimal> ScripDividendSum { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

