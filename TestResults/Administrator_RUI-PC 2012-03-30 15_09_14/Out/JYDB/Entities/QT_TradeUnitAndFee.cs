using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class QT_TradeUnitAndFee
	{
		public long ID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EffectiveDate { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> TradeCode { get; set; }
		public string FullName { get; set; }
		public string SecuAbbr { get; set; }
		public string TradeMarket { get; set; }
		public string RepoObject { get; set; }
		public Nullable<int> Days { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<System.DateTime> DelistDate { get; set; }
		public string OrderUnit { get; set; }
		public Nullable<decimal> MinOrderUnit { get; set; }
		public Nullable<decimal> MaxOrderUnit { get; set; }
		public Nullable<decimal> ParValuePerOrderUnit { get; set; }
		public Nullable<decimal> QuotationSpread { get; set; }
		public Nullable<decimal> StampDuty { get; set; }
		public Nullable<decimal> Commission { get; set; }
		public Nullable<decimal> MinCommission { get; set; }
		public Nullable<decimal> TransferFee { get; set; }
		public Nullable<decimal> MinTransferFee { get; set; }
		public Nullable<decimal> ClearingFee { get; set; }
		public string Currency { get; set; }
		public Nullable<decimal> RegulationFee { get; set; }
		public Nullable<decimal> HandlingCharge { get; set; }
		public System.DateTime XGRQ { get; set; }
	}
}

