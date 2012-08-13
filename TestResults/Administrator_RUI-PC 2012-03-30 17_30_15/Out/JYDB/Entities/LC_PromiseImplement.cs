using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_PromiseImplement
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> PromiseSubject { get; set; }
		public Nullable<int> EventType { get; set; }
		public Nullable<int> InfoType { get; set; }
		public Nullable<int> SHSN { get; set; }
		public string SHName { get; set; }
		public Nullable<int> CompanyNumber { get; set; }
		public Nullable<int> PromiseType { get; set; }
		public Nullable<System.DateTime> ImplementStartDate { get; set; }
		public Nullable<System.DateTime> ImplementEndDate { get; set; }
		public Nullable<decimal> TriggerPrice { get; set; }
		public Nullable<decimal> ImplementPrice { get; set; }
		public Nullable<System.DateTime> EffectiveDate { get; set; }
		public Nullable<int> ChangeReason { get; set; }
		public string PromiseStatement { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> IfImplemented { get; set; }
		public Nullable<int> Reason { get; set; }
		public string ImplementStatement { get; set; }
		public Nullable<decimal> ImplementShares { get; set; }
		public Nullable<decimal> ImplementMoney { get; set; }
		public Nullable<decimal> ImplementSharesTotal { get; set; }
		public Nullable<decimal> ImplementMoneyTotal { get; set; }
		public Nullable<decimal> ImplementPriceBottom { get; set; }
		public Nullable<decimal> ImplementPriceCeiling { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

