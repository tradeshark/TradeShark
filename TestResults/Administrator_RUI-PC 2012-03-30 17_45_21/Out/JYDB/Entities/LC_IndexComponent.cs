using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_IndexComponent
	{
		public long ID { get; set; }
		public int IndexInnerCode { get; set; }
		public int SecuInnerCode { get; set; }
		public Nullable<System.DateTime> InDate { get; set; }
		public Nullable<System.DateTime> OutDate { get; set; }
		public int Flag { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

