using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_DInterBank
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> TradeDay { get; set; }
		public Nullable<decimal> PrevWtdAvgPriceCln { get; set; }
		public Nullable<decimal> OpenPriceCln { get; set; }
		public Nullable<decimal> HighPriceCln { get; set; }
		public Nullable<decimal> LowPriceCln { get; set; }
		public Nullable<decimal> ClosePriceCln { get; set; }
		public Nullable<decimal> WtdAvgPriceCln { get; set; }
		public Nullable<decimal> ChangePCTCln { get; set; }
		public Nullable<decimal> PrevWtdAvgPriceDt { get; set; }
		public Nullable<decimal> OpenPriceDt { get; set; }
		public Nullable<decimal> HighPriceDt { get; set; }
		public Nullable<decimal> LowPriceDt { get; set; }
		public Nullable<decimal> ClosePriceDt { get; set; }
		public Nullable<decimal> WtdAvgPriceDt { get; set; }
		public Nullable<decimal> ChangePCTDt { get; set; }
		public Nullable<decimal> SettleVol { get; set; }
		public Nullable<decimal> SettleValue { get; set; }
		public Nullable<int> TransactNum { get; set; }
		public Nullable<decimal> AvgSettleVolPerTransact { get; set; }
		public Nullable<decimal> AccrInterest { get; set; }
		public Nullable<decimal> YrMat { get; set; }
		public Nullable<decimal> AvgYTM { get; set; }
		public Nullable<decimal> RepoIncludeDys { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<int> BondType { get; set; }
	}
}

