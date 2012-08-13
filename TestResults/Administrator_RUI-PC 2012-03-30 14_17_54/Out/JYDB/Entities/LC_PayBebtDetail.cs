using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_PayBebtDetail
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> EventType { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string Debtor { get; set; }
		public string RelationshipStatement { get; set; }
		public Nullable<int> Relationship { get; set; }
		public string PayBebtWayStatement { get; set; }
		public Nullable<decimal> PayBebtSum { get; set; }
		public string PayBebtDateStatement { get; set; }
		public Nullable<System.DateTime> PayBebtEndDate { get; set; }
		public Nullable<int> AnnouncementType { get; set; }
		public string PayBebtDescribe { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

