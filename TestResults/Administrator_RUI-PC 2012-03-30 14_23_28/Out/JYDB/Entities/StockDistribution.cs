using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class StockDistribution
	{
		public string id { get; set; }
		public string StockCode { get; set; }
		public string DistributeType { get; set; }
		public Nullable<decimal> Ratio { get; set; }
		public Nullable<decimal> Price { get; set; }
		public string DistributeTarget { get; set; }
		public Nullable<System.DateTime> NoticeDate { get; set; }
		public Nullable<System.DateTime> DeclareDate { get; set; }
		public Nullable<System.DateTime> AdvanceDate { get; set; }
		public Nullable<System.DateTime> MeetDate { get; set; }
		public Nullable<System.DateTime> AllowDate { get; set; }
		public Nullable<System.DateTime> RecordDate { get; set; }
		public Nullable<System.DateTime> EXDate { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<System.DateTime> FirstTradingDate { get; set; }
		public string RightsIssueMeans { get; set; }
		public string Underwriter { get; set; }
		public string UnderrightMode { get; set; }
		public string Seller { get; set; }
		public Nullable<decimal> PlannedVolumeOfRights { get; set; }
		public Nullable<decimal> ActualVolumeOfRights { get; set; }
		public Nullable<decimal> ExclusiveSale { get; set; }
		public Nullable<decimal> ActualValueOfRights { get; set; }
		public Nullable<System.DateTime> DistributeYear { get; set; }
		public string ResultType { get; set; }
		public Nullable<decimal> RePrice { get; set; }
		public string Notes { get; set; }
		public Nullable<System.DateTime> UpdateTime { get; set; }
		public Nullable<decimal> ActFlowRights { get; set; }
		public Nullable<decimal> BaseShares { get; set; }
		public Nullable<decimal> DisFee { get; set; }
	}
}

