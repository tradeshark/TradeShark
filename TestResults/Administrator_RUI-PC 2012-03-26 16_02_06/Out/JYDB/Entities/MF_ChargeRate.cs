using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class MF_ChargeRate
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<byte> IfExecuted { get; set; }
		public Nullable<System.DateTime> ExcuteDate { get; set; }
		public Nullable<System.DateTime> CancelDate { get; set; }
		public Nullable<int> ChargeRateType { get; set; }
		public Nullable<int> ChargePattern { get; set; }
		public string TermMarkUnit { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public Nullable<decimal> BeginOfApplySumInterval { get; set; }
		public Nullable<decimal> EndOfApplySumInterval { get; set; }
		public Nullable<int> BeginOfHoldTermInterval { get; set; }
		public Nullable<int> EndOfHoldTermInterval { get; set; }
		public Nullable<int> BeginOfTranTimesInterval { get; set; }
		public Nullable<int> EndOfTranTimesInterval { get; set; }
		public Nullable<decimal> MinimumChargeRate { get; set; }
		public Nullable<decimal> MaximumChargeRate { get; set; }
		public string Notes { get; set; }
		public string ChargeRateDesciption { get; set; }
		public string IntervalDescription { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<byte> IfApplyBegin { get; set; }
		public Nullable<byte> IfApplyEnd { get; set; }
		public Nullable<byte> IfHoldBegin { get; set; }
		public Nullable<byte> IfHoldEnd { get; set; }
	}
}

