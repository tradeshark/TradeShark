using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_InitiatorHolding
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> FundTotalVolume { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string InitiatorName { get; set; }
		public string InitiatorCode { get; set; }
		public Nullable<decimal> HoldingShares { get; set; }
		public Nullable<decimal> HoldingRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

