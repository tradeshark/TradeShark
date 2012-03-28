using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_DInterBankMap : EntityTypeConfiguration<QT_DInterBank>
	{
		public QT_DInterBankMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			// Table & Column Mappings
			this.ToTable("QT_DInterBank");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradeDay).HasColumnName("TradeDay");
			this.Property(t => t.PrevWtdAvgPriceCln).HasColumnName("PrevWtdAvgPriceCln");
			this.Property(t => t.OpenPriceCln).HasColumnName("OpenPriceCln");
			this.Property(t => t.HighPriceCln).HasColumnName("HighPriceCln");
			this.Property(t => t.LowPriceCln).HasColumnName("LowPriceCln");
			this.Property(t => t.ClosePriceCln).HasColumnName("ClosePriceCln");
			this.Property(t => t.WtdAvgPriceCln).HasColumnName("WtdAvgPriceCln");
			this.Property(t => t.ChangePCTCln).HasColumnName("ChangePCTCln");
			this.Property(t => t.PrevWtdAvgPriceDt).HasColumnName("PrevWtdAvgPriceDt");
			this.Property(t => t.OpenPriceDt).HasColumnName("OpenPriceDt");
			this.Property(t => t.HighPriceDt).HasColumnName("HighPriceDt");
			this.Property(t => t.LowPriceDt).HasColumnName("LowPriceDt");
			this.Property(t => t.ClosePriceDt).HasColumnName("ClosePriceDt");
			this.Property(t => t.WtdAvgPriceDt).HasColumnName("WtdAvgPriceDt");
			this.Property(t => t.ChangePCTDt).HasColumnName("ChangePCTDt");
			this.Property(t => t.SettleVol).HasColumnName("SettleVol");
			this.Property(t => t.SettleValue).HasColumnName("SettleValue");
			this.Property(t => t.TransactNum).HasColumnName("TransactNum");
			this.Property(t => t.AvgSettleVolPerTransact).HasColumnName("AvgSettleVolPerTransact");
			this.Property(t => t.AccrInterest).HasColumnName("AccrInterest");
			this.Property(t => t.YrMat).HasColumnName("YrMat");
			this.Property(t => t.AvgYTM).HasColumnName("AvgYTM");
			this.Property(t => t.RepoIncludeDys).HasColumnName("RepoIncludeDys");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.BondType).HasColumnName("BondType");
		}
	}
}

