using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_WarrentCreationChange
	{
		public long ID { get; set; }
		public int WarrantCategory { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public string Issuer { get; set; }
		public Nullable<int> IssuerSN { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EffectiveDate { get; set; }
		public Nullable<decimal> Circulation { get; set; }
		public Nullable<decimal> ChangeSize { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public string ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

