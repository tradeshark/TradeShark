using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_AbnormalFluctuatingMap : EntityTypeConfiguration<LC_AbnormalFluctuating>
	{
		public LC_AbnormalFluctuatingMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.AbnormalType, t.TradingStartDate, t.TradingEndDate, t.TurnoverVolume, t.TurnoverSum, t.SeatName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.AbnormalType)
				.IsRequired()
				.HasMaxLength(100);
				
			this.Property(t => t.TurnoverVolume)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.TurnoverSum)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.SeatName)
				.IsRequired()
				.HasMaxLength(200);
				
			// Table & Column Mappings
			this.ToTable("LC_AbnormalFluctuating");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AbnormalType).HasColumnName("AbnormalType");
			this.Property(t => t.TradingStartDate).HasColumnName("TradingStartDate");
			this.Property(t => t.TradingEndDate).HasColumnName("TradingEndDate");
			this.Property(t => t.TurnoverVolume).HasColumnName("TurnoverVolume");
			this.Property(t => t.TurnoverSum).HasColumnName("TurnoverSum");
			this.Property(t => t.ChangePCTOffset).HasColumnName("ChangePCTOffset");
			this.Property(t => t.FluctuatingAmptitude).HasColumnName("FluctuatingAmptitude");
			this.Property(t => t.TurnoverRate).HasColumnName("TurnoverRate");
			this.Property(t => t.SeatName).HasColumnName("SeatName");
			this.Property(t => t.BuySum).HasColumnName("BuySum");
			this.Property(t => t.SaleSum).HasColumnName("SaleSum");
			this.Property(t => t.SecuCoBelonged).HasColumnName("SecuCoBelonged");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
		}
	}
}

