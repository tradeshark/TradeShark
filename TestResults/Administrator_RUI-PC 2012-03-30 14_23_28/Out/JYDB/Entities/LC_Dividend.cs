using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Dividend
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> IfDividend { get; set; }
		public Nullable<System.DateTime> AdvanceDate { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<decimal> EPS { get; set; }
		public Nullable<decimal> BonusShareRatio { get; set; }
		public Nullable<decimal> TranAddShareRaio { get; set; }
		public Nullable<int> PriceUnit { get; set; }
		public Nullable<decimal> CashDiviRMB { get; set; }
		public Nullable<decimal> ActualCashDiviRMB { get; set; }
		public Nullable<decimal> CashDiviFC { get; set; }
		public Nullable<decimal> ActualCashDiviFC { get; set; }
		public Nullable<System.DateTime> RightRegDate { get; set; }
		public Nullable<System.DateTime> ExDiviDate { get; set; }
		public Nullable<System.DateTime> BonusShareListDate { get; set; }
		public Nullable<System.DateTime> ToAccountDate { get; set; }
		public Nullable<System.DateTime> FinalTradingDay { get; set; }
		public Nullable<decimal> DiviBase { get; set; }
		public Nullable<decimal> SharesAfterDivi { get; set; }
		public Nullable<int> DiviObject { get; set; }
		public Nullable<decimal> TotalCashDiviComRMB { get; set; }
		public Nullable<decimal> TotalCashDiviComFC { get; set; }
		public Nullable<decimal> CashDiviAShare { get; set; }
		public Nullable<decimal> CashDiviBShareRMB { get; set; }
		public Nullable<decimal> CashDiviBShareFC { get; set; }
		public Nullable<System.DateTime> DiviStartDate { get; set; }
		public Nullable<int> IFSchemeChange { get; set; }
		public string ChangeStatement { get; set; }
		public Nullable<int> ChangeType { get; set; }
		public Nullable<int> IfDiviBeforeChange { get; set; }
		public Nullable<decimal> BonusShareRatioBeforeChange { get; set; }
		public Nullable<decimal> TranAddShareRatioBeforeChange { get; set; }
		public Nullable<decimal> CashDiviBeforeChangeRMB { get; set; }
		public Nullable<decimal> CashDiviBeforeChangeFC { get; set; }
		public Nullable<decimal> DiviBaseBeforeChange { get; set; }
		public string Notes { get; set; }
		public string UndistributeStatement { get; set; }
		public string DistributeTimes { get; set; }
		public Nullable<decimal> CeilingNext { get; set; }
		public Nullable<decimal> FloorNext { get; set; }
		public Nullable<decimal> Ceiling { get; set; }
		public Nullable<decimal> Floor { get; set; }
		public Nullable<int> MainForm { get; set; }
		public Nullable<decimal> CashDiviCeiling { get; set; }
		public Nullable<decimal> CashDiviFloor { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> DiviEndDate { get; set; }
		public Nullable<System.DateTime> DividendImplementDate { get; set; }
		public Nullable<int> EventProcedure { get; set; }
		public string EventProcedureDesc { get; set; }
	}
}

