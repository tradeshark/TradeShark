using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_Staff
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public string MergeMark { get; set; }
		public Nullable<int> ClassfiedMethod { get; set; }
		public string TypeName { get; set; }
		public Nullable<short> YoungestAge { get; set; }
		public Nullable<short> OldestAge { get; set; }
		public Nullable<int> EmployeeSum { get; set; }
		public Nullable<decimal> RatioInSum { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> TypeCode { get; set; }
	}
}

