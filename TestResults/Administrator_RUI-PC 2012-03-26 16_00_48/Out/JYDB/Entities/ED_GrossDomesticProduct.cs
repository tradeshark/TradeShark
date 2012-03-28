using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_GrossDomesticProduct
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSources { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> GNP { get; set; }
		public Nullable<decimal> GDP { get; set; }
		public Nullable<decimal> PrimaryIndustryGDP { get; set; }
		public Nullable<decimal> SecondIndustryGDP { get; set; }
		public Nullable<decimal> IndustryGDP { get; set; }
		public Nullable<decimal> ConstructionGDP { get; set; }
		public Nullable<decimal> ThirdIndustryGDP { get; set; }
		public Nullable<decimal> FarmingService { get; set; }
		public Nullable<decimal> GeoExplWaterConservancy { get; set; }
		public Nullable<decimal> TrafficStorageTelecom { get; set; }
		public Nullable<decimal> WRTradeFoodBeverage { get; set; }
		public Nullable<decimal> FinanceInsurance { get; set; }
		public Nullable<decimal> RealEstate { get; set; }
		public Nullable<decimal> SocialService { get; set; }
		public Nullable<decimal> HealthSportsSocialWelfare { get; set; }
		public Nullable<decimal> EduArtsRadioMoviesTV { get; set; }
		public Nullable<decimal> SciResearchTechService { get; set; }
		public Nullable<decimal> StatePartyOrgSocialGroup { get; set; }
		public Nullable<decimal> OtherSectors { get; set; }
		public Nullable<decimal> GDPPerCapita { get; set; }
		public Nullable<decimal> GDPGrowthYOY { get; set; }
		public Nullable<decimal> GYOYofPrimaryIndustryGDP { get; set; }
		public Nullable<decimal> GYOYofSecondIndustryGDP { get; set; }
		public Nullable<decimal> GYOYofTertiaryGDP { get; set; }
		public Nullable<decimal> IncomeMethodGDP { get; set; }
		public Nullable<decimal> LaborCompensation { get; set; }
		public Nullable<decimal> FixedAssetDepreciation { get; set; }
		public Nullable<decimal> ProductionTaxNet { get; set; }
		public Nullable<decimal> OperatingBalance { get; set; }
		public Nullable<decimal> ExpenditureMethodGDP { get; set; }
		public Nullable<decimal> FinalConsumptionABSValue { get; set; }
		public Nullable<decimal> ResidentConsumption { get; set; }
		public Nullable<decimal> RuralResidentConsumption { get; set; }
		public Nullable<decimal> UrbanResidentConsumption { get; set; }
		public Nullable<decimal> GovernmentalConsumption { get; set; }
		public Nullable<decimal> GrossCapitalFormedABSValue { get; set; }
		public Nullable<decimal> GrossFixedCapitalFormation { get; set; }
		public Nullable<decimal> InventoryIncreasement { get; set; }
		public Nullable<decimal> GoodsServicesNetExport { get; set; }
		public Nullable<decimal> CapitalFormationRateInvest { get; set; }
		public Nullable<decimal> FinalConsumptionRate { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
		public Nullable<System.DateTime> InfoPublDate { get; set; }
	}
}

