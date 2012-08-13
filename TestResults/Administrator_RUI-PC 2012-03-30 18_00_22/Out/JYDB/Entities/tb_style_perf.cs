using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class tb_style_perf
	{
		public long id { get; set; }
		public System.DateTime tradingday { get; set; }
		public int cmvstyle { get; set; }
		public int grtstyle { get; set; }
		public Nullable<decimal> yield { get; set; }
		public Nullable<int> yieldrank { get; set; }
		public Nullable<decimal> risk { get; set; }
		public Nullable<int> riskrank { get; set; }
		public Nullable<decimal> yrvalue { get; set; }
		public Nullable<int> yrrank { get; set; }
	}
}

