using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Credit
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AnnouncementType { get; set; }
		public Nullable<int> DisclosureMethod { get; set; }
		public string EventContent { get; set; }
		public string ActionDesc { get; set; }
		public string NewestAdvance { get; set; }
		public Nullable<int> EventSubject { get; set; }
		public Nullable<int> EventProcedure { get; set; }
		public Nullable<int> ActionWays { get; set; }
		public Nullable<int> CurrencyUnit { get; set; }
		public string SubjectName { get; set; }
		public Nullable<int> SubjectCode { get; set; }
		public Nullable<int> SubjectAssociation { get; set; }
		public string ObjectName { get; set; }
		public Nullable<int> ObjectCode { get; set; }
		public Nullable<int> ObjectAssociation { get; set; }
		public Nullable<System.DateTime> AgreementDate { get; set; }
		public Nullable<int> IfEnded { get; set; }
		public string Note { get; set; }
		public Nullable<int> LoanCondition { get; set; }
		public string Borrower { get; set; }
		public Nullable<int> BorrowerAssociation { get; set; }
		public string MortgageAsset { get; set; }
		public string Lender { get; set; }
		public Nullable<int> LenderAssociation { get; set; }
		public string Guarantor { get; set; }
		public Nullable<int> GuarantorAssociation { get; set; }
		public string GuarantorMortgageAsset { get; set; }
		public Nullable<decimal> FirstLoanSum { get; set; }
		public Nullable<decimal> LatestLoanSum { get; set; }
		public Nullable<decimal> LatestRepaymentSum { get; set; }
		public Nullable<decimal> AccumulatedRepaymentSum { get; set; }
		public string YearRateStat { get; set; }
		public Nullable<decimal> YearRate { get; set; }
		public Nullable<decimal> LoanTerm { get; set; }
		public Nullable<decimal> RenewalTerm { get; set; }
		public Nullable<System.DateTime> LoanBeginDate { get; set; }
		public Nullable<System.DateTime> LoanEndDate { get; set; }
		public Nullable<decimal> LoanGuaranteeTerm { get; set; }
		public Nullable<decimal> LoanRenewalGuaranteeTerm { get; set; }
		public Nullable<System.DateTime> LoanGuaranteeBeginDate { get; set; }
		public Nullable<System.DateTime> LoanGuaranteeEndDate { get; set; }
		public Nullable<System.DateTime> LatestRepaymentDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

