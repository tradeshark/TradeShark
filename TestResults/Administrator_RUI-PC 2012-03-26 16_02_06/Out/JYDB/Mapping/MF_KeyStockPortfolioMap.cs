using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_KeyStockPortfolioMap : EntityTypeConfiguration<MF_KeyStockPortfolio>
	{
		public MF_KeyStockPortfolioMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.StockInnerCode, t.InvestType, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.StockInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InvestType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_KeyStockPortfolio");
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
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

