using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_HouseProsperityIndex
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<int> AdjustMark { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> HouseProsperityIndex { get; set; }
		public Nullable<decimal> CapitalSourceIndex { get; set; }
		public Nullable<decimal> HouseBuildingAreaIndex { get; set; }
		public Nullable<decimal> CommodityHouseSalesIndex { get; set; }
		public Nullable<decimal> REDevelopmentInvIndex { get; set; }
		public Nullable<decimal> VacancyAreaIndexCH { get; set; }
		public Nullable<decimal> LandAreaDevelopedIndex { get; set; }
		public Nullable<decimal> NewDevelopedLandAreaIndex { get; set; }
		public Nullable<decimal> LandTransferIncomeIndex { get; set; }
		public Nullable<decimal> FinishedBuildingAreaIndex { get; set; }
		public Nullable<decimal> NationProsperityIndexGYoY { get; set; }
		public Nullable<decimal> CapitalSourceIndexGYoY { get; set; }
		public Nullable<decimal> HouseBuildingAreaIndexGYoY { get; set; }
		public Nullable<decimal> CommodityHouseSalesIndexGYoY { get; set; }
		public Nullable<decimal> REDevelopmentInvIndexGYoY { get; set; }
		public Nullable<decimal> VacancyAreaIndexCHGYoY { get; set; }
		public Nullable<decimal> LandAreaDevelopedIndexGYoY { get; set; }
		public Nullable<decimal> NewDevelopedLandAreaIndexGYoY { get; set; }
		public Nullable<decimal> LandTransferIncomeIndexGYoY { get; set; }
		public Nullable<decimal> FinishedBuildingAreaIndexGYoY { get; set; }
		public Nullable<decimal> NationProsperityIndexGCP { get; set; }
		public Nullable<decimal> CapitalSourceIndexGCP { get; set; }
		public Nullable<decimal> HouseBuildingAreaIndexGCP { get; set; }
		public Nullable<decimal> CommodityHouseSalesIndexGCP { get; set; }
		public Nullable<decimal> REDevelopmentInvIndexGCP { get; set; }
		public Nullable<decimal> VacancyAreaIndexCHGCP { get; set; }
		public Nullable<decimal> LandAreaDevelopedIndexGCP { get; set; }
		public Nullable<decimal> NewDevelopedLandAreaIndexGCP { get; set; }
		public Nullable<decimal> LandTransferIncomeIndexGCP { get; set; }
		public Nullable<decimal> FinishedBuildingAreaIndexGCP { get; set; }
		public string Remarks { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

