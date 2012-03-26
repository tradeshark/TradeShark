using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ShortTermInv
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string DataType { get; set; }
		public Nullable<decimal> ShortTermInvOnStock { get; set; }
		public Nullable<decimal> QuotedStock { get; set; }
		public Nullable<decimal> UnquotedStockStock { get; set; }
		public Nullable<decimal> ShortTermInvOnBond { get; set; }
		public Nullable<decimal> TreasuryBond { get; set; }
		public Nullable<decimal> FinancialBond { get; set; }
		public Nullable<decimal> CompanyBond { get; set; }
		public Nullable<decimal> ConvertibleBond { get; set; }
		public Nullable<decimal> BondsRepurchase { get; set; }
		public Nullable<decimal> InvOnMutualFunds { get; set; }
		public Nullable<decimal> EntrustedInv { get; set; }
		public Nullable<decimal> FuturesInv { get; set; }
		public Nullable<decimal> OtherShortTermInv { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

