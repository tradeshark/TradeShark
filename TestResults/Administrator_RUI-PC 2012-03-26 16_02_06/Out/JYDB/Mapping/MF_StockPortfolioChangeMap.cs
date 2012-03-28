using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MF_StockPortfolioChangeMap : EntityTypeConfiguration<MF_StockPortfolioChange>
	{
		public MF_StockPortfolioChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.ReportDate, t.ChangeType, t.StockInnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ChangeType)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.StockInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MF_StockPortfolioChange");
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

