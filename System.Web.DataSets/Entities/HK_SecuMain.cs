using System;
using System.Collections.Generic;

namespace System.Web.DataSets.Entities
{
	public class HK_SecuMain
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public Nullable<int> CompanyCode { get; set; }
		public string SecuCode { get; set; }
		public string ChiName { get; set; }
		public string ChiNameAbbr { get; set; }
		public string EngName { get; set; }
		public string EngNameAbbr { get; set; }
		public string SecuAbbr { get; set; }
		public string ChiSpelling { get; set; }
		public Nullable<int> SecuMarket { get; set; }
		public Nullable<int> SecuCategory { get; set; }
		public Nullable<System.DateTime> ListedDate { get; set; }
		public Nullable<int> ListedSector { get; set; }
		public Nullable<int> ListedState { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> DelistingDate { get; set; }
		public string ISIN { get; set; }
		public string FormerName { get; set; }
		public Nullable<decimal> TradingUnit { get; set; }
	}
}

