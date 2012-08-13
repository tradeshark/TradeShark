using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_ConvRateByCategory
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int PubOrgCode { get; set; }
		public Nullable<int> FirstSecuCategory { get; set; }
		public int SecondSecuCategory { get; set; }
		public System.DateTime ExecuteDate { get; set; }
		public Nullable<System.DateTime> CancelDate { get; set; }
		public Nullable<decimal> MaxConvensionRate { get; set; }
		public Nullable<decimal> MinConvensionRate { get; set; }
		public string ConvensionRateDesc { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

