using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class ED_FutureTradeMap : EntityTypeConfiguration<ED_FutureTrade>
	{
		public ED_FutureTradeMap()
		{
			// Primary Key
			this.HasKey(t => t.ID);

			// Properties
			this.Property(t => t.SettlementYear)
				.HasMaxLength(4);
				
			this.Property(t => t.SettlementMonth)
				.HasMaxLength(2);
				
			// Table & Column Mappings
			this.ToTable("ED_FutureTrade");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ReportPeriod).HasColumnName("ReportPeriod");
			this.Property(t => t.ReportArea).HasColumnName("ReportArea");
			this.Property(t => t.AdjustMark).HasColumnName("AdjustMark");
			this.Property(t => t.Exchange).HasColumnName("Exchange");
			this.Property(t => t.Product).HasColumnName("Product");
			this.Property(t => t.SettlementYear).HasColumnName("SettlementYear");
			this.Property(t => t.SettlementMonth).HasColumnName("SettlementMonth");
			this.Property(t => t.PrevSettlePrice).HasColumnName("PrevSettlePrice");
			this.Property(t => t.OpenPrice).HasColumnName("OpenPrice");
			this.Property(t => t.HighPrice).HasColumnName("HighPrice");
			this.Property(t => t.LowPrice).HasColumnName("LowPrice");
			this.Property(t => t.ClosePrice).HasColumnName("ClosePrice");
			this.Property(t => t.SettlePrice).HasColumnName("SettlePrice");
			this.Property(t => t.Volume).HasColumnName("Volume");
			this.Property(t => t.OpenInterest).HasColumnName("OpenInterest");
			this.Property(t => t.OpenInterestChange).HasColumnName("OpenInterestChange");
			this.Property(t => t.Turnover).HasColumnName("Turnover");
			this.Property(t => t.VolumePeriod).HasColumnName("VolumePeriod");
			this.Property(t => t.VolumePeriodLastYear).HasColumnName("VolumePeriodLastYear");
			this.Property(t => t.VolumePeriodLastPeriod).HasColumnName("VolumePeriodLastPeriod");
			this.Property(t => t.TurnoverPeriod).HasColumnName("TurnoverPeriod");
			this.Property(t => t.TurnoverPeriodLastYear).HasColumnName("TurnoverPeriodLastYear");
			this.Property(t => t.TurnoverPeriodLastPeriod).HasColumnName("TurnoverPeriodLastPeriod");
			this.Property(t => t.OIEndPeriod).HasColumnName("OIEndPeriod");
			this.Property(t => t.OIEndPeriodLastYear).HasColumnName("OIEndPeriodLastYear");
			this.Property(t => t.OIEndPeriodLastPeriod).HasColumnName("OIEndPeriodLastPeriod");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

