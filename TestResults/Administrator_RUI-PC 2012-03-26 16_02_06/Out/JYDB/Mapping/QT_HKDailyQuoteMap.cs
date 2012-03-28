using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class QT_HKDailyQuoteMap : EntityTypeConfiguration<QT_HKDailyQuote>
	{
		public QT_HKDailyQuoteMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.Currency)
				.HasMaxLength(20);
				
			// Table & Column Mappings
			this.ToTable("QT_HKDailyQuote");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.TurnoverValue).HasColumnName("TurnoverValue");
			this.Property(t => t.TurnoverVolume).HasColumnName("TurnoverVolume");
			this.Property(t => t.Lot).HasColumnName("Lot");
			this.Property(t => t.OpenPrice).HasColumnName("OpenPrice");
			this.Property(t => t.Change).HasColumnName("Change");
			this.Property(t => t.PrevClosePrice).HasColumnName("PrevClosePrice");
			this.Property(t => t.PERatio).HasColumnName("PERatio");
			this.Property(t => t.DividendYield).HasColumnName("DividendYield");
			this.Property(t => t.BidVolume).HasColumnName("BidVolume");
			this.Property(t => t.AskVolume).HasColumnName("AskVolume");
			this.Property(t => t.BidPrice).HasColumnName("BidPrice");
			this.Property(t => t.AskPrice).HasColumnName("AskPrice");
			this.Property(t => t.ChangePCT).HasColumnName("ChangePCT");
			this.Property(t => t.Currency).HasColumnName("Currency");
			this.Property(t => t.SMA10).HasColumnName("SMA10");
			this.Property(t => t.SMA20).HasColumnName("SMA20");
			this.Property(t => t.SMA50).HasColumnName("SMA50");
			this.Property(t => t.SMA250).HasColumnName("SMA250");
			this.Property(t => t.AnnualHigh).HasColumnName("AnnualHigh");
			this.Property(t => t.AnnualLow).HasColumnName("AnnualLow");
			this.Property(t => t.MonthHigh).HasColumnName("MonthHigh");
			this.Property(t => t.MonthLow).HasColumnName("MonthLow");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

