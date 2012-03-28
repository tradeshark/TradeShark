using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class Fut_TradingQuote
	{
		public long ID { get; set; }
		public int ContractInnerCode { get; set; }
		public System.DateTime TradingDay { get; set; }
		public string ContractCode { get; set; }
		public Nullable<int> ExchangeCode { get; set; }
		public Nullable<int> OptionCode { get; set; }
		public Nullable<int> SeriesFlag { get; set; }
		public Nullable<decimal> PrevSettlePrice { get; set; }
		public Nullable<decimal> PrevClosePrice { get; set; }
		public Nullable<decimal> OpenPrice { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> ClosePrice { get; set; }
		public Nullable<decimal> ChangeOfCTPS { get; set; }
		public Nullable<decimal> ChangePCTCTPS { get; set; }
		public Nullable<decimal> ChangeOfClosePrice { get; set; }
		public Nullable<decimal> ChangePCTClosePrice { get; set; }
		public Nullable<decimal> SettlePrice { get; set; }
		public Nullable<decimal> ChangeOfSettPrice { get; set; }
		public Nullable<decimal> ChangePCTSettPrice { get; set; }
		public Nullable<decimal> OpenInterest { get; set; }
		public Nullable<decimal> ChangeOfOpenInterest { get; set; }
		public Nullable<decimal> ChangePCTOpenInterest { get; set; }
		public Nullable<decimal> TurnoverVolume { get; set; }
		public Nullable<decimal> ChangeOfTurnoverVolume { get; set; }
		public Nullable<decimal> ChangePCTTurnoverVolume { get; set; }
		public Nullable<decimal> TurnoverValue { get; set; }
		public Nullable<decimal> ChangeOfTurnoverValue { get; set; }
		public Nullable<decimal> ChangePCTTurnoverValue { get; set; }
		public Nullable<decimal> BasisValue { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

