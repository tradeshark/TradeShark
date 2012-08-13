using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_RetailPriceIndexMap : EntityTypeConfiguration<ED_RetailPriceIndex>
	{
		public ED_RetailPriceIndexMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Sources)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_RetailPriceIndex");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.Sources).HasColumnName("Sources");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.RPICommodityRetail).HasColumnName("RPICommodityRetail");
			this.Property(t => t.RPIFood).HasColumnName("RPIFood");
			this.Property(t => t.RPIGrains).HasColumnName("RPIGrains");
			this.Property(t => t.RPIMeatPoultryEggs).HasColumnName("RPIMeatPoultryEggs");
			this.Property(t => t.RPIFishandSeaFood).HasColumnName("RPIFishandSeaFood");
			this.Property(t => t.RPIVegetables).HasColumnName("RPIVegetables");
			this.Property(t => t.RPIDinningIdustry).HasColumnName("RPIDinningIdustry");
			this.Property(t => t.RPITobaccoandWines).HasColumnName("RPITobaccoandWines");
			this.Property(t => t.RPIClothingsShoesCaps).HasColumnName("RPIClothingsShoesCaps");
			this.Property(t => t.RPITextiles).HasColumnName("RPITextiles");
			this.Property(t => t.RPIHomeElectricalAVM).HasColumnName("RPIHomeElectricalAVM");
			this.Property(t => t.RPICulturalOffice).HasColumnName("RPICulturalOffice");
			this.Property(t => t.RPIDailyNecessities).HasColumnName("RPIDailyNecessities");
			this.Property(t => t.RPISportEntertainment).HasColumnName("RPISportEntertainment");
			this.Property(t => t.RPITrafficTelecom).HasColumnName("RPITrafficTelecom");
			this.Property(t => t.RPIFurniture).HasColumnName("RPIFurniture");
			this.Property(t => t.RPICosmetic).HasColumnName("RPICosmetic");
			this.Property(t => t.RPIGoldSilverJewelry).HasColumnName("RPIGoldSilverJewelry");
			this.Property(t => t.RPIMedicinesHealthProducts).HasColumnName("RPIMedicinesHealthProducts");
			this.Property(t => t.RPIBookElecPublications).HasColumnName("RPIBookElecPublications");
			this.Property(t => t.RPIFuel).HasColumnName("RPIFuel");
			this.Property(t => t.RPIConstructionMetalsElec).HasColumnName("RPIConstructionMetalsElec");
			this.Property(t => t.RPIAgriProductionMaterial).HasColumnName("RPIAgriProductionMaterial");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
		}
	}
}

