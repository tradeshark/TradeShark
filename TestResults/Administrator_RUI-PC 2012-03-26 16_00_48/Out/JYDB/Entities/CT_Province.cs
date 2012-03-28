using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class CT_Province
	{
		public long ID { get; set; }
		public string ProvinceName { get; set; }
		public int ProvinceCode { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

