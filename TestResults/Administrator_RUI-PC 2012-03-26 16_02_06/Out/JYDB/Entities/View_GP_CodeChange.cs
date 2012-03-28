using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_GP_CodeChange
	{
		public string SecuAbbr { get; set; }
		public string NewCode { get; set; }
		public string OldCode { get; set; }
		public long ID { get; set; }
		public string SecuCode { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public Nullable<int> CodeDefine { get; set; }
		public int InnerCode { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> BeginDate { get; set; }
		public Nullable<System.DateTime> StopDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

