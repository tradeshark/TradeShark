using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_FinancialExpense
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> InterestExpense { get; set; }
		public Nullable<decimal> CapitalOccupationExpense { get; set; }
		public Nullable<decimal> InterestExpenseOfDiscount { get; set; }
		public Nullable<decimal> InterestExpenseCapitalized { get; set; }
		public Nullable<decimal> InterestIncome { get; set; }
		public Nullable<decimal> CapitalOccupationIncome { get; set; }
		public Nullable<decimal> InterestSubsidyIncome { get; set; }
		public Nullable<decimal> ExchangeLoss { get; set; }
		public Nullable<decimal> ExchangeLossCapitalized { get; set; }
		public Nullable<decimal> ExchangeIncome { get; set; }
		public Nullable<decimal> CashDiscount { get; set; }
		public Nullable<decimal> OtherFinancialIncome { get; set; }
		public Nullable<decimal> Commission { get; set; }
		public Nullable<decimal> SecurityExpense { get; set; }
		public Nullable<decimal> OtherFinancialExpense { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

