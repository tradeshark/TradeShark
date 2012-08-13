using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class SM_SecuTrading
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> TradingObjects { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> TradingDays { get; set; }
		public Nullable<decimal> StockTurnover { get; set; }
		public Nullable<decimal> StockTurnover_Daily { get; set; }
		public Nullable<decimal> StockTradingVolume { get; set; }
		public Nullable<decimal> StockTradingVolume_Daily { get; set; }
		public Nullable<decimal> TransactionNum { get; set; }
		public Nullable<decimal> TransactionNum_Daily { get; set; }
		public Nullable<decimal> StampDuty { get; set; }
		public Nullable<decimal> ASharePE { get; set; }
		public Nullable<decimal> BSharePE { get; set; }
		public Nullable<decimal> AShareTurnoverRate { get; set; }
		public Nullable<decimal> BShareTurnoverRate { get; set; }
		public Nullable<decimal> StockTurnoverChangePCT_YoY { get; set; }
		public Nullable<decimal> StockTurnoverDChangePCT_YoY { get; set; }
		public Nullable<decimal> StockTradVolChangePCT_YoY { get; set; }
		public Nullable<decimal> StockTradVolDChangePCT_YoY { get; set; }
		public Nullable<decimal> TransactNumChangePCT_YoY { get; set; }
		public Nullable<decimal> TransactNumDChangePCT_YoY { get; set; }
		public Nullable<decimal> StampDutyChangePCT_YoY { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

