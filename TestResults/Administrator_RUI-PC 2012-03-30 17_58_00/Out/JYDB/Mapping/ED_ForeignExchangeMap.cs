using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_ForeignExchangeMap : EntityTypeConfiguration<ED_ForeignExchange>
	{
		public ED_ForeignExchangeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			// Table & Column Mappings
			this.ToTable("ED_ForeignExchange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.TradeCode).HasColumnName("TradeCode");
			this.Property(t => t.CurrencyBefore).HasColumnName("CurrencyBefore");
			this.Property(t => t.CurrencyAfter).HasColumnName("CurrencyAfter");
			this.Property(t => t.UnitCurrencyBefore).HasColumnName("UnitCurrencyBefore");
			this.Property(t => t.ValueDate).HasColumnName("ValueDate");
			this.Property(t => t.OpenPrice).HasColumnName("OpenPrice");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.WeightedAvgClosePrice).HasColumnName("WeightedAvgClosePrice");
			this.Property(t => t.BidPrice).HasColumnName("BidPrice");
			this.Property(t => t.AskPrice).HasColumnName("AskPrice");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.PrevClosePrice).HasColumnName("PrevClosePrice");
			this.Property(t => t.PrevWeightedAvgClosePrice).HasColumnName("PrevWeightedAvgClosePrice");
			this.Property(t => t.TradingVolume).HasColumnName("TradingVolume");
			this.Property(t => t.TradingVolumeGrowth).HasColumnName("TradingVolumeGrowth");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

