using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class SM_SecuMarketInfo
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> TotalMarketCapitalization { get; set; }
		public Nullable<decimal> NegotiableCapitalization { get; set; }
		public Nullable<decimal> TotalCapital { get; set; }
		public Nullable<decimal> TotalRaisedCapital { get; set; }
		public Nullable<decimal> StockTurnover { get; set; }
		public Nullable<decimal> TotalInvestors { get; set; }
		public Nullable<decimal> StampDuty { get; set; }
		public Nullable<int> AShareIssueNum { get; set; }
		public Nullable<int> AShareIssueNumIPO { get; set; }
		public Nullable<int> AShareIssueNumRe { get; set; }
		public Nullable<int> AShareIssueNumRight { get; set; }
		public Nullable<int> CBIssueNum { get; set; }
		public Nullable<int> BShareIssueNum { get; set; }
		public Nullable<int> BShareIssueNumIPO { get; set; }
		public Nullable<int> BShareIssueNumRe { get; set; }
		public Nullable<int> HShareIssueNum { get; set; }
		public Nullable<int> HShareIssueNumIPO { get; set; }
		public Nullable<int> HShareIssueNumRe { get; set; }
		public Nullable<decimal> AShareRaisedCapital { get; set; }
		public Nullable<decimal> AShareRaisedCapitalIPO { get; set; }
		public Nullable<decimal> AShareRaisedCapitalRe { get; set; }
		public Nullable<decimal> AShareRaisedCapitalRight { get; set; }
		public Nullable<decimal> CBRaisedCapital { get; set; }
		public Nullable<decimal> BShareRaisedCapital { get; set; }
		public Nullable<decimal> BShareRaisedCapitalIPO { get; set; }
		public Nullable<decimal> BShareRaisedCapitalRe { get; set; }
		public Nullable<decimal> HShareRaisedCapital { get; set; }
		public Nullable<decimal> HShareRaisedCapitalIPO { get; set; }
		public Nullable<decimal> HShareRaisedCapitalRe { get; set; }
		public Nullable<decimal> AShareIssueVolume { get; set; }
		public Nullable<decimal> AShareIssueVolumeIPO { get; set; }
		public Nullable<decimal> AShareIssueVolumeRe { get; set; }
		public Nullable<decimal> AShareIssueVolumeRight { get; set; }
		public Nullable<decimal> CBIssueVolume { get; set; }
		public Nullable<decimal> BShareIssueVolume { get; set; }
		public Nullable<decimal> BShareIssueVolumeIPO { get; set; }
		public Nullable<decimal> BShareIssueVolumeRe { get; set; }
		public Nullable<decimal> HShareIssueVolume { get; set; }
		public Nullable<decimal> HShareIssueVolumeIPO { get; set; }
		public Nullable<decimal> HShareIssueVolumeRe { get; set; }
		public Nullable<int> AorBShareListedNum { get; set; }
		public Nullable<int> Bshares { get; set; }
		public Nullable<int> Hshares { get; set; }
		public Nullable<int> ASharesOnly { get; set; }
		public Nullable<int> BSharesOnly { get; set; }
		public Nullable<int> HSharesOnly { get; set; }
		public Nullable<int> AandBShares { get; set; }
		public Nullable<int> AandHShares { get; set; }
		public Nullable<int> HSharesTotalNum { get; set; }
		public Nullable<int> HShareOnlyNum { get; set; }
		public Nullable<int> AandHSharesNum { get; set; }
		public Nullable<int> HShareUSAOnly { get; set; }
		public Nullable<int> HShareLondonOnly { get; set; }
		public Nullable<int> HShareSingaporeOnly { get; set; }
		public Nullable<int> HShareHKOnly { get; set; }
		public Nullable<int> HShareHKandUSA { get; set; }
		public Nullable<int> HShareHKandLondon { get; set; }
		public Nullable<int> HShareHKandSingapore { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

