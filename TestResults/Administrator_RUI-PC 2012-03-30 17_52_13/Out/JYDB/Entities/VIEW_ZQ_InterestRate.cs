using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_ZQ_InterestRate
	{
		public string N_FRNRefRateText { get; set; }
		public Nullable<decimal> N_FRNRefRatePer { get; set; }
		public Nullable<decimal> N_CouponRatePer { get; set; }
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> FRNRefRateText { get; set; }
		public Nullable<decimal> FRNRefRatePer { get; set; }
		public int Number { get; set; }
		public Nullable<System.DateTime> ValueDatePer { get; set; }
		public Nullable<System.DateTime> LastDatePer { get; set; }
		public Nullable<decimal> CouponRatePer { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

