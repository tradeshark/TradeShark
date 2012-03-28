using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_DailyMargin
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int PubOrgCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> TargetCategory { get; set; }
		public Nullable<decimal> DepositRatio { get; set; }
		public Nullable<int> CreditGradeCode { get; set; }
		public string CreditGrade { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

