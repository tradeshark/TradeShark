using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_ProductPrice
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public string AreaName { get; set; }
		public Nullable<int> Market { get; set; }
		public Nullable<int> Product { get; set; }
		public string ProductName { get; set; }
		public string Standard { get; set; }
		public Nullable<int> PriceType { get; set; }
		public Nullable<int> PriceUnit { get; set; }
		public Nullable<int> Category { get; set; }
		public Nullable<decimal> Price { get; set; }
		public Nullable<decimal> PriceGYOY { get; set; }
		public Nullable<decimal> PriceLinkRatio { get; set; }
		public Nullable<decimal> PriceRatioToYB { get; set; }
		public string Place { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> InfoSourceCode { get; set; }
		public string ObjectName { get; set; }
	}
}

