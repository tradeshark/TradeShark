using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_LargeSHSubscription
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public Nullable<int> SHSN { get; set; }
		public string SHName { get; set; }
		public Nullable<int> SubscriptionWay { get; set; }
		public Nullable<decimal> OughtShares { get; set; }
		public Nullable<decimal> ActualShares { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

