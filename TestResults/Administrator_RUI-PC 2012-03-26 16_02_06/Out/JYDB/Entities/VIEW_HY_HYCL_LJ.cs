using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class VIEW_HY_HYCL_LJ
	{
		public string N_Period { get; set; }
		public string N_Unit { get; set; }
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
	}
}

