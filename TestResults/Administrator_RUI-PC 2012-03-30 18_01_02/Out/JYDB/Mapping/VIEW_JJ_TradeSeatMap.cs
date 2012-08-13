using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_JJ_TradeSeatMap : EntityTypeConfiguration<VIEW_JJ_TradeSeat>
	{
		public VIEW_JJ_TradeSeatMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.SecuCoName, t.XGRQ });

			// Properties
			this.Property(t => t.N_InstitutionCode)
				.HasMaxLength(100);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.SecuCoName)
				.IsRequired()
				.HasMaxLength(40);
				
			// Table & Column Mappings
			this.ToTable("VIEW_JJ_TradeSeat");
			this.Property(t => t.N_InstitutionCode).HasColumnName("N_InstitutionCode");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.SecuCoName).HasColumnName("SecuCoName");
			this.Property(t => t.InstitutionCode).HasColumnName("InstitutionCode");
			this.Property(t => t.StockTradeVolume).HasColumnName("StockTradeVolume");
			this.Property(t => t.RatioInTotalStockTrade).HasColumnName("RatioInTotalStockTrade");
			this.Property(t => t.BondTradeVolume).HasColumnName("BondTradeVolume");
			this.Property(t => t.RatioInTotalBondTrade).HasColumnName("RatioInTotalBondTrade");
			this.Property(t => t.BondRepoVolume).HasColumnName("BondRepoVolume");
			this.Property(t => t.RatioInTotalRepoVolume).HasColumnName("RatioInTotalRepoVolume");
			this.Property(t => t.Commision).HasColumnName("Commision");
			this.Property(t => t.RatioInTotalCommision).HasColumnName("RatioInTotalCommision");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

