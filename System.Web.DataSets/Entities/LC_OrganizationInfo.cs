using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_OrganizationInfo
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string Media { get; set; }
		public string Writer { get; set; }
		public string Author { get; set; }
		public string InfoTitle { get; set; }
		public string Content { get; set; }
		public Nullable<int> OrganizationNum { get; set; }
		public Nullable<int> OrganizationCategory { get; set; }
		public Nullable<int> AreaCode { get; set; }
		public Nullable<int> MarketCode { get; set; }
		public Nullable<int> OpinionCode { get; set; }
		public Nullable<int> InfoLevel { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

