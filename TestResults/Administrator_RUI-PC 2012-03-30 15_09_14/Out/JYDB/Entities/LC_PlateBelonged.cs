using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_PlateBelonged
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public int PlateCode { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

