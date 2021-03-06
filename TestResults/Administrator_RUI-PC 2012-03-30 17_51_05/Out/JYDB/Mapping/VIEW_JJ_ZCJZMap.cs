using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class VIEW_JJ_ZCJZMap : EntityTypeConfiguration<VIEW_JJ_ZCJZ>
	{
		public VIEW_JJ_ZCJZMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.InnerCode, t.EndDate, t.XGRQ });

			// Properties
			this.Property(t => t.InnerCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.InfoSource)
				.HasMaxLength(100);
				
			// Table & Column Mappings
			this.ToTable("VIEW_JJ_ZCJZ");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.InnerCode).HasColumnName("InnerCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.InfoSource).HasColumnName("InfoSource");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.NV).HasColumnName("NV");
			this.Property(t => t.UnitNV).HasColumnName("UnitNV");
			this.Property(t => t.AccumulatedUnitNV).HasColumnName("AccumulatedUnitNV");
			this.Property(t => t.DailyProfit).HasColumnName("DailyProfit");
			this.Property(t => t.LatestWeeklyYield).HasColumnName("LatestWeeklyYield");
			this.Property(t => t.NVDailyGrowthRate).HasColumnName("NVDailyGrowthRate");
			this.Property(t => t.NVWeeklyGrowthRate).HasColumnName("NVWeeklyGrowthRate");
			this.Property(t => t.DiscountRatio).HasColumnName("DiscountRatio");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
		}
	}
}

