using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_Industry
	{
		public long ID { get; set; }
		public int IndustryNum { get; set; }
		public string IndustryName { get; set; }
		public string IndustryCode { get; set; }
		public string IndustryPlate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

