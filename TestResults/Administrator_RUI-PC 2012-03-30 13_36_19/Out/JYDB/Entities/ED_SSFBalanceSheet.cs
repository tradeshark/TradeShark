using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_SSFBalanceSheet
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public byte IfAdjusted { get; set; }
		public Nullable<decimal> BankSavings { get; set; }
		public Nullable<decimal> InterestsReceivable { get; set; }
		public Nullable<decimal> DividensReceivables { get; set; }
		public Nullable<decimal> OtherReceivables { get; set; }
		public Nullable<decimal> ShortTermBondInv { get; set; }
		public Nullable<decimal> EntrustedInv { get; set; }
		public Nullable<decimal> StockAssetsReceived { get; set; }
		public Nullable<decimal> EquityAssets { get; set; }
		public Nullable<decimal> ApplingForNewShares { get; set; }
		public Nullable<decimal> LongTermBondInv { get; set; }
		public Nullable<decimal> LongTermBondInvMaturedIn1Year { get; set; }
		public Nullable<decimal> OtherAssets { get; set; }
		public Nullable<decimal> TotalAssets { get; set; }
		public Nullable<decimal> InterestsPayable { get; set; }
		public Nullable<decimal> AccountsPayable { get; set; }
		public Nullable<decimal> BankBorrowings { get; set; }
		public Nullable<decimal> OtherLiabilities { get; set; }
		public Nullable<decimal> TotalLiabilities { get; set; }
		public Nullable<decimal> SocialSecurityFunds { get; set; }
		public Nullable<decimal> RiskReserves { get; set; }
		public Nullable<decimal> UnrealizedProfitSecuAsset { get; set; }
		public Nullable<decimal> OtherFundsClaims { get; set; }
		public Nullable<decimal> TotalEquities { get; set; }
		public Nullable<decimal> OtherLiabilitiesAndEquity { get; set; }
		public Nullable<decimal> TotalLiabilitiesAndEquity { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

