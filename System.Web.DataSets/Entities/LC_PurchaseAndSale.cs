using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class LC_PurchaseAndSale
	{
		public long ID { get; set; }
		public System.DateTime InfoPublDate { get; set; }
		public string InfoSource { get; set; }
		public System.DateTime EndDate { get; set; }
		public int CompanyCode { get; set; }
		public int DataType { get; set; }
		public int IfMerged { get; set; }
		public Nullable<int> PurchaseType { get; set; }
		public string Company { get; set; }
		public Nullable<int> SN { get; set; }
		public Nullable<decimal> TradeSum { get; set; }
		public Nullable<decimal> RatioInTotal { get; set; }
		public Nullable<decimal> RatioInMainIncome { get; set; }
		public Nullable<decimal> RatioInMainCost { get; set; }
		public string Note { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

