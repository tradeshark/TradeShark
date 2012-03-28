using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_NonOperatingIncome
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> AmercementIncome { get; set; }
		public Nullable<decimal> CompensationIncome { get; set; }
		public Nullable<decimal> AssetDealIncome { get; set; }
		public Nullable<decimal> CurrentAsset { get; set; }
		public Nullable<decimal> FixedAsset { get; set; }
		public Nullable<decimal> IntangibleAsset { get; set; }
		public Nullable<decimal> NonPerformingAsset { get; set; }
		public Nullable<decimal> LossSwitchBack { get; set; }
		public Nullable<decimal> debtUnneededPay { get; set; }
		public Nullable<decimal> InterestofFreezeCapital { get; set; }
		public Nullable<decimal> TaxAndFeeRefund { get; set; }
		public Nullable<decimal> VATIncome { get; set; }
		public Nullable<decimal> OtherNonOperatingIncome { get; set; }
		public Nullable<decimal> DebtRearrangementIncom { get; set; }
		public Nullable<decimal> SubsidyIncome { get; set; }
		public Nullable<decimal> AwardIncome { get; set; }
		public Nullable<decimal> CommissionIncome { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

