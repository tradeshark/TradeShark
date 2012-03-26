using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_PriceRatioIndex
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<float> StockDividendRatio { get; set; }
		public Nullable<float> StockPERatio1 { get; set; }
		public Nullable<float> StockPERatio2 { get; set; }
		public Nullable<float> StockPERatio3 { get; set; }
		public Nullable<float> StockPBRatio { get; set; }
		public Nullable<float> StockPBRatioAdjusted { get; set; }
		public Nullable<float> StockCFM1 { get; set; }
		public Nullable<float> StockCFM2 { get; set; }
		public Nullable<float> StockCFM3 { get; set; }
		public Nullable<float> StockPSRatio1 { get; set; }
		public Nullable<float> StockPSRatio2 { get; set; }
		public Nullable<float> StockPSRatio3 { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

