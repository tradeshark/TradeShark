using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_JJ_HYPZMap : EntityTypeConfiguration<VIEW_JJ_HYPZ>
	{
		public VIEW_JJ_HYPZMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.InvestType, t.IndustryName, t.XGRQ });

			// Properties
			this.Property(t => t.N_InvestType)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InvestType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.IndustryCode)
				.HasMaxLength(20);
				
			this.Property(t => t.IndustryName)
				.IsRequired()
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("VIEW_JJ_HYPZ");
			this.Property(t => t.N_InvestType).HasColumnName("N_InvestType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.InvestType).HasColumnName("InvestType");
			this.Property(t => t.IndustryCode).HasColumnName("IndustryCode");
			this.Property(t => t.IndustryName).HasColumnName("IndustryName");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.RatioInNV).HasColumnName("RatioInNV");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

