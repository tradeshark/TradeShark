using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_GoldProduction
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> DateType { get; set; }
		public Nullable<int> ProductionType { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public string EnterpriseName { get; set; }
		public Nullable<decimal> TotalIndustrialProduction { get; set; }
		public Nullable<decimal> ProfitActualized { get; set; }
		public Nullable<decimal> TotalAnnualPlanned { get; set; }
		public Nullable<decimal> FinishedGoldAP { get; set; }
		public Nullable<decimal> GoldContentAP { get; set; }
		public Nullable<decimal> GoldRawAP { get; set; }
		public Nullable<decimal> NonFerrousMetalRawAP { get; set; }
		public Nullable<decimal> TotalActualProduction { get; set; }
		public Nullable<decimal> FinishedGoldCP { get; set; }
		public Nullable<decimal> GoldContentCP { get; set; }
		public Nullable<decimal> GoldRawCP { get; set; }
		public Nullable<decimal> NonFerrousMetalRawCP { get; set; }
		public Nullable<decimal> TotalInduProductionGYoY { get; set; }
		public Nullable<decimal> ProfitActualizedGYoY { get; set; }
		public Nullable<decimal> TotalActualProductionGYoY { get; set; }
		public Nullable<decimal> FinishedGoldGYoYCP { get; set; }
		public Nullable<decimal> GoldContentGYoYCP { get; set; }
		public Nullable<decimal> GoldRawGYoYCP { get; set; }
		public Nullable<decimal> NonFerrousMetalRawGYoYCP { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

