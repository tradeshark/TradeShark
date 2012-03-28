using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_CapitalReserve
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string DataType { get; set; }
		public Nullable<decimal> StockPremium { get; set; }
		public Nullable<decimal> StockPremiumIC { get; set; }
		public Nullable<decimal> EquityInvReserves { get; set; }
		public Nullable<decimal> EquityInvReservesIC { get; set; }
		public Nullable<decimal> AssetValuationReserve { get; set; }
		public Nullable<decimal> AssetValuationReserveIC { get; set; }
		public Nullable<decimal> DonatedSurplus { get; set; }
		public Nullable<decimal> DonatedNonCashSurplus { get; set; }
		public Nullable<decimal> DonatedCashSurplus { get; set; }
		public Nullable<decimal> DonatedICSurplus { get; set; }
		public Nullable<decimal> ForeignCurrencyCapital { get; set; }
		public Nullable<decimal> ForeignCurrencyCapitalIC { get; set; }
		public Nullable<decimal> AllocateSumsChangeoverIn { get; set; }
		public Nullable<decimal> ConnectedTransactionSpread { get; set; }
		public Nullable<decimal> DebtRearrangementGain { get; set; }
		public Nullable<decimal> OtherCapitalReserve { get; set; }
		public Nullable<decimal> HouseTurnoverFunds { get; set; }
		public Nullable<decimal> FreezedCapitalInterest { get; set; }
		public Nullable<decimal> EquityInvDiff { get; set; }
		public Nullable<decimal> Subsidy { get; set; }
		public Nullable<decimal> PayableUnableToPay { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

