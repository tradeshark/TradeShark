using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Certification
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<int> IfCertified { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> CetificationTime { get; set; }
		public string Organization { get; set; }
		public Nullable<int> CetificationType { get; set; }
		public string ValidTerm { get; set; }
		public Nullable<int> CetificationGrade { get; set; }
		public Nullable<int> CetificationObject { get; set; }
		public string CetificationProject { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

