using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_BondPortifolioDetailMap : EntityTypeConfiguration<View_JJ_BondPortifolioDetail>
	{
		public View_JJ_BondPortifolioDetailMap()
		{
			// Primary Key
			this.HasKey(t => new { t.N_IfInConvertibleTerm, t.ID, t.InnerCode, t.ReportDate, t.SerialNumber, t.IfInConvertibleTerm, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.StockCode)
				.HasMaxLength(10);
				
			this.Property(t => t.StockName)
				.HasMaxLength(20);
				
			this.Property(t => t.BondType)
				.HasMaxLength(300);
				
			this.Property(t => t.N_IfInConvertibleTerm)
				.IsRequired()
				.HasMaxLength(2);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SerialNumber)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_BondPortifolioDetail");
			this.Property(t => t.StockCode).HasColumnName("StockCode");
			this.Property(t => t.StockName).HasColumnName("StockName");
			this.Property(t => t.BondType).HasColumnName("BondType");
			this.Property(t => t.N_IfInConvertibleTerm).HasColumnName("N_IfInConvertibleTerm");
			this.Property(t => t.N_RatioInNV).HasColumnName("N_RatioInNV");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.BondCode).HasColumnName("BondCode");
			this.Property(t => t.HoldVolume).HasColumnName("HoldVolume");
			this.Property(t => t.MarketValue).HasColumnName("MarketValue");
			this.Property(t => t.RatioInNV).HasColumnName("RatioInNV");
			this.Property(t => t.IfInConvertibleTerm).HasColumnName("IfInConvertibleTerm");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

