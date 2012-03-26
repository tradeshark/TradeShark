using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class ED_MoneySupply
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> DataType { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<decimal> M2 { get; set; }
		public Nullable<decimal> M1 { get; set; }
		public Nullable<decimal> M0 { get; set; }
		public Nullable<decimal> DemandDeposits { get; set; }
		public Nullable<decimal> QuasiMoney { get; set; }
		public Nullable<decimal> QMTimeDep { get; set; }
		public Nullable<decimal> QMSavingDep { get; set; }
		public Nullable<decimal> QMOtherDep { get; set; }
		public Nullable<decimal> NetIssueMonthly { get; set; }
		public Nullable<decimal> AvgOfferedRateMonthly { get; set; }
		public Nullable<decimal> OfferedTurnoverMonthly { get; set; }
		public Nullable<decimal> M2GrowthYoY { get; set; }
		public Nullable<decimal> M1GrowthYoY { get; set; }
		public Nullable<decimal> M0GrowthYoY { get; set; }
		public Nullable<decimal> DemandDepositsGrowthYoY { get; set; }
		public Nullable<decimal> QuasiMoneyGrowthYoY { get; set; }
		public Nullable<decimal> QMTimeDepGrowthYoY { get; set; }
		public Nullable<decimal> QMSavingDepGrowthYoY { get; set; }
		public Nullable<decimal> QMOtherDepGrowthYoY { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

