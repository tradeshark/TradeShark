using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_NonOperatingExpense
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> AmercementExpense { get; set; }
		public Nullable<decimal> SubSidyExpense { get; set; }
		public Nullable<decimal> AssetDealLoss { get; set; }
		public Nullable<decimal> CurrentAssetDealLoss { get; set; }
		public Nullable<decimal> FixedAssetDealLoss { get; set; }
		public Nullable<decimal> IntangibleAssetDealLoss { get; set; }
		public Nullable<decimal> AssetDevalueReserve { get; set; }
		public Nullable<decimal> FixedAssetReserve { get; set; }
		public Nullable<decimal> ConstruInProcessReserve { get; set; }
		public Nullable<decimal> IntangibleAssetReserve { get; set; }
		public Nullable<decimal> AccruedDebtAndSecuredLoss { get; set; }
		public Nullable<decimal> AccruedLiability { get; set; }
		public Nullable<decimal> SecurityLoss { get; set; }
		public Nullable<decimal> TaxAndFeeExpense { get; set; }
		public Nullable<decimal> VATExpense { get; set; }
		public Nullable<decimal> DonationExpense { get; set; }
		public Nullable<decimal> OtherNonOperatingExpense { get; set; }
		public Nullable<decimal> DebtRearrangementLoss { get; set; }
		public Nullable<decimal> ExtraordinaryLoss { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

