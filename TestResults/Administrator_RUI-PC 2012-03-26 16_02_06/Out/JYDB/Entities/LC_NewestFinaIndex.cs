using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_NewestFinaIndex
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime AdjustDate { get; set; }
		public string AdjustReason { get; set; }
		public Nullable<decimal> ShareCapitalBeforeAdjust { get; set; }
		public Nullable<decimal> SHareCapitalIncr { get; set; }
		public Nullable<decimal> ShareCapitalAftereAdjust { get; set; }
		public Nullable<decimal> CapitalReserveBeforeAdjust { get; set; }
		public Nullable<decimal> CapitalReserveIncr { get; set; }
		public Nullable<decimal> CapitalReserveAfterAdjust { get; set; }
		public Nullable<decimal> RetainedProfitBeforeAdjust { get; set; }
		public Nullable<decimal> RetainedProfitIncr { get; set; }
		public Nullable<decimal> RetainedProfitAfterAdjust { get; set; }
		public Nullable<decimal> SurplusReserveBeforeAdjust { get; set; }
		public Nullable<decimal> SurplusReserveIncr { get; set; }
		public Nullable<decimal> SurplusReserveAfterAdjust { get; set; }
		public Nullable<decimal> NetAssetBeforeAdjust { get; set; }
		public Nullable<decimal> NetAssetIncr { get; set; }
		public Nullable<decimal> NetAssetAfterAdjust { get; set; }
		public Nullable<decimal> EPS { get; set; }
		public Nullable<decimal> NAPS { get; set; }
		public Nullable<decimal> RetainedProfitPS { get; set; }
		public Nullable<decimal> CapitalReservePS { get; set; }
		public Nullable<decimal> NetOperateCashFlowPS { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

