using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_ConBasicInfo
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string TradeCodeStk { get; set; }
		public Nullable<int> InnerCodeStk { get; set; }
		public Nullable<int> InnerCodeWarrant { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<int> BondForm { get; set; }
		public Nullable<int> BondNature { get; set; }
		public string GuarantMethod { get; set; }
		public string CreditRating { get; set; }
		public Nullable<decimal> Maturity { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<decimal> ActualIssueSize { get; set; }
		public Nullable<decimal> IssueVolume { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<int> CompoundMethod { get; set; }
		public Nullable<int> IntPaymentMethod { get; set; }
		public Nullable<int> CouponFreq { get; set; }
		public Nullable<decimal> CouponRate { get; set; }
		public Nullable<decimal> FRNMargin { get; set; }
		public Nullable<decimal> IncrsCouponMargin { get; set; }
		public Nullable<System.DateTime> ValueDate { get; set; }
		public string IntPaymentDescription { get; set; }
		public Nullable<decimal> CallProtection { get; set; }
		public Nullable<System.DateTime> CallTermStartDate { get; set; }
		public Nullable<System.DateTime> CallTermEndDate { get; set; }
		public Nullable<decimal> RedemptionPrice { get; set; }
		public Nullable<decimal> RedemptionPriceAfterTax { get; set; }
		public Nullable<System.DateTime> RedemptionPayDate { get; set; }
		public Nullable<decimal> RedemptionVolume { get; set; }
		public Nullable<System.DateTime> PutTermStartDate { get; set; }
		public Nullable<System.DateTime> PutTermEndDate { get; set; }
		public Nullable<decimal> PutablePrice { get; set; }
		public Nullable<decimal> VolumeAfterPut { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<System.DateTime> ListedEndDate { get; set; }
		public string TradingMethod { get; set; }
		public string TradingUnit { get; set; }
		public Nullable<decimal> TradingUnitParValue { get; set; }
		public Nullable<System.DateTime> StopTradingDate { get; set; }
		public Nullable<System.DateTime> LastTradingDate { get; set; }
		public Nullable<System.DateTime> DelistDate { get; set; }
		public Nullable<decimal> InitialConvPrice { get; set; }
		public Nullable<decimal> InitialConvRatio { get; set; }
		public Nullable<decimal> ActualConvPrice { get; set; }
		public Nullable<decimal> ActualConvRatio { get; set; }
		public Nullable<System.DateTime> ConvTermStartDate { get; set; }
		public Nullable<System.DateTime> ConvTermEndDate { get; set; }
		public string ConvStkAbbrName { get; set; }
		public string ConvCode { get; set; }
		public Nullable<System.DateTime> StopConvDate { get; set; }
		public Nullable<System.DateTime> ForcedConvDate { get; set; }
		public Nullable<decimal> ForcedConvPrice { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

