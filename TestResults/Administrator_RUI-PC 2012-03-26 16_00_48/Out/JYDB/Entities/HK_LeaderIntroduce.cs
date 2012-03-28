using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_LeaderIntroduce
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<int> LeaderID { get; set; }
		public string LeaderName { get; set; }
		public Nullable<int> LeaderGender { get; set; }
		public Nullable<System.DateTime> BirthYM { get; set; }
		public Nullable<int> Age { get; set; }
		public Nullable<int> LeaderDegree { get; set; }
		public Nullable<int> LeaderTitle { get; set; }
		public Nullable<System.DateTime> EarliestInDate { get; set; }
		public string Background { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public string BirthYMInfo { get; set; }
	}
}

