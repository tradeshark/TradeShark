using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class BD_ConBondToStock
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<decimal> IssueAmount { get; set; }
		public Nullable<decimal> TotalAmountConverted { get; set; }
		public Nullable<decimal> TotalVolConverted { get; set; }
		public Nullable<decimal> RemainingAmount { get; set; }
		public Nullable<decimal> CurrentTotalShares { get; set; }
		public Nullable<decimal> AmountConvertedThisPeriod { get; set; }
		public Nullable<decimal> VolConvertedThisPeriod { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

