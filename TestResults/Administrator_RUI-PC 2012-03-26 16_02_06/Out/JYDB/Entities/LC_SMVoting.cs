using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_SMVoting
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<int> TitleSN { get; set; }
		public string Title { get; set; }
		public Nullable<int> SubtitleSN { get; set; }
		public string Subtitle { get; set; }
		public Nullable<int> IfConnectedTransaction { get; set; }
		public Nullable<int> ProposalType { get; set; }
		public Nullable<int> IfPassed { get; set; }
		public Nullable<decimal> SharesAvoiding { get; set; }
		public Nullable<decimal> SharesApprovedASH { get; set; }
		public Nullable<decimal> RatioApprovedASH { get; set; }
		public Nullable<decimal> SharesOpposedASH { get; set; }
		public Nullable<decimal> RatioOpposedASH { get; set; }
		public Nullable<decimal> SharesDisclaimedASH { get; set; }
		public Nullable<decimal> RatioDisclaimedASH { get; set; }
		public Nullable<decimal> SharesApprovedNTSH { get; set; }
		public Nullable<decimal> RatioApprovedNTSH { get; set; }
		public Nullable<decimal> SharesOpposedNTSH { get; set; }
		public Nullable<decimal> RatioOpposedNTSH { get; set; }
		public Nullable<decimal> SharesDisclaimedNTSH { get; set; }
		public Nullable<decimal> RatioDisclaimedNTSH { get; set; }
		public Nullable<decimal> SharesApprovedTSH { get; set; }
		public Nullable<decimal> RatioApprovedTSH { get; set; }
		public Nullable<decimal> ASharesApprovedTSH { get; set; }
		public Nullable<decimal> BSharesApprovedTSH { get; set; }
		public Nullable<decimal> HSharesApprovedTSH { get; set; }
		public Nullable<decimal> OSharesApprovedTSH { get; set; }
		public Nullable<decimal> SharesOpposedTSH { get; set; }
		public Nullable<decimal> RatioOpposedTSH { get; set; }
		public Nullable<decimal> ASharesOpposedTSH { get; set; }
		public Nullable<decimal> BSharesOpposedTSH { get; set; }
		public Nullable<decimal> HSharesOpposedTSH { get; set; }
		public Nullable<decimal> OSharesOpposedTSH { get; set; }
		public Nullable<decimal> SharesDisclaimedTSH { get; set; }
		public Nullable<decimal> RatioDisclaimedTSH { get; set; }
		public Nullable<decimal> ASharesDisclaimedTSH { get; set; }
		public Nullable<decimal> BSharesDisclaimedTSH { get; set; }
		public Nullable<decimal> HSharesDisclaimedTSH { get; set; }
		public Nullable<decimal> OSharesDisclaimedTSH { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

