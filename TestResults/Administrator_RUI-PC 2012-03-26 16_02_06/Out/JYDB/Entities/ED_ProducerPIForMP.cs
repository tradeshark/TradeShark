using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_ProducerPIForMP
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public int AdjustMark { get; set; }
		public int ReportPeriod { get; set; }
		public int ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<int> IndexType { get; set; }
		public string IndexName { get; set; }
		public Nullable<int> IndexCode { get; set; }
		public Nullable<decimal> IndexValue { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

