using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_JJ_ZCGMap : EntityTypeConfiguration<VIEW_JJ_ZCG>
	{
		public VIEW_JJ_ZCGMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.StockInnerCode, t.InvestType, t.XGRQ });

			// Properties
			this.Property(t => t.StockCode)
				.HasMaxLength(10);
				
			this.Property(t => t.StockName)
				.HasMaxLength(20);
				
			this.Property(t => t.IndustryName)
				.HasMaxLength(50);
				
			this.Property(t => t.N_InvestType)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.StockInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InvestType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("VIEW_JJ_ZCG");
			this.Property(t => t.StockCode).HasColumnName("StockCode");
			this.Property(t => t.StockName).HasColumnName("StockName");
			this.Property(t => t.IndustryName).HasColumnName("IndustryName");
			this.Property(t => t.N_InvestType).HasColumnName("N_InvestType");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.StockInnerCode).HasColumnName("StockInnerCode");
			this.Property(t => t.SharesHolding).HasColumnName("SharesHolding");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.RatioInNV).HasColumnName("RatioInNV");
			this.Property(t => t.InvestType).HasColumnName("InvestType");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

