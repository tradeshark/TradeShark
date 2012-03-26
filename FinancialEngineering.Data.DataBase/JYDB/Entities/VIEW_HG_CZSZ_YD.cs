using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_HG_CZSZ_YD
	{
		public string N_ReportArea { get; set; }
		public string N_Country { get; set; }
		public string N_Province { get; set; }
		public string N_ReportPeriod { get; set; }
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int ReportArea { get; set; }
		public Nullable<int> Country { get; set; }
		public Nullable<int> Province { get; set; }
		public System.DateTime EndDate { get; set; }
		public int ReportPeriod { get; set; }
		public Nullable<decimal> FinancialRE { get; set; }
		public Nullable<decimal> FinancialR { get; set; }
		public Nullable<decimal> FinancialE { get; set; }
		public Nullable<decimal> TaxRevenues { get; set; }
		public Nullable<decimal> InfrastructureE { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

