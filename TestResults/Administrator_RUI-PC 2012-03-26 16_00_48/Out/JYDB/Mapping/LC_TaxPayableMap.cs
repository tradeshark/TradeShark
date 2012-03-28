using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_TaxPayableMap : EntityTypeConfiguration<LC_TaxPayable>
	{
		public LC_TaxPayableMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.EndDate, t.IfAdjusted, t.IfMerged, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.IfAdjusted)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IfMerged)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("LC_TaxPayable");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ValueAddedTax).HasColumnName("ValueAddedTax");
			this.Property(t => t.BusinessTax).HasColumnName("BusinessTax");
			this.Property(t => t.BusinessTaxState).HasColumnName("BusinessTaxState");
			this.Property(t => t.BusinessTaxLocal).HasColumnName("BusinessTaxLocal");
			this.Property(t => t.ConsumptionTax).HasColumnName("ConsumptionTax");
			this.Property(t => t.CustomsDuties).HasColumnName("CustomsDuties");
			this.Property(t => t.ResourceTax).HasColumnName("ResourceTax");
			this.Property(t => t.EnterpriseIncomeTax).HasColumnName("EnterpriseIncomeTax");
			this.Property(t => t.EnterpriseIncomeTaxF).HasColumnName("EnterpriseIncomeTaxF");
			this.Property(t => t.IndividualIncomeTax).HasColumnName("IndividualIncomeTax");
			this.Property(t => t.InterestIncomeTax).HasColumnName("InterestIncomeTax");
			this.Property(t => t.HousePropertyTax).HasColumnName("HousePropertyTax");
			this.Property(t => t.UrbanRealEstateTax).HasColumnName("UrbanRealEstateTax");
			this.Property(t => t.UrbanLandUseTax).HasColumnName("UrbanLandUseTax");
			this.Property(t => t.FarmLandOccupationTax).HasColumnName("FarmLandOccupationTax");
			this.Property(t => t.VehicleAndVesselUsageTax).HasColumnName("VehicleAndVesselUsageTax");
			this.Property(t => t.VVULPT).HasColumnName("VVULPT");
			this.Property(t => t.VehiclePurchaseTax).HasColumnName("VehiclePurchaseTax");
			this.Property(t => t.VesselTonnageTax).HasColumnName("VesselTonnageTax");
			this.Property(t => t.DeedTax).HasColumnName("DeedTax");
			this.Property(t => t.EstateTax).HasColumnName("EstateTax");
			this.Property(t => t.CityMCTax).HasColumnName("CityMCTax");
			this.Property(t => t.FAssetsInvOrientReguTax).HasColumnName("FAssetsInvOrientReguTax");
			this.Property(t => t.LandAppreciationTax).HasColumnName("LandAppreciationTax");
			this.Property(t => t.StampTax).HasColumnName("StampTax");
			this.Property(t => t.SecuritiesExchangeTax).HasColumnName("SecuritiesExchangeTax");
			this.Property(t => t.SlaughterAndBanquetTax).HasColumnName("SlaughterAndBanquetTax");
			this.Property(t => t.SlaughterTax).HasColumnName("SlaughterTax");
			this.Property(t => t.BanquetTax).HasColumnName("BanquetTax");
			this.Property(t => t.FuelTax).HasColumnName("FuelTax");
			this.Property(t => t.AgricultureTax).HasColumnName("AgricultureTax");
			this.Property(t => t.AnimalHusbandryTax).HasColumnName("AnimalHusbandryTax");
			this.Property(t => t.AgriculturalSpecialtyTax).HasColumnName("AgriculturalSpecialtyTax");
			this.Property(t => t.AllEducationSurtax).HasColumnName("AllEducationSurtax");
			this.Property(t => t.EducationSurtax).HasColumnName("EducationSurtax");
			this.Property(t => t.LocalEducationSurtax).HasColumnName("LocalEducationSurtax");
			this.Property(t => t.CountryEducationSurtax).HasColumnName("CountryEducationSurtax");
			this.Property(t => t.SocietyDevelopmentFees).HasColumnName("SocietyDevelopmentFees");
			this.Property(t => t.CultureDevelopmentFees).HasColumnName("CultureDevelopmentFees");
			this.Property(t => t.TransportationSurcharge).HasColumnName("TransportationSurcharge");
			this.Property(t => t.DikeAndIrrigationWorkFees).HasColumnName("DikeAndIrrigationWorkFees");
			this.Property(t => t.DikeMaintenance).HasColumnName("DikeMaintenance");
			this.Property(t => t.RiverwayMaintenanceFee).HasColumnName("RiverwayMaintenanceFee");
			this.Property(t => t.FloodPreventionFee).HasColumnName("FloodPreventionFee");
			this.Property(t => t.IrrigationWorkFunds).HasColumnName("IrrigationWorkFunds");
			this.Property(t => t.PriceControlFunds).HasColumnName("PriceControlFunds");
			this.Property(t => t.SelectiveServiceSurcharge).HasColumnName("SelectiveServiceSurcharge");
			this.Property(t => t.PensionReserve).HasColumnName("PensionReserve");
			this.Property(t => t.OtherTaxes).HasColumnName("OtherTaxes");
			this.Property(t => t.Total).HasColumnName("Total");
			this.Property(t => t.IfAdjusted).HasColumnName("IfAdjusted");
			this.Property(t => t.IfMerged).HasColumnName("IfMerged");
			this.Property(t => t.ChangePublDate).HasColumnName("ChangePublDate");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

