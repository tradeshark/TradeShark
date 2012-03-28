using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_InterimBulletin
	{
		public long ID { get; set; }
		public System.DateTime BulletinDate { get; set; }
		public string InfoTitle { get; set; }
		public string Detail { get; set; }
		public Nullable<int> BulletinType { get; set; }
		public Nullable<int> Market { get; set; }
		public Nullable<int> Category { get; set; }
		public Nullable<int> Media { get; set; }
		public Nullable<int> InvolvedStock { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
	}
}

