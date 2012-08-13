using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_BdCDYQuotMap : EntityTypeConfiguration<QT_BdCDYQuot>
	{
		public QT_BdCDYQuotMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("QT_BdCDYQuot");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.PrevClosePriceClean).HasColumnName("PrevClosePriceClean");
			this.Property(t => t.OpenPriceClean).HasColumnName("OpenPriceClean");
			this.Property(t => t.HighPriceClean).HasColumnName("HighPriceClean");
			this.Property(t => t.LowPriceClean).HasColumnName("LowPriceClean");
			this.Property(t => t.ClosePriceClean).HasColumnName("ClosePriceClean");
			this.Property(t => t.WtdAveragePriceClean).HasColumnName("WtdAveragePriceClean");
			this.Property(t => t.PrevClosePriceDirty).HasColumnName("PrevClosePriceDirty");
			this.Property(t => t.OpenPriceDirty).HasColumnName("OpenPriceDirty");
			this.Property(t => t.HighPriceDirty).HasColumnName("HighPriceDirty");
			this.Property(t => t.LowPriceDirty).HasColumnName("LowPriceDirty");
			this.Property(t => t.ClosePriceDirty).HasColumnName("ClosePriceDirty");
			this.Property(t => t.WtdAveragePriceDirty).HasColumnName("WtdAveragePriceDirty");
			this.Property(t => t.PrevCloseYTM).HasColumnName("PrevCloseYTM");
			this.Property(t => t.OpenYTM).HasColumnName("OpenYTM");
			this.Property(t => t.HighYTM).HasColumnName("HighYTM");
			this.Property(t => t.LowYTM).HasColumnName("LowYTM");
			this.Property(t => t.CloseYTM).HasColumnName("CloseYTM");
			this.Property(t => t.YTMWtdAveragePriceDirty).HasColumnName("YTMWtdAveragePriceDirty");
			this.Property(t => t.TurnoverVolume).HasColumnName("TurnoverVolume");
			this.Property(t => t.TurnoverValue).HasColumnName("TurnoverValue");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

