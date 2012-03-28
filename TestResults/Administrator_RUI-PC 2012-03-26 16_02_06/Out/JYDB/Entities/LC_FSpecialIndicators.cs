using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_FSpecialIndicators
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public int Mark { get; set; }
		public int IndicatorType { get; set; }
		public string IndicatorName { get; set; }
		public Nullable<int> IndicatorCode { get; set; }
		public Nullable<decimal> Amount { get; set; }
		public Nullable<decimal> RatioEOP { get; set; }
		public Nullable<decimal> RatioAVG { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

