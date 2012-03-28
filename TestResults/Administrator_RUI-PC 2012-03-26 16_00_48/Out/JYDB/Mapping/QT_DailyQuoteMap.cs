using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FinancialEngineering.Data.Database.JYDB.Entities;

namespace FinancialEngineering.Data.Database.JYDB.Mapping
{
	public class QT_DailyQuoteMap : EntityTypeConfiguration<QT_DailyQuote>
	{
		public QT_DailyQuoteMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			// Table & Column Mappings
			this.ToTable("QT_DailyQuote");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.PrevClosePrice).HasColumnName("PrevClosePrice");
			this.Property(t => t.OpenPrice).HasColumnName("OpenPrice");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.TurnoverVolume).HasColumnName("TurnoverVolume");
			this.Property(t => t.TurnoverValue).HasColumnName("TurnoverValue");
			this.Property(t => t.TurnoverDeals).HasColumnName("TurnoverDeals");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

