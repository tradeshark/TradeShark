using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class ED_RealEstatePriceIndex
	{
		public long ID { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSources { get; set; }
		public Nullable<int> ReportPeriod { get; set; }
		public Nullable<int> ReportArea { get; set; }
		public Nullable<int> Province { get; set; }
		public Nullable<decimal> SalesPriceIndexRE { get; set; }
		public Nullable<decimal> CommercialHouse { get; set; }
		public Nullable<decimal> ResidenceCommercialHouse { get; set; }
		public Nullable<decimal> EconomicallyAffordableHouse { get; set; }
		public Nullable<decimal> SettleDownProject { get; set; }
		public Nullable<decimal> OrdinaryFlat { get; set; }
		public Nullable<decimal> SingleLayerFlat { get; set; }
		public Nullable<decimal> MultiLayerFlat { get; set; }
		public Nullable<decimal> HighRiser { get; set; }
		public Nullable<decimal> LuxuriousFlat { get; set; }
		public Nullable<decimal> Villa { get; set; }
		public Nullable<decimal> ClassyApartment { get; set; }
		public Nullable<decimal> NonResidence { get; set; }
		public Nullable<decimal> OfficeBuilding { get; set; }
		public Nullable<decimal> BusinessOffice { get; set; }
		public Nullable<decimal> Others { get; set; }
		public Nullable<decimal> PrivateHouseTransaction { get; set; }
		public Nullable<decimal> ResidencePersonalHT { get; set; }
		public Nullable<decimal> NonResidencePHT { get; set; }
		public Nullable<decimal> SecondHandHouseTransaction { get; set; }
		public Nullable<decimal> CommercialHouseSHHT { get; set; }
		public Nullable<decimal> ResidenceSHHT { get; set; }
		public Nullable<decimal> PublicHouseTransaction { get; set; }
		public Nullable<decimal> ResidencePublicHT { get; set; }
		public Nullable<decimal> CostPricedHousePHT { get; set; }
		public Nullable<decimal> StandardPricedHousePHT { get; set; }
		public Nullable<decimal> LeasingPriceIndexRE { get; set; }
		public Nullable<decimal> Residence { get; set; }
		public Nullable<decimal> PublicResidence { get; set; }
		public Nullable<decimal> PrivateHouse { get; set; }
		public Nullable<decimal> Office { get; set; }
		public Nullable<decimal> HiStandardOfficeBuilding { get; set; }
		public Nullable<decimal> OrdinaryOfficeBuilding { get; set; }
		public Nullable<decimal> CommercialBuilding { get; set; }
		public Nullable<decimal> WorkshopWarehouse { get; set; }
		public Nullable<decimal> IndustrialWorkshop { get; set; }
		public Nullable<decimal> Warehouse { get; set; }
		public Nullable<decimal> LandTransactionPriceIndex { get; set; }
		public Nullable<decimal> ResidenceLand { get; set; }
		public Nullable<decimal> LuxuriousHouseLand { get; set; }
		public Nullable<decimal> OrdinaryHouseLand { get; set; }
		public Nullable<decimal> IndustrialLand { get; set; }
		public Nullable<decimal> BizTourismEntertainmentLand { get; set; }
		public Nullable<decimal> ComplexApplicationLand { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

