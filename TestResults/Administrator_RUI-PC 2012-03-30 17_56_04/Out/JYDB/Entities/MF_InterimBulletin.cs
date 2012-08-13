using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_InterimBulletin
	{
		public long ID { get; set; }
		public System.DateTime BulletinDate { get; set; }
		public string InfoTitle { get; set; }
		public string Detail { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public Nullable<int> Market { get; set; }
		public string Media { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

