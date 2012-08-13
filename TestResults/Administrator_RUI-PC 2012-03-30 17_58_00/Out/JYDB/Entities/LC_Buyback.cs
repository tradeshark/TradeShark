using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_Buyback
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime FirstPublDate { get; set; }
		public string InfoSource { get; set; }
		public int ShareType { get; set; }
		public Nullable<System.DateTime> AdvanceDate { get; set; }
		public Nullable<System.DateTime> MeetPassDate { get; set; }
		public Nullable<System.DateTime> WriteOffPublDate { get; set; }
		public Nullable<System.DateTime> ContractDate { get; set; }
		public string Seller { get; set; }
		public Nullable<decimal> BuybackSum { get; set; }
		public Nullable<decimal> Percentage { get; set; }
		public string PricingStatement { get; set; }
		public Nullable<decimal> BuybackPrice { get; set; }
		public Nullable<decimal> BuybackMoney { get; set; }
		public Nullable<System.DateTime> StartDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public Nullable<int> PayMode { get; set; }
		public Nullable<System.DateTime> ChangeDate { get; set; }
		public Nullable<System.DateTime> PayDate { get; set; }
		public Nullable<System.DateTime> ChangeRegDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

