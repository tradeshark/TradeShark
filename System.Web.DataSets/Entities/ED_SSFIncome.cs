using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_SSFIncome
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public int IfAdjusted { get; set; }
		public Nullable<decimal> OperRevenues { get; set; }
		public Nullable<decimal> EntrustInvReturns { get; set; }
		public Nullable<decimal> BondInterests { get; set; }
		public Nullable<decimal> TBondInterests { get; set; }
		public Nullable<decimal> OtherBondInterests { get; set; }
		public Nullable<decimal> SavingsInterests { get; set; }
		public Nullable<decimal> StockDividend { get; set; }
		public Nullable<decimal> TaxReimbursement { get; set; }
		public Nullable<decimal> OtherIncome { get; set; }
		public Nullable<decimal> OperExpenses { get; set; }
		public Nullable<decimal> InterestExpenses { get; set; }
		public Nullable<decimal> EntrustedSecuAssetsLoss { get; set; }
		public Nullable<decimal> CurrencyExchangeLoss { get; set; }
		public Nullable<decimal> OtherExpenses { get; set; }
		public Nullable<decimal> OperIncome { get; set; }
		public Nullable<decimal> ProvisionRiskReserves { get; set; }
		public Nullable<decimal> OperIncomeReserved { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

