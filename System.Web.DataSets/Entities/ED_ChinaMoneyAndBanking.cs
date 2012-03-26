using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_ChinaMoneyAndBanking
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public int AccountCode { get; set; }
		public Nullable<decimal> NetAbroadAssets { get; set; }
		public Nullable<decimal> DomesticLoans { get; set; }
		public Nullable<decimal> ClaimsToGov { get; set; }
		public Nullable<decimal> ClaimsToNonfinancialInst { get; set; }
		public Nullable<decimal> ClaimsToSpecificSavingOrg { get; set; }
		public Nullable<decimal> ClaimsToOtherInst { get; set; }
		public Nullable<decimal> moneyAndQuasimoney { get; set; }
		public Nullable<decimal> money1 { get; set; }
		public Nullable<decimal> moneyInCirculation { get; set; }
		public Nullable<decimal> DemandDeposits { get; set; }
		public Nullable<decimal> Quasimoney { get; set; }
		public Nullable<decimal> TimeDeposits { get; set; }
		public Nullable<decimal> SavingsDposits { get; set; }
		public Nullable<decimal> OtherSavings { get; set; }
		public Nullable<decimal> FCDeposits { get; set; }
		public Nullable<decimal> Bonds { get; set; }
		public Nullable<decimal> CentralBankBonds { get; set; }
		public Nullable<decimal> CapitalReceived { get; set; }
		public Nullable<decimal> NetOthers { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

