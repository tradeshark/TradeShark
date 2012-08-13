using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_AccruedInterests
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> ValueDatePer { get; set; }
		public Nullable<System.DateTime> DatePer { get; set; }
		public Nullable<decimal> AccruedInterest { get; set; }
		public Nullable<int> AccruedDays { get; set; }
		public Nullable<decimal> CouponRate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

