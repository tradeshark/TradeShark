using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class Fut_FutureIndicators
	{
		public long ID { get; set; }
		public int ContractInnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EffectiveDate { get; set; }
		public Nullable<System.DateTime> CancleDate { get; set; }
		public int IndicatorCode { get; set; }
		public string IndicatorName { get; set; }
		public Nullable<int> IndicatorUnit { get; set; }
		public Nullable<decimal> DataValue { get; set; }
		public Nullable<decimal> RatioValue { get; set; }
		public string RemarkDesc { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

