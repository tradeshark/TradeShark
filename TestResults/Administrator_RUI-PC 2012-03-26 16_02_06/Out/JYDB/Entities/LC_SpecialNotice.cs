using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SpecialNotice
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> NoticeStartDate { get; set; }
		public Nullable<System.DateTime> NoticeEndDate { get; set; }
		public int NoticeType { get; set; }
		public string Content { get; set; }
		public Nullable<int> SuspendTime { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public string BulletinTypeName { get; set; }
		public Nullable<int> EventType { get; set; }
		public string EventTypeName { get; set; }
	}
}

