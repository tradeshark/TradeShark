using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_GoldProductionMap : EntityTypeConfiguration<ED_GoldProduction>
	{
		public ED_GoldProductionMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.EnterpriseName)
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("ED_GoldProduction");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DateType).HasColumnName("DateType");
			this.Property(t => t.ProductionType).HasColumnName("ProductionType");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.EnterpriseName).HasColumnName("EnterpriseName");
			this.Property(t => t.TotalIndustrialProduction).HasColumnName("TotalIndustrialProduction");
			this.Property(t => t.ProfitActualized).HasColumnName("ProfitActualized");
			this.Property(t => t.TotalAnnualPlanned).HasColumnName("TotalAnnualPlanned");
			this.Property(t => t.FinishedGoldAP).HasColumnName("FinishedGoldAP");
			this.Property(t => t.GoldContentAP).HasColumnName("GoldContentAP");
			this.Property(t => t.GoldRawAP).HasColumnName("GoldRawAP");
			this.Property(t => t.NonFerrousMetalRawAP).HasColumnName("NonFerrousMetalRawAP");
			this.Property(t => t.TotalActualProduction).HasColumnName("TotalActualProduction");
			this.Property(t => t.FinishedGoldCP).HasColumnName("FinishedGoldCP");
			this.Property(t => t.GoldContentCP).HasColumnName("GoldContentCP");
			this.Property(t => t.GoldRawCP).HasColumnName("GoldRawCP");
			this.Property(t => t.NonFerrousMetalRawCP).HasColumnName("NonFerrousMetalRawCP");
			this.Property(t => t.TotalInduProductionGYoY).HasColumnName("TotalInduProductionGYoY");
			this.Property(t => t.ProfitActualizedGYoY).HasColumnName("ProfitActualizedGYoY");
			this.Property(t => t.TotalActualProductionGYoY).HasColumnName("TotalActualProductionGYoY");
			this.Property(t => t.FinishedGoldGYoYCP).HasColumnName("FinishedGoldGYoYCP");
			this.Property(t => t.GoldContentGYoYCP).HasColumnName("GoldContentGYoYCP");
			this.Property(t => t.GoldRawGYoYCP).HasColumnName("GoldRawGYoYCP");
			this.Property(t => t.NonFerrousMetalRawGYoYCP).HasColumnName("NonFerrousMetalRawGYoYCP");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

