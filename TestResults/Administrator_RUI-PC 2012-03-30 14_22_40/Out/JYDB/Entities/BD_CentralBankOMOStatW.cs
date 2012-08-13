using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_CentralBankOMOStatW
	{
		public long ID { get; set; }
		public System.DateTime WeekStart { get; set; }
		public System.DateTime WeekEnd { get; set; }
		public Nullable<decimal> IssueSizeTreasNotes { get; set; }
		public Nullable<decimal> RepurchaseBuySize { get; set; }
		public Nullable<decimal> RepurchaseSellSize { get; set; }
		public Nullable<decimal> SpotSellSize { get; set; }
		public Nullable<decimal> SpotBuySize { get; set; }
		public Nullable<decimal> RedemptionTreasNotes { get; set; }
		public Nullable<decimal> RepurchaseBuyExpire { get; set; }
		public Nullable<decimal> RepurchaseSellExpire { get; set; }
		public Nullable<decimal> NetCurrencyIssue { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

