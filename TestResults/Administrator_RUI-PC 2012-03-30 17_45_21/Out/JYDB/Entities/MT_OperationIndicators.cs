using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MT_OperationIndicators
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public int PubOrgCode { get; set; }
		public System.DateTime ValidDate { get; set; }
		public int IndicatorCode { get; set; }
		public string IndicatorName { get; set; }
		public Nullable<int> IndicatorUnit { get; set; }
		public Nullable<decimal> DataValue { get; set; }
		public Nullable<decimal> RatioValue { get; set; }
		public Nullable<int> CreditGradeCode { get; set; }
		public string CreditGrade { get; set; }
		public string RemarkDesc { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

