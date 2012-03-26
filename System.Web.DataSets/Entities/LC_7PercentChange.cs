using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_7PercentChange
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AbnormalType { get; set; }
		public Nullable<System.DateTime> TradingStartDate { get; set; }
		public System.DateTime TradingDay { get; set; }
		public byte SerialNum { get; set; }
		public string SalesDepartmentName { get; set; }
		public Nullable<int> SecuCoBelongedCode { get; set; }
		public string SecuCoBelonged { get; set; }
		public Nullable<decimal> TurnoverVolume { get; set; }
		public Nullable<decimal> TurnoverValue { get; set; }
		public Nullable<decimal> ChangePCT { get; set; }
		public Nullable<decimal> ChangePCTOffset { get; set; }
		public Nullable<decimal> FluctuatingAmptitude { get; set; }
		public Nullable<decimal> TurnoverRate { get; set; }
		public Nullable<decimal> TotalBuySaleSum { get; set; }
		public Nullable<decimal> BuySum { get; set; }
		public Nullable<decimal> SaleSum { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> StatType { get; set; }
	}
}

