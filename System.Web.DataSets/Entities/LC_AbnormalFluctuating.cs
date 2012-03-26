using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_AbnormalFluctuating
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public string InfoSource { get; set; }
		public string AbnormalType { get; set; }
		public System.DateTime TradingStartDate { get; set; }
		public System.DateTime TradingEndDate { get; set; }
		public decimal TurnoverVolume { get; set; }
		public decimal TurnoverSum { get; set; }
		public Nullable<decimal> ChangePCTOffset { get; set; }
		public Nullable<decimal> FluctuatingAmptitude { get; set; }
		public Nullable<decimal> TurnoverRate { get; set; }
		public string SeatName { get; set; }
		public Nullable<decimal> BuySum { get; set; }
		public Nullable<decimal> SaleSum { get; set; }
		public Nullable<int> SecuCoBelonged { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

