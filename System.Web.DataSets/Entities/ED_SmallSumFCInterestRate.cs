using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_SmallSumFCInterestRate
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string Sources { get; set; }
		public System.DateTime AdjustDate { get; set; }
		public int CurrencyCode { get; set; }
		public Nullable<decimal> SR_DemandDeposit { get; set; }
		public Nullable<decimal> SR_7daysNotice { get; set; }
		public Nullable<decimal> SR_1month { get; set; }
		public Nullable<decimal> SR_3months { get; set; }
		public Nullable<decimal> SR_6months { get; set; }
		public Nullable<decimal> SR_1year { get; set; }
		public Nullable<decimal> SR_2years { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

