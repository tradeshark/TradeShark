using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_Product
	{
		public long ID { get; set; }
		public string ProductCategory { get; set; }
		public string ProductName { get; set; }
		public string ProductCode { get; set; }
		public string IndustryCode { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

