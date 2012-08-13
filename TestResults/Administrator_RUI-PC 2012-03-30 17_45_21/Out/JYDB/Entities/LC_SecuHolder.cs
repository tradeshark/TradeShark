using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SecuHolder
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<decimal> SecuVolume { get; set; }
		public Nullable<int> HolderNum { get; set; }
		public Nullable<int> HolderNo { get; set; }
		public string HolderName { get; set; }
		public Nullable<int> HolderNature { get; set; }
		public Nullable<int> HolderCode { get; set; }
		public Nullable<int> BelongedCompanyCode { get; set; }
		public Nullable<decimal> HoldVolume { get; set; }
		public Nullable<decimal> HoldRatio { get; set; }
		public string Notes { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> InfoType { get; set; }
	}
}

