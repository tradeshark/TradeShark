using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class View_QZ_Trade
	{
		public string SecuCode { get; set; }
		public string SecuAbbr { get; set; }
		public string N_ChangeReason { get; set; }
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EffectiveDate { get; set; }
		public Nullable<decimal> Circulation { get; set; }
		public Nullable<decimal> ExercisePrice { get; set; }
		public Nullable<decimal> ExerciseRate { get; set; }
		public Nullable<int> ExercisedWarrant { get; set; }
		public Nullable<int> ExercisedShare { get; set; }
		public Nullable<int> ChangeReason { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> CreationCirculation { get; set; }
		public Nullable<decimal> ExercisedSharesAdded { get; set; }
		public Nullable<decimal> ExercisedSharesCurrent { get; set; }
		public Nullable<decimal> NonListedShares { get; set; }
	}
}

