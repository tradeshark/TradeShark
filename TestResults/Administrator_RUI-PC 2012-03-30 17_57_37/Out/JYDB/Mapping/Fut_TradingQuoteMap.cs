using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class Fut_TradingQuoteMap : EntityTypeConfiguration<Fut_TradingQuote>
	{
		public Fut_TradingQuoteMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.ContractInnerCode, t.TradingDay, t.UpdateTime, t.JSID });

			// Properties
			this.Property(t => t.ContractInnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ContractCode)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("Fut_TradingQuote");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.ContractInnerCode).HasColumnName("ContractInnerCode");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.ContractCode).HasColumnName("ContractCode");
			this.Property(t => t.ExchangeCode).HasColumnName("ExchangeCode");
			this.Property(t => t.OptionCode).HasColumnName("OptionCode");
			this.Property(t => t.SeriesFlag).HasColumnName("SeriesFlag");
			this.Property(t => t.PrevSettlePrice).HasColumnName("PrevSettlePrice");
			this.Property(t => t.PrevClosePrice).HasColumnName("PrevClosePrice");
			this.Property(t => t.OpenPrice).HasColumnName("OpenPrice");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.ChangeOfCTPS).HasColumnName("ChangeOfCTPS");
			this.Property(t => t.ChangePCTCTPS).HasColumnName("ChangePCTCTPS");
			this.Property(t => t.ChangeOfClosePrice).HasColumnName("ChangeOfClosePrice");
			this.Property(t => t.ChangePCTClosePrice).HasColumnName("ChangePCTClosePrice");
			this.Property(t => t.SettlePrice).HasColumnName("SettlePrice");
			this.Property(t => t.ChangeOfSettPrice).HasColumnName("ChangeOfSettPrice");
			this.Property(t => t.ChangePCTSettPrice).HasColumnName("ChangePCTSettPrice");
			this.Property(t => t.OpenInterest).HasColumnName("OpenInterest");
			this.Property(t => t.ChangeOfOpenInterest).HasColumnName("ChangeOfOpenInterest");
			this.Property(t => t.ChangePCTOpenInterest).HasColumnName("ChangePCTOpenInterest");
			this.Property(t => t.TurnoverVolume).HasColumnName("TurnoverVolume");
			this.Property(t => t.ChangeOfTurnoverVolume).HasColumnName("ChangeOfTurnoverVolume");
			this.Property(t => t.ChangePCTTurnoverVolume).HasColumnName("ChangePCTTurnoverVolume");
			this.Property(t => t.TurnoverValue).HasColumnName("TurnoverValue");
			this.Property(t => t.ChangeOfTurnoverValue).HasColumnName("ChangeOfTurnoverValue");
			this.Property(t => t.ChangePCTTurnoverValue).HasColumnName("ChangePCTTurnoverValue");
			this.Property(t => t.BasisValue).HasColumnName("BasisValue");
			this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

