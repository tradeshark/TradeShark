using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_MoneyAuthorityBS
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public Nullable<decimal> AbroadAssets { get; set; }
		public Nullable<decimal> Forex { get; set; }
		public Nullable<decimal> MoneyAndGold { get; set; }
		public Nullable<decimal> OtherForeignAssets { get; set; }
		public Nullable<decimal> ClaimToGovernment { get; set; }
		public Nullable<decimal> CentralGovernment { get; set; }
		public Nullable<decimal> ClaimToSavingsBanks { get; set; }
		public Nullable<decimal> ClaimToSavingsInst { get; set; }
		public Nullable<decimal> ClaimtoOtherFinNonFinInst { get; set; }
		public Nullable<decimal> ClaimToNonFinancialInst { get; set; }
		public Nullable<decimal> OtherAssets { get; set; }
		public Nullable<decimal> TotalAssets { get; set; }
		public Nullable<decimal> MoneyReserves { get; set; }
		public Nullable<decimal> MoneyIssuance { get; set; }
		public Nullable<decimal> LiabToSavingsBanks { get; set; }
		public Nullable<decimal> LiabToSavingsInst { get; set; }
		public Nullable<decimal> LiabToSpecificSavingsInst { get; set; }
		public Nullable<decimal> LiabtoOtherFinancialInst { get; set; }
		public Nullable<decimal> ReserveDeposits { get; set; }
		public Nullable<decimal> NonFinancialOrgDeposits { get; set; }
		public Nullable<decimal> DemandDeposits { get; set; }
		public Nullable<decimal> SavingsDeposits { get; set; }
		public Nullable<decimal> BondIssuance { get; set; }
		public Nullable<decimal> AbroadLiability { get; set; }
		public Nullable<decimal> GovernmentSavings { get; set; }
		public Nullable<decimal> CentralGovernmentSavings { get; set; }
		public Nullable<decimal> SelfOwnedMoney { get; set; }
		public Nullable<decimal> OtherLiability { get; set; }
		public Nullable<decimal> TotalLiability { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

