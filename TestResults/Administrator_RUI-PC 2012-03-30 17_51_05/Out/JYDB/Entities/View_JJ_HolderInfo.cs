using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_JJ_HolderInfo
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> HolderAccountNumber { get; set; }
		public Nullable<decimal> AverageHoldShares { get; set; }
		public Nullable<decimal> InstitutionHoldShares { get; set; }
		public Nullable<decimal> InstitutionHoldRatio { get; set; }
		public Nullable<decimal> IndividualHoldshares { get; set; }
		public Nullable<decimal> IndividualHoldRatio { get; set; }
		public Nullable<decimal> UndefinedHoldShares { get; set; }
		public Nullable<decimal> UndefinedHoldRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

