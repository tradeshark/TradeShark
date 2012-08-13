using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_FundRating
	{
		public long ID { get; set; }
		public int OrganizationCode { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> FundInnerCode { get; set; }
		public Nullable<int> InvestmentStyle { get; set; }
		public Nullable<decimal> UnitNV { get; set; }
		public Nullable<decimal> WeeklyYield { get; set; }
		public Nullable<decimal> MonthlyYield { get; set; }
		public Nullable<decimal> YieldFor3Month { get; set; }
		public Nullable<decimal> YieldFor6Month { get; set; }
		public Nullable<decimal> YieldFor1year { get; set; }
		public Nullable<decimal> YieldFor2year { get; set; }
		public Nullable<decimal> YieldFor3year { get; set; }
		public Nullable<decimal> YieldFor5year { get; set; }
		public Nullable<decimal> YieldFor10year { get; set; }
		public Nullable<decimal> YieldForThisyear { get; set; }
		public Nullable<decimal> YieldSinceFounded { get; set; }
		public Nullable<int> RatingPeriod { get; set; }
		public Nullable<System.DateTime> EndDateOfRatingPeriod { get; set; }
		public Nullable<decimal> Stdev { get; set; }
		public Nullable<int> StdevEvaluation { get; set; }
		public Nullable<decimal> RiskFactor { get; set; }
		public Nullable<int> RiskEvaluation { get; set; }
		public Nullable<decimal> SharpRatio { get; set; }
		public Nullable<int> SharpRatioEvaluation { get; set; }
		public Nullable<decimal> RatingIndicator { get; set; }
		public Nullable<int> StarRank { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

