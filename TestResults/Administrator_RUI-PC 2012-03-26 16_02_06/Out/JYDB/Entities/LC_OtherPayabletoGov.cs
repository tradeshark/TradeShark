using System;
using System.Collections.Generic;

namespace FinancialEngineering.Data.Database.Entities
{
	public class LC_OtherPayabletoGov
	{
		public long ID { get; set; }
		public int CompanyCode { get; set; }
		public System.DateTime EndDate { get; set; }
		public string InfoSource { get; set; }
		public Nullable<decimal> ValueAddedTax { get; set; }
		public Nullable<decimal> BusinessTax { get; set; }
		public Nullable<decimal> BusinessTaxState { get; set; }
		public Nullable<decimal> BusinessTaxLocal { get; set; }
		public Nullable<decimal> ConsumptionTax { get; set; }
		public Nullable<decimal> CustomsDuties { get; set; }
		public Nullable<decimal> ResourceTax { get; set; }
		public Nullable<decimal> EnterpriseIncomeTax { get; set; }
		public Nullable<decimal> EnterpriseIncomeTaxF { get; set; }
		public Nullable<decimal> IndividualIncomeTax { get; set; }
		public Nullable<decimal> InterestIncomeTax { get; set; }
		public Nullable<decimal> HousePropertyTax { get; set; }
		public Nullable<decimal> UrbanRealEstateTax { get; set; }
		public Nullable<decimal> UrbanLandUseTax { get; set; }
		public Nullable<decimal> FarmLandOccupationTax { get; set; }
		public Nullable<decimal> VehicleAndVesselUsageTax { get; set; }
		public Nullable<decimal> VVULPT { get; set; }
		public Nullable<decimal> VehiclePurchaseTax { get; set; }
		public Nullable<decimal> VesselTonnageTax { get; set; }
		public Nullable<decimal> DeedTax { get; set; }
		public Nullable<decimal> EstateTax { get; set; }
		public Nullable<decimal> CityMCTax { get; set; }
		public Nullable<decimal> FAssetsInvOrientReguTax { get; set; }
		public Nullable<decimal> LandAppreciationTax { get; set; }
		public Nullable<decimal> StampTax { get; set; }
		public Nullable<decimal> SecuritiesExchangeTax { get; set; }
		public Nullable<decimal> SlaughterAndBanquetTax { get; set; }
		public Nullable<decimal> SlaughterTax { get; set; }
		public Nullable<decimal> BanquetTax { get; set; }
		public Nullable<decimal> FuelTax { get; set; }
		public Nullable<decimal> AgricultureTax { get; set; }
		public Nullable<decimal> AnimalHusbandryTax { get; set; }
		public Nullable<decimal> AgriculturalSpecialtyTax { get; set; }
		public Nullable<decimal> AllEducationSurtax { get; set; }
		public Nullable<decimal> EducationSurtax { get; set; }
		public Nullable<decimal> LocalEducationSurtax { get; set; }
		public Nullable<decimal> CountryEducationSurtax { get; set; }
		public Nullable<decimal> SocietyDevelopmentFees { get; set; }
		public Nullable<decimal> CultureDevelopmentFees { get; set; }
		public Nullable<decimal> TransportationSurcharge { get; set; }
		public Nullable<decimal> DikeAndIrrigationWorkFees { get; set; }
		public Nullable<decimal> DikeMaintenance { get; set; }
		public Nullable<decimal> RiverwayMaintenanceFee { get; set; }
		public Nullable<decimal> FloodPreventionFee { get; set; }
		public Nullable<decimal> IrrigationWorkFunds { get; set; }
		public Nullable<decimal> PriceControlFunds { get; set; }
		public Nullable<decimal> SelectiveServiceSurcharge { get; set; }
		public Nullable<decimal> PensionReserve { get; set; }
		public Nullable<decimal> OtherTaxes { get; set; }
		public Nullable<decimal> Total { get; set; }
		public int IfAdjusted { get; set; }
		public int IfMerged { get; set; }
		public Nullable<System.DateTime> ChangePublDate { get; set; }
		public System.DateTime XGRQ { get; set; }
		public long JSID { get; set; }
	}
}

