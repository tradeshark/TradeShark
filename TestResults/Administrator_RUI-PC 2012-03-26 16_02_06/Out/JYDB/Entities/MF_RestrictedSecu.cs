using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_RestrictedSecu
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> SecuSpecies { get; set; }
		public Nullable<int> SerialNumber { get; set; }
		public string StockInnerCode { get; set; }
		public Nullable<System.DateTime> ObtainDate { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<System.DateTime> RestrictedTerm { get; set; }
		public Nullable<decimal> ObtainPrice { get; set; }
		public Nullable<decimal> SharesHolding { get; set; }
		public Nullable<decimal> ObtainCost { get; set; }
		public Nullable<decimal> MarketValue { get; set; }
		public Nullable<decimal> ReportDateValue { get; set; }
		public string ObtainReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> SuspendDate { get; set; }
		public string SuspendReason { get; set; }
		public Nullable<System.DateTime> ResumptionDate { get; set; }
		public Nullable<decimal> ResumptionOpenPrice { get; set; }
		public Nullable<int> RestrictedType { get; set; }
		public Nullable<System.DateTime> RepurchaseExpireDate { get; set; }
	}
}

