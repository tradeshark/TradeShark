using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class HK_CorporationEquity
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
		public Nullable<System.DateTime> EndDate { get; set; }
		public string InfoSource { get; set; }
		public string DirectorName { get; set; }
		public string CorporationName { get; set; }
		public Nullable<int> EquityType { get; set; }
		public Nullable<int> EquityCharacter { get; set; }
		public Nullable<int> Unit { get; set; }
		public Nullable<int> EquityStatus { get; set; }
		public string EquityStatusDesc { get; set; }
		public Nullable<int> RelatingEquityStatus { get; set; }
		public string RelatingEquityStatusDesc { get; set; }
		public Nullable<decimal> EquityVolume { get; set; }
		public Nullable<decimal> RatioInTotalShares { get; set; }
		public Nullable<decimal> HoldSum { get; set; }
		public Nullable<decimal> HSInTotalShares { get; set; }
		public Nullable<decimal> PersonalEquity { get; set; }
		public Nullable<decimal> FamilyEquity { get; set; }
		public Nullable<decimal> CompanyEquity { get; set; }
		public Nullable<decimal> OtherEquity { get; set; }
		public Nullable<decimal> RelatingEquityHoldSum { get; set; }
		public Nullable<decimal> REHSInTotalShares { get; set; }
		public Nullable<decimal> StockrightEquity { get; set; }
		public Nullable<decimal> WarrantEquity { get; set; }
		public Nullable<decimal> ConvertibleBondEquity { get; set; }
		public Nullable<decimal> OtherRelatingEquity { get; set; }
		public string Statement { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

