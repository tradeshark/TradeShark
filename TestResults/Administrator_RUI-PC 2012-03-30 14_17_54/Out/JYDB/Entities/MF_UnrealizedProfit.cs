using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_UnrealizedProfit
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime ReportDate { get; set; }
		public Nullable<decimal> UnrealizedProfitAtBegin { get; set; }
		public Nullable<decimal> EstimatedIncrementAtBegin { get; set; }
		public Nullable<decimal> UnrealizedProfitBufferAtBegin { get; set; }
		public Nullable<decimal> EstimatedIncrementChange { get; set; }
		public Nullable<decimal> ApplyingMoney { get; set; }
		public Nullable<decimal> DividendReinvestment { get; set; }
		public Nullable<decimal> RedemptionMoney { get; set; }
		public Nullable<decimal> OtherBufferMoney { get; set; }
		public Nullable<decimal> UnrealizedProfitAtEnd { get; set; }
		public Nullable<decimal> EstimatedIncrementAtEnd { get; set; }
		public Nullable<decimal> UnrealizedProfitBufferAtEnd { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

