using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class MF_AddSize
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> ProspectusIssueDate { get; set; }
		public string IssueObject { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<decimal> UnitPrice { get; set; }
		public string InitiatorQuotaPriceNotes { get; set; }
		public Nullable<decimal> AddShares { get; set; }
		public Nullable<decimal> UnitIsuueFee { get; set; }
		public Nullable<decimal> InitiatorQuota { get; set; }
		public Nullable<decimal> PublicQuota { get; set; }
		public Nullable<decimal> PublicQuotaRatio { get; set; }
		public Nullable<System.DateTime> RegisterDate { get; set; }
		public Nullable<System.DateTime> ExRightDate { get; set; }
		public string AbbrNameForApplying { get; set; }
		public string ApplyingCode { get; set; }
		public Nullable<System.DateTime> PayStartDateForPublic { get; set; }
		public Nullable<System.DateTime> PayEndDateForPublic { get; set; }
		public Nullable<System.DateTime> PayDateForInitiator { get; set; }
		public Nullable<System.DateTime> PayDateForBuyRest { get; set; }
		public Nullable<System.DateTime> PayStartDateForFI { get; set; }
		public Nullable<System.DateTime> PayEndDateForFI { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<decimal> OutstandingShares { get; set; }
		public Nullable<decimal> PublicActualBuyShares { get; set; }
		public Nullable<decimal> FIActualBuyShares { get; set; }
		public Nullable<decimal> InitiatorHoldFloatShares { get; set; }
		public Nullable<decimal> InitiatorHoldTerm { get; set; }
		public Nullable<decimal> MiniInitiatorHoldingRatio { get; set; }
		public Nullable<decimal> SharesAfterAdded { get; set; }
		public Nullable<int> DurationExtended { get; set; }
		public Nullable<int> DurationAfterAdded { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> ExpireDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

