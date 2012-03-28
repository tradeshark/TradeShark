using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_GoldTradeMarketMap : EntityTypeConfiguration<QT_GoldTradeMarket>
	{
		public QT_GoldTradeMarketMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.TradeVariety, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			this.Property(t => t.DateType)
				.HasMaxLength(20);
				
			this.Property(t => t.TradeVariety)
				.IsRequired()
				.HasMaxLength(10);
				
			// Table & Column Mappings
			this.ToTable("QT_GoldTradeMarket");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TradeDate).HasColumnName("TradeDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.DateType).HasColumnName("DateType");
			this.Property(t => t.TradeVariety).HasColumnName("TradeVariety");
			this.Property(t => t.OpenPrice).HasColumnName("OpenPrice");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.Change).HasColumnName("Change");
			this.Property(t => t.ChangePCT).HasColumnName("ChangePCT");
			this.Property(t => t.PriceWeighted).HasColumnName("PriceWeighted");
			this.Property(t => t.TurnVol).HasColumnName("TurnVol");
			this.Property(t => t.TurnValue).HasColumnName("TurnValue");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

