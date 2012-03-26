using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class HK_LeaderPosition
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<int> LeaderID { get; set; }
		public string LeaderName { get; set; }
		public string PositionName { get; set; }
		public Nullable<int> Position { get; set; }
		public Nullable<System.DateTime> InDate { get; set; }
		public Nullable<System.DateTime> OffDate { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public string ChangeReason { get; set; }
		public Nullable<int> IfIn { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> PositionType { get; set; }
	}
}

