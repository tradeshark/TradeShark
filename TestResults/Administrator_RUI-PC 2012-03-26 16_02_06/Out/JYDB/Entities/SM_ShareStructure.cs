using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class SM_ShareStructure
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public string DataTypeName { get; set; }
		public Nullable<int> DataType { get; set; }
		public Nullable<decimal> SponsorLegalPersonShares { get; set; }
		public Nullable<decimal> StateOwnedShares { get; set; }
		public Nullable<decimal> DomLegalPersonShares { get; set; }
		public Nullable<decimal> ForLegalPersonShares { get; set; }
		public Nullable<decimal> OtherLegalPersonShares { get; set; }
		public Nullable<decimal> PrivPlaceLegalPersonShares { get; set; }
		public Nullable<decimal> StaffShares { get; set; }
		public Nullable<decimal> AlterRightIssueShares { get; set; }
		public Nullable<decimal> FormerOTCNonnegotiableShares { get; set; }
		public Nullable<decimal> SpecificallyIssueSharesFund { get; set; }
		public Nullable<decimal> StratagemInvestorsShares { get; set; }
		public Nullable<decimal> OtherNonnegotiableShares { get; set; }
		public Nullable<decimal> TotalNonnegotiableShares { get; set; }
		public Nullable<decimal> A_Shares { get; set; }
		public Nullable<decimal> B_Shares { get; set; }
		public Nullable<decimal> H_Shares { get; set; }
		public Nullable<decimal> OtherNegotiableShares { get; set; }
		public Nullable<decimal> TotalNegotiableShares { get; set; }
		public Nullable<decimal> TotalCapital { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

