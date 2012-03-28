using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_IntangibleAsset
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<byte> SN { get; set; }
		public Nullable<int> Type { get; set; }
		public string Name { get; set; }
		public Nullable<int> Ownership { get; set; }
		public Nullable<int> AcquiringOrUsingWays { get; set; }
		public string Statements { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

