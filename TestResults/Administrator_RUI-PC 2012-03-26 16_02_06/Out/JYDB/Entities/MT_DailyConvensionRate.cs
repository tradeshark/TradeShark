using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_DailyConvensionRate
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int PubOrgCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> FirstSecuCategory { get; set; }
		public Nullable<int> SecondSecuCategory { get; set; }
		public Nullable<decimal> ConvensionRate { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

