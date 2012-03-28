using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_HG_SHXFPLSZE_LJMap : EntityTypeConfiguration<VIEW_HG_SHXFPLSZE_LJ>
	{
		public VIEW_HG_SHXFPLSZE_LJMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.EndDate, t.AdjustMark, t.ReportPeriod, t.ReportArea, t.XGRQ });

			// Properties
			this.Property(t => t.N_AdjustMark)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportPeriod)
				.HasMaxLength(300);
				
			this.Property(t => t.N_ReportArea)
				.HasMaxLength(300);
				
			this.Property(t => t.N_Province)
				.HasMaxLength(300);
				
			this.Property(t => t.InfoSources)
				.HasMaxLength(50);
				
			this.Property(t => t.AdjustMark)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportArea)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.Remarks)
				.HasMaxLength(500);
				
			// Table & Column Mappings
			this.ToTable("VIEW_HG_SHXFPLSZE_LJ");
			this.Property(t => t.N_AdjustMark).HasColumnName("N_AdjustMark");
			this.Property(t => t.N_ReportPeriod).HasColumnName("N_ReportPeriod");
			this.Property(t => t.N_ReportArea).HasColumnName("N_ReportArea");
			this.Property(t => t.N_Province).HasColumnName("N_Province");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSources).HasColumnName("InfoSources");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.Province).HasColumnName("Province");
			this.Property(t => t.RetailValueOfSCGoods).HasColumnName("RetailValueOfSCGoods");
			this.Property(t => t.City).HasColumnName("City");
			this.Property(t => t.County).HasColumnName("County");
			this.Property(t => t.BelowCounty).HasColumnName("BelowCounty");
			this.Property(t => t.WholesaleRetailTrade).HasColumnName("WholesaleRetailTrade");
			this.Property(t => t.FoodBeverage).HasColumnName("FoodBeverage");
			this.Property(t => t.OthersIndustry).HasColumnName("OthersIndustry");
			this.Property(t => t.Munufacture).HasColumnName("Munufacture");
			this.Property(t => t.AgriculturalProducer).HasColumnName("AgriculturalProducer");
			this.Property(t => t.StateOwnedUnits).HasColumnName("StateOwnedUnits");
			this.Property(t => t.CollectiveUnits).HasColumnName("CollectiveUnits");
			this.Property(t => t.JointVentures).HasColumnName("JointVentures");
			this.Property(t => t.SelfEmployed).HasColumnName("SelfEmployed");
			this.Property(t => t.OthersUnits).HasColumnName("OthersUnits");
			this.Property(t => t.GYoYRetailValueSCGoods).HasColumnName("GYoYRetailValueSCGoods");
			this.Property(t => t.GYoYCity).HasColumnName("GYoYCity");
			this.Property(t => t.GYoYCounty).HasColumnName("GYoYCounty");
			this.Property(t => t.GYoYBelowCounty).HasColumnName("GYoYBelowCounty");
			this.Property(t => t.GYoYWholesaleRetailTrade).HasColumnName("GYoYWholesaleRetailTrade");
			this.Property(t => t.GYoYFoodBeverage).HasColumnName("GYoYFoodBeverage");
			this.Property(t => t.GYoYOthersIndustry).HasColumnName("GYoYOthersIndustry");
			this.Property(t => t.GYoYMunufacture).HasColumnName("GYoYMunufacture");
			this.Property(t => t.GYoYAgriculturalProducer).HasColumnName("GYoYAgriculturalProducer");
			this.Property(t => t.GYoYStateOwnedUnits).HasColumnName("GYoYStateOwnedUnits");
			this.Property(t => t.GYoYCollectiveUnits).HasColumnName("GYoYCollectiveUnits");
			this.Property(t => t.GYoYJointVentures).HasColumnName("GYoYJointVentures");
			this.Property(t => t.GYoYSelfEmployed).HasColumnName("GYoYSelfEmployed");
			this.Property(t => t.GYoYOthersUnits).HasColumnName("GYoYOthersUnits");
			this.Property(t => t.Remarks).HasColumnName("Remarks");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.EXPR1).HasColumnName("EXPR1");
			this.Property(t => t.EXPR2).HasColumnName("EXPR2");
			this.Property(t => t.EXPR3).HasColumnName("EXPR3");
			this.Property(t => t.EXPR4).HasColumnName("EXPR4");
			this.Property(t => t.EXPR5).HasColumnName("EXPR5");
			this.Property(t => t.EXPR6).HasColumnName("EXPR6");
			this.Property(t => t.EXPR7).HasColumnName("EXPR7");
			this.Property(t => t.EXPR8).HasColumnName("EXPR8");
			this.Property(t => t.EXPR9).HasColumnName("EXPR9");
			this.Property(t => t.EXPR10).HasColumnName("EXPR10");
			this.Property(t => t.EXPR11).HasColumnName("EXPR11");
			this.Property(t => t.EXPR12).HasColumnName("EXPR12");
			this.Property(t => t.EXPR13).HasColumnName("EXPR13");
			this.Property(t => t.EXPR14).HasColumnName("EXPR14");
		}
	}
}

