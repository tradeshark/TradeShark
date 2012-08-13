using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ModelIndex
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<float> Z { get; set; }
		public Nullable<float> M5 { get; set; }
		public Nullable<float> M8 { get; set; }
		public Nullable<float> DOL { get; set; }
		public Nullable<float> DFL { get; set; }
		public Nullable<float> DTL { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

