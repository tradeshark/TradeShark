using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class BD_CentralBankNotesIssue
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> IssueDate { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> IssueMethod { get; set; }
		public Nullable<decimal> ActualIssueSize { get; set; }
		public Nullable<decimal> Maturity { get; set; }
		public Nullable<decimal> IssuePrice { get; set; }
		public Nullable<decimal> IssueRefYTM { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

