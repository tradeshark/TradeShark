using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_SplitCombinationShare
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> DirDeciPublDate { get; set; }
		public Nullable<System.DateTime> DirDeciSignDate { get; set; }
		public Nullable<System.DateTime> SMDeciDate { get; set; }
		public Nullable<System.DateTime> CircularPunlDate { get; set; }
		public Nullable<System.DateTime> ExpirePublDate { get; set; }
		public Nullable<System.DateTime> EffectDate { get; set; }
		public string SchemeStatement { get; set; }
		public Nullable<int> SupplementaryType { get; set; }
		public Nullable<int> Process { get; set; }
		public Nullable<int> ReformType { get; set; }
		public Nullable<int> CombinationX { get; set; }
		public Nullable<int> CombinationY { get; set; }
		public Nullable<int> SplitX { get; set; }
		public Nullable<int> SplitY { get; set; }
		public Nullable<int> CurrencyUnit { get; set; }
		public Nullable<decimal> OldParValue { get; set; }
		public Nullable<decimal> NewParValue { get; set; }
		public Nullable<int> WriteOffBase { get; set; }
		public Nullable<decimal> WriteOffParValue { get; set; }
		public Nullable<int> OldTradeUnit { get; set; }
		public Nullable<int> NewTradeUnit { get; set; }
		public Nullable<decimal> SharesIssued { get; set; }
		public Nullable<decimal> SharesAfterEffect { get; set; }
		public string TempShareCode { get; set; }
		public string TempShareAbbrName { get; set; }
		public Nullable<int> TempTradeUnit { get; set; }
		public Nullable<System.DateTime> TempTradeBeginDate { get; set; }
		public Nullable<System.DateTime> SimulTradeBeginDate { get; set; }
		public Nullable<System.DateTime> SimulTradeEndDate { get; set; }
		public string OddLotsTradeAgent { get; set; }
		public Nullable<int> AgentCode { get; set; }
		public string AgentTel { get; set; }
		public string AgentAddr { get; set; }
		public Nullable<System.DateTime> OddLotsTradeBeginDate { get; set; }
		public Nullable<System.DateTime> OddLotsTradeEndDate { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

