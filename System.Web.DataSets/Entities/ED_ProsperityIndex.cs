using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_ProsperityIndex
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSources { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> Category { get; set; }
		public Nullable<decimal> Total { get; set; }
		public Nullable<decimal> Industry { get; set; }
		public Nullable<decimal> Construction { get; set; }
		public Nullable<decimal> TrafficStoragePostTelecom { get; set; }
		public Nullable<decimal> WRTradeFoodBeverage { get; set; }
		public Nullable<decimal> WholesaleRetail { get; set; }
		public Nullable<decimal> HotelFoodBeverage { get; set; }
		public Nullable<decimal> RealEstate { get; set; }
		public Nullable<decimal> SocialService { get; set; }
		public Nullable<decimal> InfoComputerSoftware { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

