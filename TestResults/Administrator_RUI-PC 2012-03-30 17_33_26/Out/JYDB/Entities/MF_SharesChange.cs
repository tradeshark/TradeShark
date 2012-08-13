using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_SharesChange
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string StatPeriod { get; set; }
		public Nullable<decimal> StartShares { get; set; }
		public Nullable<decimal> ApplyingShares { get; set; }
		public Nullable<decimal> RedeemShares { get; set; }
		public Nullable<decimal> EndShares { get; set; }
		public Nullable<decimal> FloatShares { get; set; }
		public Nullable<decimal> DividendReinvestment { get; set; }
		public Nullable<decimal> ShgiftIn { get; set; }
		public Nullable<decimal> ShiftOut { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> SharesChange { get; set; }
		public Nullable<decimal> RateOfSharesChange { get; set; }
	}
}

