using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_ExecutivesHoldings
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> SequenceNumber { get; set; }
		public string LeaderName { get; set; }
		public Nullable<int> Position { get; set; }
		public Nullable<int> ShareAmount { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<decimal> AnnualReward { get; set; }
		public Nullable<int> IfIn { get; set; }
		public string OffStatement { get; set; }
		public string PositionDescription { get; set; }
		public Nullable<int> ShareAmountBeginning { get; set; }
		public Nullable<int> IndirectShares { get; set; }
		public string ChangeReason { get; set; }
		public Nullable<decimal> Subsidy { get; set; }
		public Nullable<int> SharesExercisable { get; set; }
		public Nullable<int> SharesExercised { get; set; }
		public Nullable<decimal> ExercisePrice { get; set; }
		public Nullable<decimal> EndingMarketPrice { get; set; }
	}
}

