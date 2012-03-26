using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_LeaderIntroduce
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string LeaderName { get; set; }
		public Nullable<int> Position { get; set; }
		public Nullable<int> LeaderTitle { get; set; }
		public Nullable<int> TermNumIn { get; set; }
		public Nullable<int> LeaderGender { get; set; }
		public Nullable<System.DateTime> BirthYM { get; set; }
		public Nullable<int> LeaderDegree { get; set; }
		public string Background { get; set; }
		public Nullable<int> IfIn { get; set; }
		public Nullable<System.DateTime> InDate { get; set; }
		public Nullable<System.DateTime> OffDate { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public string BirthYMInfo { get; set; }
		public string ConcurrentPost { get; set; }
	}
}

