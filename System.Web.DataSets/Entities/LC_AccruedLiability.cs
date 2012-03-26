using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_AccruedLiability
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> SecurityLoss { get; set; }
		public Nullable<decimal> PenaltyCost { get; set; }
		public Nullable<decimal> QualityAssuranceCost { get; set; }
		public Nullable<decimal> OtherAccruedLiability { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

