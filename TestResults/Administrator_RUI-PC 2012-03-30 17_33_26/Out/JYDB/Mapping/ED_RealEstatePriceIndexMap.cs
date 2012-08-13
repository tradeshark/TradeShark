using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_RealEstatePriceIndexMap : EntityTypeConfiguration<ED_RealEstatePriceIndex>
	{
		public ED_RealEstatePriceIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_RealEstatePriceIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.SalesPriceIndexRE).HasColumnName("SalesPriceIndexRE");
			this.Property(t => t.CommercialHouse).HasColumnName("CommercialHouse");
			this.Property(t => t.ResidenceCommercialHouse).HasColumnName("ResidenceCommercialHouse");
			this.Property(t => t.EconomicallyAffordableHouse).HasColumnName("EconomicallyAffordableHouse");
			this.Property(t => t.SettleDownProject).HasColumnName("SettleDownProject");
			this.Property(t => t.OrdinaryFlat).HasColumnName("OrdinaryFlat");
			this.Property(t => t.SingleLayerFlat).HasColumnName("SingleLayerFlat");
			this.Property(t => t.MultiLayerFlat).HasColumnName("MultiLayerFlat");
			this.Property(t => t.HighRiser).HasColumnName("HighRiser");
			this.Property(t => t.LuxuriousFlat).HasColumnName("LuxuriousFlat");
			this.Property(t => t.Villa).HasColumnName("Villa");
			this.Property(t => t.ClassyApartment).HasColumnName("ClassyApartment");
			this.Property(t => t.NonResidence).HasColumnName("NonResidence");
			this.Property(t => t.OfficeBuilding).HasColumnName("OfficeBuilding");
			this.Property(t => t.BusinessOffice).HasColumnName("BusinessOffice");
			this.Property(t => t.Others).HasColumnName("Others");
			this.Property(t => t.PrivateHouseTransaction).HasColumnName("PrivateHouseTransaction");
			this.Property(t => t.ResidencePersonalHT).HasColumnName("ResidencePersonalHT");
			this.Property(t => t.NonResidencePHT).HasColumnName("NonResidencePHT");
			this.Property(t => t.SecondHandHouseTransaction).HasColumnName("SecondHandHouseTransaction");
			this.Property(t => t.CommercialHouseSHHT).HasColumnName("CommercialHouseSHHT");
			this.Property(t => t.ResidenceSHHT).HasColumnName("ResidenceSHHT");
			this.Property(t => t.PublicHouseTransaction).HasColumnName("PublicHouseTransaction");
			this.Property(t => t.ResidencePublicHT).HasColumnName("ResidencePublicHT");
			this.Property(t => t.CostPricedHousePHT).HasColumnName("CostPricedHousePHT");
			this.Property(t => t.StandardPricedHousePHT).HasColumnName("StandardPricedHousePHT");
			this.Property(t => t.LeasingPriceIndexRE).HasColumnName("LeasingPriceIndexRE");
			this.Property(t => t.Residence).HasColumnName("Residence");
			this.Property(t => t.PublicResidence).HasColumnName("PublicResidence");
			this.Property(t => t.PrivateHouse).HasColumnName("PrivateHouse");
			this.Property(t => t.Office).HasColumnName("Office");
			this.Property(t => t.HiStandardOfficeBuilding).HasColumnName("HiStandardOfficeBuilding");
			this.Property(t => t.OrdinaryOfficeBuilding).HasColumnName("OrdinaryOfficeBuilding");
			this.Property(t => t.CommercialBuilding).HasColumnName("CommercialBuilding");
			this.Property(t => t.WorkshopWarehouse).HasColumnName("WorkshopWarehouse");
			this.Property(t => t.IndustrialWorkshop).HasColumnName("IndustrialWorkshop");
			this.Property(t => t.Warehouse).HasColumnName("Warehouse");
			this.Property(t => t.LandTransactionPriceIndex).HasColumnName("LandTransactionPriceIndex");
			this.Property(t => t.ResidenceLand).HasColumnName("ResidenceLand");
			this.Property(t => t.LuxuriousHouseLand).HasColumnName("LuxuriousHouseLand");
			this.Property(t => t.OrdinaryHouseLand).HasColumnName("OrdinaryHouseLand");
			this.Property(t => t.IndustrialLand).HasColumnName("IndustrialLand");
			this.Property(t => t.BizTourismEntertainmentLand).HasColumnName("BizTourismEntertainmentLand");
			this.Property(t => t.ComplexApplicationLand).HasColumnName("ComplexApplicationLand");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

