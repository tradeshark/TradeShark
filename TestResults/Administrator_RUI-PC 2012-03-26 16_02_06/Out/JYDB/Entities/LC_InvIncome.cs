using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_InvIncome
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> ShortTermInvIncome { get; set; }
		public Nullable<decimal> StockInvIncome { get; set; }
		public Nullable<decimal> MutualFundInvIncome { get; set; }
		public Nullable<decimal> BondsInvIncome { get; set; }
		public Nullable<decimal> EntrustInvIncome { get; set; }
		public Nullable<decimal> FuturesInvIncome { get; set; }
		public Nullable<decimal> OtherShortTermInvIncome { get; set; }
		public Nullable<decimal> LongTermEquityInvIncome { get; set; }
		public Nullable<decimal> ProfitUnderCostMethod { get; set; }
		public Nullable<decimal> EquityChangeUnderEquityMethod { get; set; }
		public Nullable<decimal> OtherEquityInvIncome { get; set; }
		public Nullable<decimal> BondInvIncome { get; set; }
		public Nullable<decimal> AssetDealIncome { get; set; }
		public Nullable<decimal> InvDevalueReserve { get; set; }
		public Nullable<decimal> ShortTermInvDevalueReserve { get; set; }
		public Nullable<decimal> LongTermInvDevalueReserve { get; set; }
		public Nullable<decimal> DiffAmort { get; set; }
		public Nullable<decimal> EquityInvDiffAmort { get; set; }
		public Nullable<decimal> MergingPriceDiffAmort { get; set; }
		public Nullable<decimal> OtherInvIncome { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

