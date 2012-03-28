using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_ChinaForeignDebts
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public int DebtorsCode { get; set; }
		public Nullable<decimal> LoansForeignGov { get; set; }
		public Nullable<decimal> LoansIFO { get; set; }
		public Nullable<decimal> LoansFI { get; set; }
		public Nullable<decimal> BuyerCredit { get; set; }
		public Nullable<decimal> BorrowingsFromOthers { get; set; }
		public Nullable<decimal> ForeignBankInChinaLoans { get; set; }
		public Nullable<decimal> BondIssuedAbroad { get; set; }
		public Nullable<decimal> DeferredPayments { get; set; }
		public Nullable<decimal> ForeignerSavings { get; set; }
		public Nullable<decimal> IntlFinancialLeasing { get; set; }
		public Nullable<decimal> CashPayedforDebtsInCT { get; set; }
		public Nullable<decimal> Others { get; set; }
		public Nullable<decimal> TradeCredit { get; set; }
		public Nullable<decimal> Total { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

