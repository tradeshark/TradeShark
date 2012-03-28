using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_RawMaterialPurchasePIMap : EntityTypeConfiguration<ED_RawMaterialPurchasePI>
	{
		public ED_RawMaterialPurchasePIMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("ED_RawMaterialPurchasePI");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.RMPPIAllRawMaterials).HasColumnName("RMPPIAllRawMaterials");
			this.Property(t => t.RMPPIFuelsPower).HasColumnName("RMPPIFuelsPower");
			this.Property(t => t.RMPPIFerrousMetalMaterials).HasColumnName("RMPPIFerrousMetalMaterials");
			this.Property(t => t.RMPPINonFerrousMetalMaterials).HasColumnName("RMPPINonFerrousMetalMaterials");
			this.Property(t => t.RMPPIChemicalMaterials).HasColumnName("RMPPIChemicalMaterials");
			this.Property(t => t.RMPPITimberPulp).HasColumnName("RMPPITimberPulp");
			this.Property(t => t.RMPPIConstructionMaterials).HasColumnName("RMPPIConstructionMaterials");
			this.Property(t => t.RMPPIRawSemiFinishedGoods).HasColumnName("RMPPIRawSemiFinishedGoods");
			this.Property(t => t.RMPPIAgriSidelineProducts).HasColumnName("RMPPIAgriSidelineProducts");
			this.Property(t => t.RMPPIWeavingMaterials).HasColumnName("RMPPIWeavingMaterials");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

