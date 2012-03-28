using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_RConsideration
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> LatestInfoPublDate { get; set; }
		public Nullable<int> IfEffected { get; set; }
		public Nullable<int> ProgramType { get; set; }
		public Nullable<decimal> GainerHolding { get; set; }
		public Nullable<decimal> Tshare { get; set; }
		public Nullable<decimal> NTShare { get; set; }
		public Nullable<decimal> CompanyGrantedShare { get; set; }
		public Nullable<decimal> NTSHTranPaid { get; set; }
		public Nullable<decimal> CompanyTransformedShare { get; set; }
		public Nullable<decimal> NTSHTranPaidTShare { get; set; }
		public Nullable<decimal> CompanyPaidCashBT { get; set; }
		public Nullable<decimal> NTSHTranPaidCash { get; set; }
		public Nullable<decimal> CompanyWarrantRate { get; set; }
		public Nullable<decimal> NTSNTranWarrant { get; set; }
		public Nullable<decimal> CompanyGTShare { get; set; }
		public Nullable<decimal> CompanyPaidCash { get; set; }
		public Nullable<decimal> CompanyWarrant { get; set; }
		public Nullable<decimal> ShareConsiderationRate { get; set; }
		public Nullable<decimal> CashConsiderationRateBT { get; set; }
		public Nullable<decimal> ShareConsideration { get; set; }
		public Nullable<decimal> CashConsiderationR { get; set; }
		public Nullable<decimal> WarrantConsiderationRate { get; set; }
		public Nullable<decimal> CallWarrant { get; set; }
		public Nullable<decimal> PutWarrant { get; set; }
		public Nullable<decimal> WarrantConsideration { get; set; }
		public Nullable<decimal> RatioOfNTShareBCompressed { get; set; }
		public Nullable<decimal> RatioOfNTShareACompressed { get; set; }
		public Nullable<decimal> ShareCompressedOfNTShare { get; set; }
		public string Program { get; set; }
		public string PricingBasis { get; set; }
		public string Notes { get; set; }
		public Nullable<int> GainerShareKind { get; set; }
		public Nullable<decimal> GTSharefromCompany { get; set; }
		public Nullable<decimal> CashBTfromCompany { get; set; }
		public Nullable<decimal> WarrantfromCompany { get; set; }
		public Nullable<decimal> CompanyPaidCashAT { get; set; }
		public Nullable<decimal> CashATfromCompany { get; set; }
		public Nullable<decimal> CashConsiderationRateAT { get; set; }
		public Nullable<decimal> PresenterHolding { get; set; }
		public Nullable<decimal> RatioInNTSH { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

