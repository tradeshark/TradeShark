using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_AuditOpinion
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string AccountingFirms { get; set; }
		public Nullable<int> InstiBelongedCode { get; set; }
		public string CPA { get; set; }
		public Nullable<int> OpinionType { get; set; }
		public string OpinionFullText { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

