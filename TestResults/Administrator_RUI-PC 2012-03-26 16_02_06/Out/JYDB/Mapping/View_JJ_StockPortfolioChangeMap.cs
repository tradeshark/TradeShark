using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class View_JJ_StockPortfolioChangeMap : EntityTypeConfiguration<View_JJ_StockPortfolioChange>
	{
		public View_JJ_StockPortfolioChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.ChangeType, t.StockInnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.StockCode)
				.HasMaxLength(10);
				
			this.Property(t => t.StockName)
				.HasMaxLength(20);
				
			this.Property(t => t.N_ChangeType)
				.HasMaxLength(300);
				
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ChangeType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.StockInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("View_JJ_StockPortfolioChange");
			this.Property(t => t.StockCode).HasColumnName("StockCode");
			this.Property(t => t.StockName).HasColumnName("StockName");
			this.Property(t => t.N_ChangeType).HasColumnName("N_ChangeType");
			this.Property(t => t.N_RatioInNVAtBegin).HasColumnName("N_RatioInNVAtBegin");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ReportDate).HasColumnName("ReportDate");
			this.Property(t => t.ChangeType).HasColumnName("ChangeType");
			this.Property(t => t.SerialNumber).HasColumnName("SerialNumber");
			this.Property(t => t.StockInnerCode).HasColumnName("StockInnerCode");
			this.Property(t => t.AccumulatedTradeSum).HasColumnName("AccumulatedTradeSum");
			this.Property(t => t.RatioInNVAtBegin).HasColumnName("RatioInNVAtBegin");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

