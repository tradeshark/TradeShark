using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_WagesEmployment
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string Sources { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Country { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<decimal> TotalEmployee { get; set; }
		public Nullable<decimal> SOEEmployee { get; set; }
		public Nullable<decimal> TCEEmployee { get; set; }
		public Nullable<decimal> OtherEmployee { get; set; }
		public Nullable<decimal> TotalLarborPartcipants { get; set; }
		public Nullable<decimal> SOELarborPartcipants { get; set; }
		public Nullable<decimal> TCELarborPartcipants { get; set; }
		public Nullable<decimal> OtherLarborPartcipants { get; set; }
		public Nullable<decimal> TotalEmployeedWages { get; set; }
		public Nullable<decimal> TotalSOEEmployeeWages { get; set; }
		public Nullable<decimal> TotalTCEEmployeeWages { get; set; }
		public Nullable<decimal> TotalOtherEmployeeWages { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

