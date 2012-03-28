using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_VATPayable
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string IfMerged { get; set; }
		public Nullable<decimal> UndeductedAtBegin { get; set; }
		public Nullable<decimal> VATOnSales { get; set; }
		public Nullable<decimal> ExportRefundVAT { get; set; }
		public Nullable<decimal> PurchaseTransOutVAT { get; set; }
		public Nullable<decimal> TransOutOverpaidVAT { get; set; }
		public Nullable<decimal> VATOnPurchase { get; set; }
		public Nullable<decimal> VATPaid { get; set; }
		public Nullable<decimal> TaxReducedExempted { get; set; }
		public Nullable<decimal> ExportOffsetVATPayable { get; set; }
		public Nullable<decimal> TransOutUpaidVAT { get; set; }
		public Nullable<decimal> UndeductedAtEnd { get; set; }
		public Nullable<decimal> UnpaidAtBegin { get; set; }
		public Nullable<decimal> AmountTransIn { get; set; }
		public Nullable<decimal> AmountPaid { get; set; }
		public Nullable<decimal> UnpaidAtEnd { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

