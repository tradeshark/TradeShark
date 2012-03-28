using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_RepoConversionStd
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ExecuteDate { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<decimal> Coefficient { get; set; }
		public Nullable<decimal> StdBond { get; set; }
		public Nullable<int> Exchange { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

