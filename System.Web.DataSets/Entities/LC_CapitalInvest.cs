using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_CapitalInvest
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPunlDate { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> RaisingMethod { get; set; }
		public string InvestProject { get; set; }
		public string ProjectStatement { get; set; }
		public Nullable<decimal> PlannedSum { get; set; }
		public Nullable<System.DateTime> ActualInvestEndDate { get; set; }
		public Nullable<decimal> ActualSum { get; set; }
		public Nullable<int> Industry { get; set; }
		public Nullable<int> InvestField { get; set; }
		public string ProceedingStatement { get; set; }
		public Nullable<int> IfSwitched { get; set; }
		public string ProjectSwitchedTo { get; set; }
		public Nullable<decimal> SumSwitched { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> InnerCode { get; set; }
		public Nullable<int> PurchaseType { get; set; }
		public Nullable<decimal> BookValue { get; set; }
		public Nullable<decimal> AppraisalValue { get; set; }
		public Nullable<decimal> PurchasePrice { get; set; }
		public Nullable<decimal> EquityRatio { get; set; }
		public string Transferor { get; set; }
		public Nullable<int> Relationship { get; set; }
		public Nullable<int> InvolvedStock { get; set; }
		public Nullable<int> TransferorNature { get; set; }
		public string TargetName { get; set; }
		public Nullable<int> TargetNature { get; set; }
	}
}

