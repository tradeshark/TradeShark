using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_LeaderBywork
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public string LeaderName { get; set; }
		public Nullable<int> Position { get; set; }
		public string EnterpriseBywork { get; set; }
		public Nullable<int> RelaCode { get; set; }
		public Nullable<int> ByworkPosi { get; set; }
		public string TermState { get; set; }
		public Nullable<System.DateTime> StartTime { get; set; }
		public Nullable<System.DateTime> EndTime { get; set; }
		public Nullable<int> IfPay { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

