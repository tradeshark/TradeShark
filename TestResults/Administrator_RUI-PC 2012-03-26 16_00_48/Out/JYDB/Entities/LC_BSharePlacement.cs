using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_BSharePlacement
	{
		public long ID { get; set; }
		public int InnerCode { get; set; }
		public System.DateTime InitialInfoPublDate { get; set; }
		public Nullable<System.DateTime> PlaYear { get; set; }
		public string StockType { get; set; }
		public Nullable<System.DateTime> AdvanceDate { get; set; }
		public Nullable<System.DateTime> SMDeciPublDate { get; set; }
		public Nullable<System.DateTime> AdvanceValidStartDate { get; set; }
		public Nullable<System.DateTime> AdvanceValidEndDate { get; set; }
		public Nullable<decimal> PlaRatioPlanned { get; set; }
		public Nullable<int> PricingModel { get; set; }
		public string PricingDescription { get; set; }
		public string PriceUnit { get; set; }
		public Nullable<decimal> PlaPriceCeilingRMB { get; set; }
		public Nullable<decimal> PlaPriceFloorRMB { get; set; }
		public Nullable<decimal> PlaPriceCeilingFC { get; set; }
		public Nullable<decimal> PlaPriceFloorFC { get; set; }
		public Nullable<System.DateTime> AuthorizedDeclareDate { get; set; }
		public Nullable<System.DateTime> PlaProspectusPublDate { get; set; }
		public string WarrantAbbrName { get; set; }
		public string WarrantCode { get; set; }
		public Nullable<decimal> ActualPlaRatio { get; set; }
		public string PlaObject { get; set; }
		public Nullable<decimal> ParValueRMB { get; set; }
		public Nullable<decimal> PlaPriceRMB { get; set; }
		public Nullable<decimal> PlaPriceFC { get; set; }
		public Nullable<decimal> PlannedPlaVol { get; set; }
		public Nullable<int> OddLotsTreatment { get; set; }
		public Nullable<System.DateTime> LastTradingDay { get; set; }
		public Nullable<System.DateTime> ExRightDate { get; set; }
		public Nullable<System.DateTime> RightRegDate { get; set; }
		public Nullable<System.DateTime> WarrantTradeStartDate { get; set; }
		public Nullable<System.DateTime> WarrantTradeEndDate { get; set; }
		public Nullable<System.DateTime> PayStartDate { get; set; }
		public Nullable<System.DateTime> PayEndDate { get; set; }
		public Nullable<System.DateTime> PlaListDate { get; set; }
		public Nullable<decimal> IPOProceedsRMB { get; set; }
		public Nullable<decimal> IssueCostRMB { get; set; }
		public Nullable<decimal> IPONetProceedsRMB { get; set; }
		public Nullable<decimal> IPOProceedsFC { get; set; }
		public Nullable<decimal> IssueCostFC { get; set; }
		public Nullable<decimal> IPONetProceedsFC { get; set; }
		public Nullable<int> SchemeChange { get; set; }
		public string ChangeStatement { get; set; }
		public Nullable<int> UnderwritingMode { get; set; }
		public Nullable<decimal> ActualPlaVol { get; set; }
		public Nullable<decimal> UnderwriterBoughtVol { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

