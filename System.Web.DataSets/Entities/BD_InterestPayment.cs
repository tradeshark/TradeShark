using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class BD_InterestPayment
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string FullName { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public string PaymentYear { get; set; }
		public Nullable<int> Number { get; set; }
		public Nullable<decimal> BaseSize { get; set; }
		public System.DateTime ValueDatePer { get; set; }
		public Nullable<System.DateTime> ValueDateNextPer { get; set; }
		public Nullable<decimal> CouponRatePer { get; set; }
		public Nullable<decimal> FRNRefRatePer { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<System.DateTime> RegDate { get; set; }
		public Nullable<System.DateTime> ExDividendDate { get; set; }
		public Nullable<System.DateTime> PaymentDate { get; set; }
		public Nullable<decimal> Interest { get; set; }
		public Nullable<decimal> InterestDeductedTax { get; set; }
		public Nullable<decimal> InterestTaxRate { get; set; }
		public Nullable<decimal> CouponRateNextPer { get; set; }
		public Nullable<decimal> FRNRefRateNextPer { get; set; }
		public Nullable<int> AccumulatedPaymentNum { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

