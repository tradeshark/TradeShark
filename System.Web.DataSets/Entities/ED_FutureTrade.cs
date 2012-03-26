using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_FutureTrade
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> Exchange { get; set; }
		public Nullable<int> Product { get; set; }
		public string SettlementYear { get; set; }
		public string SettlementMonth { get; set; }
		public Nullable<decimal> PrevSettlePrice { get; set; }
		public Nullable<decimal> OpenPrice { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> SettlePrice { get; set; }
		public Nullable<decimal> Volume { get; set; }
		public Nullable<decimal> OpenInterest { get; set; }
		public Nullable<decimal> OpenInterestChange { get; set; }
		public Nullable<decimal> Turnover { get; set; }
		public Nullable<decimal> VolumePeriod { get; set; }
		public Nullable<decimal> VolumePeriodLastYear { get; set; }
		public Nullable<decimal> VolumePeriodLastPeriod { get; set; }
		public Nullable<decimal> TurnoverPeriod { get; set; }
		public Nullable<decimal> TurnoverPeriodLastYear { get; set; }
		public Nullable<decimal> TurnoverPeriodLastPeriod { get; set; }
		public Nullable<decimal> OIEndPeriod { get; set; }
		public Nullable<decimal> OIEndPeriodLastYear { get; set; }
		public Nullable<decimal> OIEndPeriodLastPeriod { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

