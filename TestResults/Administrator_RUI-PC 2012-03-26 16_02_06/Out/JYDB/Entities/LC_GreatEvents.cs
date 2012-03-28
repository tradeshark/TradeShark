using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_GreatEvents
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string Content { get; set; }
		public Nullable<int> InvolvedType { get; set; }
		public string XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

