using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class MT_TradingStatMap : EntityTypeConfiguration<MT_TradingStat>
	{
		public MT_TradingStatMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TradingDay, t.SecuMarket, t.ReportPeriod, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.SecuMarket)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ReportPeriod)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("MT_TradingStat");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.SecuMarket).HasColumnName("SecuMarket");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.FinanceValue).HasColumnName("FinanceValue");
			this.Property(t => t.FinanceBuyValue).HasColumnName("FinanceBuyValue");
			this.Property(t => t.FinanceRefundValue).HasColumnName("FinanceRefundValue");
			this.Property(t => t.SecurityValue).HasColumnName("SecurityValue");
			this.Property(t => t.SecuritySellVolume).HasColumnName("SecuritySellVolume");
			this.Property(t => t.TradingValue).HasColumnName("TradingValue");
			this.Property(t => t.FinaInTVRatio).HasColumnName("FinaInTVRatio");
			this.Property(t => t.TVChangeRatio).HasColumnName("TVChangeRatio");
			this.Property(t => t.TVChangeRatioHS).HasColumnName("TVChangeRatioHS");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

