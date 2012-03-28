using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class MF_Dividend
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<decimal> UnitProfit { get; set; }
		public Nullable<decimal> UnitRetainedProfit { get; set; }
		public Nullable<byte> IfDistributed { get; set; }
		public Nullable<decimal> DividendRatioBeforeTax { get; set; }
		public Nullable<decimal> ActualRatioAfterTax { get; set; }
		public Nullable<decimal> Dividendsum { get; set; }
		public Nullable<System.DateTime> ReDate { get; set; }
		public Nullable<System.DateTime> ExRightDate { get; set; }
		public Nullable<System.DateTime> ExecuteDate { get; set; }
		public string SchemeModification { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> ReinvestDay { get; set; }
		public Nullable<System.DateTime> AccountDay { get; set; }
		public Nullable<System.DateTime> RedemptionDay { get; set; }
		public Nullable<decimal> UnitProfitYTD { get; set; }
		public Nullable<decimal> DividendSumYTD { get; set; }
		public Nullable<int> DividendTimesYTD { get; set; }
		public Nullable<decimal> DiviSumSinceInception { get; set; }
		public Nullable<int> DiviTimesSinceIncepion { get; set; }
		public Nullable<int> EventProcedureCode { get; set; }
		public string EventProcedure { get; set; }
		public Nullable<System.DateTime> ExRightDateEX { get; set; }
		public Nullable<System.DateTime> ExRightDateCurbEX { get; set; }
	}
}

