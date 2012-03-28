using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_GP_AuditOpinion
	{
		public string N_InstiBelongedCode { get; set; }
		public string N_OpinionType { get; set; }
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

