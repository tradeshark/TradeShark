using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_Buyback
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> PublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public Nullable<int> ShareTypeCode { get; set; }
		public string ShareType { get; set; }
		public Nullable<int> ParValueCode { get; set; }
		public string ParValueUnit { get; set; }
		public Nullable<decimal> ParValue { get; set; }
		public Nullable<decimal> BuybackSum { get; set; }
		public Nullable<decimal> HighPrice { get; set; }
		public Nullable<decimal> LowPrice { get; set; }
		public Nullable<decimal> BuybackMoney { get; set; }
		public Nullable<decimal> CumulativeSum { get; set; }
		public Nullable<decimal> CumulativeSumToTS { get; set; }
		public string MethodStatement { get; set; }
		public System.DateTime UpdateTime { get; set; }
		public long JSID { get; set; }
	}
}

