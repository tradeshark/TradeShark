using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class MF_AssetAllocation
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public System.DateTime ReportDate { get; set; }
		public string AssetType { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> RatioInTotalAsset { get; set; }
		public Nullable<decimal> RatioInNV { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> AssetTypeCode { get; set; }
	}
}

