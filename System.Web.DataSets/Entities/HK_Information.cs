using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class HK_Information
	{
		public long ID { get; set; }
		public string InfoType { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string Media { get; set; }
		public Nullable<int> Category { get; set; }
		public string InfoTitle { get; set; }
		public string Content { get; set; }
		public string Writer { get; set; }
		public string Author { get; set; }
		public Nullable<int> ObjectCode { get; set; }
		public Nullable<int> AreaCode { get; set; }
		public Nullable<int> InvolvedInstitution { get; set; }
		public string Conclusion { get; set; }
		public Nullable<decimal> ForecastLowestPrice { get; set; }
		public Nullable<decimal> ForecastHighestPrice { get; set; }
		public Nullable<int> InfoLevel { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

