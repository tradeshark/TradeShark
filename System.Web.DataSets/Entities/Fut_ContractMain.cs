using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class Fut_ContractMain
	{
		public long ID { get; set; }
		public int ContractInnerCode { get; set; }
		public string ContractCode { get; set; }
		public string ContractName { get; set; }
		public int ExchangeCode { get; set; }
		public Nullable<int> ContractType { get; set; }
		public int OptionCode { get; set; }
		public string ContractMultiplier { get; set; }
		public string PriceUnit { get; set; }
		public string LittlestChangeUnit { get; set; }
		public string ChangePCTLimit { get; set; }
		public Nullable<int> CurrencyCode { get; set; }
		public string DeliveryYear { get; set; }
		public string DeliveryMonth { get; set; }
		public Nullable<System.DateTime> EffectiveDate { get; set; }
		public Nullable<System.DateTime> LastTradingDate { get; set; }
		public Nullable<System.DateTime> DeliveryDate { get; set; }
		public Nullable<System.DateTime> LastDeliveryDate { get; set; }
		public Nullable<int> DeliveryMethod { get; set; }
		public string DeliveryGrades { get; set; }
		public Nullable<decimal> MinMarginRatio { get; set; }
		public string TradingCommission { get; set; }
		public string DeliveryCommission { get; set; }
		public Nullable<int> SettPriceCode { get; set; }
		public string SettPriceDesc { get; set; }
		public Nullable<int> DeliSettPriceCode { get; set; }
		public string DeliSettPriceDesc { get; set; }
		public Nullable<decimal> ListBasisPrice { get; set; }
		public Nullable<decimal> ChangePCTListPrice { get; set; }
		public Nullable<int> ContractState { get; set; }
		public string ChangeReason { get; set; }
		public string ContractMonth { get; set; }
		public string ExchangeDate { get; set; }
		public string LastTradingDateDesc { get; set; }
		public string LastTradingTimeDesc { get; set; }
		public string DeliveryDateDesc { get; set; }
		public string LastDeliveryDateDesc { get; set; }
		public string ContractIntroduction { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
		public Nullable<int> CMValue { get; set; }
		public string ContractAbbr { get; set; }
	}
}

