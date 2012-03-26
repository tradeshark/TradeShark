using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_BondPortifolioDetail
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public int SerialNumber { get; set; }
		public Nullable<int> BondCode { get; set; }
		public Nullable<decimal> HoldVolume { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> RatioInNV { get; set; }
		public byte IfInConvertibleTerm { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

