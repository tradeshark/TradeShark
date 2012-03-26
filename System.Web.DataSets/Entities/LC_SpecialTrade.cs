using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_SpecialTrade
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string SecurityAbbr { get; set; }
		public int SpecialTradeType { get; set; }
		public Nullable<System.DateTime> SpecialTradeTime { get; set; }
		public string SpecialTradeExplain { get; set; }
		public string SpecialTradeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

