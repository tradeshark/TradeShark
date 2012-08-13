using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_InsurerCoOperations
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public Nullable<decimal> PremiumRevenue { get; set; }
		public Nullable<decimal> PropertyInsuranceIncome { get; set; }
		public Nullable<decimal> LifeInsuranceIncome { get; set; }
		public Nullable<decimal> AccidentInsuranceIncome { get; set; }
		public Nullable<decimal> HealthInsuranceIncome { get; set; }
		public Nullable<decimal> LongevityInsuranceIncome { get; set; }
		public Nullable<decimal> Indemnity { get; set; }
		public Nullable<decimal> PropertyInsurancePayout { get; set; }
		public Nullable<decimal> LifeInsurancePayout { get; set; }
		public Nullable<decimal> AccidentInsurancePayout { get; set; }
		public Nullable<decimal> HealthInsurancePayout { get; set; }
		public Nullable<decimal> LongevityInsurancePayout { get; set; }
		public Nullable<decimal> OperatingFees { get; set; }
		public Nullable<decimal> BankDeposits { get; set; }
		public Nullable<decimal> Investment { get; set; }
		public Nullable<decimal> TreasuryBond { get; set; }
		public Nullable<decimal> MutualFunds { get; set; }
		public Nullable<decimal> TotalAssets { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

