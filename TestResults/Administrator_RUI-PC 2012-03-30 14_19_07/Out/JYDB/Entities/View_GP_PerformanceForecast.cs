using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_GP_PerformanceForecast
	{
		public string N_ForcastType { get; set; }
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> ForcastType { get; set; }
		public Nullable<int> ForcastReason { get; set; }
		public string ResultStatement { get; set; }
		public string ForcastContent { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

