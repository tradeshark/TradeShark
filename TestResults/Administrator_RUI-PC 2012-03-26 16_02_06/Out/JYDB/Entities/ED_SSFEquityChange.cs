using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_SSFEquityChange
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public int IfAdjusted { get; set; }
		public Nullable<decimal> BeginningEquityBalance { get; set; }
		public Nullable<decimal> FundsPayIn { get; set; }
		public Nullable<decimal> FundsPayOut { get; set; }
		public Nullable<decimal> EquityChangeByPayInOrOut { get; set; }
		public Nullable<decimal> OperRevenue { get; set; }
		public Nullable<decimal> OperExpenditure { get; set; }
		public Nullable<decimal> EquityChangeByOper { get; set; }
		public Nullable<decimal> OtherEquityChanges { get; set; }
		public Nullable<decimal> EndingEquityBalance { get; set; }
		public Nullable<decimal> RiskReserveBalance { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

