using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_7PercentChangeMap : EntityTypeConfiguration<LC_7PercentChange>
	{
		public LC_7PercentChangeMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.TradingDay, t.SerialNum, t.SalesDepartmentName, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(50);
				
			this.Property(t => t.SalesDepartmentName)
				.IsRequired()
				.HasMaxLength(200);
				
			this.Property(t => t.SecuCoBelonged)
				.HasMaxLength(80);
				
			// Table & Column Mappings
			this.ToTable("LC_7PercentChange");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.AbnormalType).HasColumnName("AbnormalType");
			this.Property(t => t.TradingStartDate).HasColumnName("TradingStartDate");
			this.Property(t => t.TradingDay).HasColumnName("TradingDay");
			this.Property(t => t.SerialNum).HasColumnName("SerialNum");
			this.Property(t => t.SalesDepartmentName).HasColumnName("SalesDepartmentName");
			this.Property(t => t.SecuCoBelongedCode).HasColumnName("SecuCoBelongedCode");
			this.Property(t => t.SecuCoBelonged).HasColumnName("SecuCoBelonged");
			this.Property(t => t.TurnoverVolume).HasColumnName("TurnoverVolume");
			this.Property(t => t.TurnoverValue).HasColumnName("TurnoverValue");
			this.Property(t => t.ChangePCT).HasColumnName("ChangePCT");
			this.Property(t => t.ChangePCTOffset).HasColumnName("ChangePCTOffset");
			this.Property(t => t.FluctuatingAmptitude).HasColumnName("FluctuatingAmptitude");
			this.Property(t => t.TurnoverRate).HasColumnName("TurnoverRate");
			this.Property(t => t.TotalBuySaleSum).HasColumnName("TotalBuySaleSum");
			this.Property(t => t.BuySum).HasColumnName("BuySum");
			this.Property(t => t.SaleSum).HasColumnName("SaleSum");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.StatType).HasColumnName("StatType");
		}
	}
}

