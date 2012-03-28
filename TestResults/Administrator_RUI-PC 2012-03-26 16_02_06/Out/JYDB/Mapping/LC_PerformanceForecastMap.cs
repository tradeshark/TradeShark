using System;
using System.Data.Entity.ModelConfiguration;
using System.Data.Common;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.DataSets.Entities;

namespace System.Web.DataSets.Mapping
{
	public class LC_PerformanceForecastMap : EntityTypeConfiguration<LC_PerformanceForecast>
	{
		public LC_PerformanceForecastMap()
		{
			// Primary Key
			this.HasKey(t => new { t.ID, t.CompanyCode, t.InfoPublDate, t.EndDate, t.XGRQ, t.JSID });

			// Properties
			this.Property(t => t.CompanyCode)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
				
			this.Property(t => t.ResultStatement)
				.HasMaxLength(24);
				
			// Table & Column Mappings
			this.ToTable("LC_PerformanceForecast");
			this.Property(t => t.ID).HasColumnName("ID");
			this.Property(t => t.CompanyCode).HasColumnName("CompanyCode");
			this.Property(t => t.InfoPublDate).HasColumnName("InfoPublDate");
			this.Property(t => t.EndDate).HasColumnName("EndDate");
			this.Property(t => t.ForcastType).HasColumnName("ForcastType");
			this.Property(t => t.ForcastReason).HasColumnName("ForcastReason");
			this.Property(t => t.ResultStatement).HasColumnName("ResultStatement");
			this.Property(t => t.ForcastContent).HasColumnName("ForcastContent");
			this.Property(t => t.XGRQ).HasColumnName("XGRQ");
			this.Property(t => t.JSID).HasColumnName("JSID");
			this.Property(t => t.EGrowthRateFloor).HasColumnName("EGrowthRateFloor");
			this.Property(t => t.EGrowthRateCeiling).HasColumnName("EGrowthRateCeiling");
			this.Property(t => t.EEarningFloor).HasColumnName("EEarningFloor");
			this.Property(t => t.EEarningCeiling).HasColumnName("EEarningCeiling");
			this.Property(t => t.EProfitFloor).HasColumnName("EProfitFloor");
			this.Property(t => t.EProfitCeiling).HasColumnName("EProfitCeiling");
			this.Property(t => t.EEPSFloor).HasColumnName("EEPSFloor");
			this.Property(t => t.EEPSCeiling).HasColumnName("EEPSCeiling");
			this.Property(t => t.ForecastObject).HasColumnName("ForecastObject");
			this.Property(t => t.NPYOYConsistentForecast).HasColumnName("NPYOYConsistentForecast");
		}
	}
}

