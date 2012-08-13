using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_IndustryPlate
	{
		public long ID { get; set; }
		public int TypeCode { get; set; }
		public int IndustryNum { get; set; }
		public string IndustryCode { get; set; }
		public string IndustryName { get; set; }
		public int IndustryPlateNum { get; set; }
		public string IndustryPlateCode { get; set; }
		public string IndustryPlateName { get; set; }
		public long JSID { get; set; }
	}
}

