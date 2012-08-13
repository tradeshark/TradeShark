using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class BD_ConvertPriceOfCB
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<System.DateTime> ValidDate { get; set; }
		public Nullable<int> ConvertPriceType { get; set; }
		public Nullable<decimal> ConvertPrice { get; set; }
		public Nullable<decimal> Dilution { get; set; }
		public Nullable<int> ChangeReason { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

