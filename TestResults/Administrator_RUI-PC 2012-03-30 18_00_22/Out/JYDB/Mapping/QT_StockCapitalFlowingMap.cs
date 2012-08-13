using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_StockCapitalFlowingMap : EntityTypeConfiguration<QT_StockCapitalFlowing>
	{
		public QT_StockCapitalFlowingMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("QT_StockCapitalFlowing");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.BuyVolume0_1).HasColumnName("BuyVolume0_1");
			this.Property(t => t.SaleVolume0_1).HasColumnName("SaleVolume0_1");
			this.Property(t => t.BuyValue0_1).HasColumnName("BuyValue0_1");
			this.Property(t => t.SaleValue0_1).HasColumnName("SaleValue0_1");
			this.Property(t => t.BuyVolume1_5).HasColumnName("BuyVolume1_5");
			this.Property(t => t.SaleVolume1_5).HasColumnName("SaleVolume1_5");
			this.Property(t => t.BuyValue1_5).HasColumnName("BuyValue1_5");
			this.Property(t => t.SaleValue1_5).HasColumnName("SaleValue1_5");
			this.Property(t => t.BuyVolume5_10).HasColumnName("BuyVolume5_10");
			this.Property(t => t.SaleVolume5_10).HasColumnName("SaleVolume5_10");
			this.Property(t => t.BuyValue5_10).HasColumnName("BuyValue5_10");
			this.Property(t => t.SaleValue5_10).HasColumnName("SaleValue5_10");
			this.Property(t => t.BuyVolume10_N).HasColumnName("BuyVolume10_N");
			this.Property(t => t.SaleVolume10_N).HasColumnName("SaleVolume10_N");
			this.Property(t => t.BuyValue10_N).HasColumnName("BuyValue10_N");
			this.Property(t => t.SaleValue10_N).HasColumnName("SaleValue10_N");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

