using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FundBondPortTerm
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> AverageTermToMaturity { get; set; }
		public Nullable<decimal> TermARateOfNetValue { get; set; }
		public Nullable<decimal> TermBRateOfNetValue { get; set; }
		public Nullable<decimal> TermCRateOfNetValue { get; set; }
		public Nullable<decimal> TermDRateOfNetValue { get; set; }
		public Nullable<decimal> TermERateOfNetValue { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> DebtARateOfNetValue { get; set; }
		public Nullable<decimal> DebtBRateOfNetValue { get; set; }
		public Nullable<decimal> DebtCRateOfNetValue { get; set; }
		public Nullable<decimal> DebtDRateOfNetValue { get; set; }
		public Nullable<decimal> DebtERateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefARateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefBRateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefCRateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefDRateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefERateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefDebtARateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefDebtBRateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefDebtCRateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefDebtDRateOfNetValue { get; set; }
		public Nullable<decimal> FRNRefDebtERateOfNetValue { get; set; }
	}
}

