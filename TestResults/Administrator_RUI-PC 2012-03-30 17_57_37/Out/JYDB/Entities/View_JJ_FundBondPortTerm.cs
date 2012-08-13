using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_JJ_FundBondPortTerm
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<decimal> AverageTermToMaturity { get; set; }
		public Nullable<decimal> TermARateOfNetValue { get; set; }
		public Nullable<decimal> TermBRateOfNetValue { get; set; }
		public Nullable<decimal> TermCRateOfNetValue { get; set; }
		public Nullable<decimal> TermDRateOfNetValue { get; set; }
		public Nullable<decimal> TermERateOfNetValue { get; set; }
		public long JSID { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

