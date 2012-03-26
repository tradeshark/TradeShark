using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class IN_IndustryOutputStat
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPubDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> Period { get; set; }
		public Nullable<int> ProductCode { get; set; }
		public string ProductName { get; set; }
		public Nullable<int> Unit { get; set; }
		public Nullable<decimal> OutputQuantity { get; set; }
		public Nullable<decimal> IncreaseOrDecreaseYOY { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> InfoSourceCode { get; set; }
		public Nullable<int> StateCode { get; set; }
		public string StateName { get; set; }
		public string UnitName { get; set; }
	}
}

