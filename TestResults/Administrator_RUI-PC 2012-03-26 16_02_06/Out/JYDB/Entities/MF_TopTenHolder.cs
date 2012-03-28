using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_TopTenHolder
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string HolderName { get; set; }
		public string HolderCode { get; set; }
		public Nullable<decimal> HoldingVolume { get; set; }
		public Nullable<decimal> HoldingRatio { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

